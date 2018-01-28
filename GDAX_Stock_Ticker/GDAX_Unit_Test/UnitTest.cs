using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GDAX_Stock_Ticker;
using System.Collections.Generic;
using Windows.UI;

namespace GDAX_Unit_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCreateRecorder()
        {
            PricePoint p1 = new PricePoint("12:26:29 PM", 11648.3099397218M);
            PricePoint p2 = new PricePoint("12:26:30 PM", 11650.1100545121M);
            PricePoint p3 = new PricePoint("12:26:31 PM", 11650.1100545121M);
            List<PricePoint> pricePoints = new List<PricePoint>();
            pricePoints.Add(p1);
            pricePoints.Add(p2);
            pricePoints.Add(p3);
            CryptoRecorder cr = new CryptoRecorder(pricePoints);

            string csvOutput = cr.CreateCSV(pricePoints);

            string expectedOutput = "12:26:29 PM,11648.3099397218\n" +
                                    "12:26:30 PM,11650.1100545121\n" +
                                    "12:26:31 PM,11650.1100545121\n";
            Assert.AreEqual(expectedOutput, csvOutput);
        }

        [TestMethod]
        public void TestGetETHValue()
        {
            string mochHTMLString = "{\"BTC\":0.1041,\"USD\":1217.75,\"EUR\":974.97}";
            GDAX_Monitor gm = new GDAX_Monitor();

            decimal expectedValue = 1217.75M;
            decimal actualValue = gm.getETHValue(mochHTMLString);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void TestConvertToUSD()
        {
            int USD_CONST = 10000;
            string testHTML = "0.85119133";

            GDAX_Monitor gm = new GDAX_Monitor();

            decimal expectedValue = 11748.239963863353730353432994M;
            decimal actualValue = gm.convertToUSD(testHTML);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void TestValueToColor()
        {
            decimal highValue = 10.0M;
            decimal lowValue = 2M;
            decimal middleVal = 5M;

            Color expectedColor;

            // Price increase
            expectedColor = Colors.Green;
            Assert.AreEqual(expectedColor, ColorPicker.valueToColor(lowValue, highValue));

            // Price same
            expectedColor = Colors.Black;
            Assert.AreEqual(expectedColor, ColorPicker.valueToColor(middleVal, middleVal));

            // Price decrease
            expectedColor = Colors.Red;
            Assert.AreEqual(expectedColor, ColorPicker.valueToColor(highValue, lowValue));
        }
    }
}
