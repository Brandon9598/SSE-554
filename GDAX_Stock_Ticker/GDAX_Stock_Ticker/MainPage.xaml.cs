using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Timers;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GDAX_Stock_Ticker
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        DispatcherTimer Timer = new DispatcherTimer();
        GDAX_Monitor gdax_Monitor = new GDAX_Monitor();
        decimal prevPrice = 0;

        public MainPage()
        {
            this.InitializeComponent();
            DataContext = this;
            Timer.Tick += Timer_Tick;
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();
        }

        private void updatePrice()
        {
            decimal currentPrice = gdax_Monitor.GetBitCoinValue();
            if(currentPrice > prevPrice)
            {
                priceLabel.Foreground = new SolidColorBrush(Colors.Green);
            }
            else if(currentPrice == prevPrice){
                priceLabel.Foreground = new SolidColorBrush(Colors.Black);
            }
            else
            {
                priceLabel.Foreground = new SolidColorBrush(Colors.Red);
            }
            prevPrice = currentPrice;
            priceLabel.Text = gdax_Monitor.GetBitCoinValue().ToString("C");
        }

        private void Timer_Tick(object sender, object e)
        {
            timeLabel.Text = DateTime.Now.ToString("h:mm:ss tt");
            updatePrice();
        }
    }
}
