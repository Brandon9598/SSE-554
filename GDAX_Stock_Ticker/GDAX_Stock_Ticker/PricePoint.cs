using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDAX_Stock_Ticker
{
    struct PricePoint
    {
        public string time;
        public decimal price;

        public PricePoint(string time, decimal price)
        {
            this.time = time;
            this.price = price;
        }
    }
}
