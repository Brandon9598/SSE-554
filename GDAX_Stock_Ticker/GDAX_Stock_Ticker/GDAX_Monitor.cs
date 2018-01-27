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
        private string GDAX_ETH_URL = "https://min-api.cryptocompare.com/data/price?fsym=ETH&tsyms=BTC,USD,EUR";
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

        public async Task<decimal> GetEtheriumValueAsync()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(GDAX_ETH_URL);

                string responseAsBodyText;
                if (response.IsSuccessStatusCode)
                {
                    responseAsBodyText = await response.Content.ReadAsStringAsync();
                    System.Diagnostics.Debug.WriteLine(responseAsBodyText);
                    return getETHValue(responseAsBodyText);
                }
                return 0;
            }
        }

        private decimal convertToUSD(string btcValue)
        {
            return USD_CONST / decimal.Parse(btcValue);
        }

        public static decimal getETHValue(string htmlString)
        {
            char delimeter1 = ':';
            char delimeter2 = ',';
            String[] initial_parse = htmlString.Split(delimeter1);
            string second_parse = initial_parse.GetValue(2).ToString();
            String[] final_parse = second_parse.Split(delimeter2);
            return Decimal.Parse(final_parse.GetValue(0).ToString());
        }
    }
}
