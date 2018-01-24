using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDAX_Stock_Ticker
{
    class Clock
    {
        private Timer timer;

        public Clock(Timer timer)
        {
            this.timer = timer;
        }
        public void startClock()
        {
            timer.Elapsed += timer_EllapsedEvntHandler;
            timer.Start();
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        private void timer_EllapsedEvntHandler(Object source, ElapsedEventArgs e)
        {
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int second = DateTime.Now.Second;

            string time = "";
            
            // Pad Hours
            if(hour < 10)
            {
                time += "0" + hour;
            }
            else
            {
                time += hour;
            }
            time += ":";

            // Pad Minutes
            if(minute < 10)
            {
                time += "0" + minute;
            }
            else
            {
                time += minute;
            }
            time += ":";

            //Pad Seconds
            if (second < 10)
            {
                time += "0" + second;
            }
            else
            {
                time += second;
            }
            Console.WriteLine("OUTPUT");
            System.Diagnostics.Debug.WriteLine(time);
            Console.WriteLine(time);


        }
    }
}
