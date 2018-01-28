using System;
using Windows.Storage.Pickers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDAX_Stock_Ticker
{
    class CryptoRecorder
    {
        private List<PricePoint> cryptoPrices;

        public CryptoRecorder(List<PricePoint> cryptoPrices)
        {
            this.cryptoPrices = cryptoPrices;
        }

        public async void saveCurrency(string filename)
        {
            Windows.Storage.StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            Windows.Storage.StorageFile btcFile = await storageFolder.CreateFileAsync(filename,
                Windows.Storage.CreationCollisionOption.ReplaceExisting);
            btcFile = await storageFolder.GetFileAsync(filename);
            string textToWrite = CreateCSV(cryptoPrices);
            await Windows.Storage.FileIO.WriteTextAsync(btcFile, textToWrite);
        }

        public string CreateCSV(List<PricePoint> timedPrices)
        {
            string csv = "";
            foreach (PricePoint pricePoint in timedPrices)
            {
                csv += pricePoint.time + "," + pricePoint.price + "\n";
            }
            return csv;
        }

        public List<PricePoint> CryptoPrices
        {
            get { return cryptoPrices; }
            set { cryptoPrices = value; }
        }
    }
}
