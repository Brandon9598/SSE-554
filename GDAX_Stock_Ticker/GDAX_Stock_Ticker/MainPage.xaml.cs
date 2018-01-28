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

        private List<PricePoint> btcValueList = new List<PricePoint>();
        private List<PricePoint> ethValueList = new List<PricePoint>();


        decimal btcPrevPrice = 0;
        decimal ethPrevPrice = 0;

        public MainPage()
        {
            this.InitializeComponent();
            DataContext = this;
            Timer.Tick += Timer_Tick;
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();
        }

        private void updateBTCPrice()
        {
            decimal btcCurrentPrice = gdax_Monitor.GetBitCoinValue();
            btcPriceLabel.Foreground = new SolidColorBrush(ColorPicker.valueToColor(btcPrevPrice, btcCurrentPrice));
            btcPrevPrice = btcCurrentPrice;
            PricePoint pricepoint = new PricePoint(DateTime.Now.ToString("h:mm:ss tt"), btcCurrentPrice);
            btcValueList.Add(pricepoint);
            btcPriceLabel.Text = btcCurrentPrice.ToString("C");
        }

        private async void updateETHPriceAsync()
        {
            decimal ethCurrentPrice = await gdax_Monitor.GetEtheriumValueAsync();
            ethPriceLabel.Foreground = new SolidColorBrush(ColorPicker.valueToColor(ethPrevPrice, ethCurrentPrice));
            ethPrevPrice = ethCurrentPrice;
            PricePoint pricepoint = new PricePoint(DateTime.Now.ToString("h:mm:ss tt"), ethCurrentPrice);
            ethValueList.Add(pricepoint);
            ethPriceLabel.Text = ethCurrentPrice.ToString("C");
        }

        private void Timer_Tick(object sender, object e)
        {
            timeLabel.Text = DateTime.Now.ToString("h:mm:ss tt");
            updateBTCPrice();
            updateETHPriceAsync();
        }

        private void savePrices_Click(object sender, RoutedEventArgs e)
        {
            //TODO: Convert BTC and ETH list to csv files
            CryptoRecorder ethRecorder = new CryptoRecorder(ethValueList);
            ethRecorder.saveCurrency("ethValues.csv");
            CryptoRecorder btcRecorder = new CryptoRecorder(btcValueList);
            btcRecorder.saveCurrency("btcValues.csv");
        }
    }
}
