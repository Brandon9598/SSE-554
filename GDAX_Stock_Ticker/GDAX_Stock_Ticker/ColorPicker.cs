using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace GDAX_Stock_Ticker
{
    class ColorPicker
    {
        public static Color valueToColor(decimal prevVal, decimal currentVal)
        {
            if (currentVal > prevVal)
            {
                return Colors.Green;
            }
            else if (currentVal == prevVal)
            {
                return Colors.Black;
            }
            else
            {
                return Colors.Red;
            }
        }
    }
}
