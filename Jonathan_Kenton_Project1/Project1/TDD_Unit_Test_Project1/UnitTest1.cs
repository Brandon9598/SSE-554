using Project1;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TDD_Unit_Test_Project1
{
    [TestClass]
    public class UnitTest1
    {
        Form1 F = new Form1();

        [TestMethod]
        public void TestUserDeliveryInput()
        {
            string Name = "Jonathan Kenton";
            string StreetAddress = "123 Jonathan Kenton Blvd.";
            string CityStateZip = "Kathleen Ga 31047";
            bool GoodUserDeliveryInput;

            GoodUserDeliveryInput = F.UserDeliveryInput(Name, StreetAddress, CityStateZip);

            Assert.AreEqual(GoodUserDeliveryInput, true);
        }

        [TestMethod]
        public void TestUserHasChosenSubSize()
        {
            bool SubSizeSelected = false;

            bool KidSize = true, SixIn = true, EightIn = true, TwelveIn = true;

            if (SubMaker.CheckIfAnySubSizeSelected(KidSize, SixIn, EightIn, TwelveIn))
            {
                
            }
            else
            {
                
            }

            Assert.AreEqual(SubSizeSelected, true);
        }

    }
}
