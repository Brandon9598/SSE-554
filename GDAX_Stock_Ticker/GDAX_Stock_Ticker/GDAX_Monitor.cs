using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GDAX_Stock_Ticker
{
    class GDAX_Monitor
    {
        private const int USD_CONST = 10000;
        private string GDAX_BITCOIN_URL = "http://blockchain.info/tobtc?currency=USD&value=" + USD_CONST.ToString();
        private string html = string.Empty;

        public decimal GetBitCoinValue()
        {
            using (var client = new HttpClient())
            {
                HttpWebRequest request =(HttpWebRequest) WebRequest.Create(GDAX_BITCOIN_URL);

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    html = reader.ReadToEnd();
                }
                return convertToUSD(html);
            }
        }

        private decimal convertToUSD(string btcValue)
        {
            return USD_CONST / decimal.Parse(btcValue);
        }
    }
}
