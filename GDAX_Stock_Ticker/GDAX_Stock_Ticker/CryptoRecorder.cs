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
        public async void saveBTC()
        {
            Windows.Storage.StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            Windows.Storage.StorageFile btcFile = await storageFolder.CreateFileAsync("btcValues.csv",
                Windows.Storage.CreationCollisionOption.ReplaceExisting);
            btcFile = await storageFolder.GetFileAsync("btcValues.csv");
            await Windows.Storage.FileIO.WriteTextAsync(btcFile, "Swift as a shadow");
        }

        public async void convertTOCSV()
        {

        }
    }
}
