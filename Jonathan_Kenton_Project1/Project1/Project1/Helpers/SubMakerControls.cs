using Project1;
using System;

namespace Project1.Helpers
{
    public class SubMakerControls
    {
        SubMaker subMaker;

        public static bool CheckIfAnySubSizeSelected(bool KidSize, bool SixIn, bool EightIn, bool TwelveIn)
        {

            if (KidSize == true || SixIn == true || EightIn == true || TwelveIn == false)
                return true;
            else
                return false;
        }

        public bool SendSubSizes(bool KidSize, bool SixIn, bool EightIn, bool TwelveIn)
        {
            return CheckIfAnySubSizeSelected(KidSize, SixIn, EightIn, TwelveIn);
        }

        public string SubStringSetter()
        {
            return Environment.NewLine
                    + "Name : " + Form1.userInfo.UserName + Environment.NewLine
                    + "Street Address : " + Form1.userInfo.StreetAddress + Environment.NewLine
                    + "City/State/Zip : " + Form1.userInfo.CityStateZip + Environment.NewLine
                    + "-------------------------------------------------------------------" + Environment.NewLine
                    + "Sub 1:" + Environment.NewLine
                    + "-------------------------------------------------------------------" + Environment.NewLine
                    + "Sub Size : " + subMaker.SubSizeChoice + Environment.NewLine
                    + "Meat : " + subMaker.MeatChoice + Environment.NewLine
                    + "Cheese : " + subMaker.CheeseChoice + Environment.NewLine
                    + "Veggies : " + subMaker.VeggieChoice + Environment.NewLine
                    + "Sauces/Seasonings : " + subMaker.SauceSeasonChoice + Environment.NewLine
                    + "Extras : " + subMaker.ExtrasChoice + Environment.NewLine;
        }

    }
}
