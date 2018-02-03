using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Project1
{
    public partial class SubMaker : Form
    {
        private string SubSizeChoice = string.Empty;
        private string MeatChoice = string.Empty;
        private string CheeseChoice = string.Empty;
        private string VeggieChoice = string.Empty;
        private string SauceSeasonChoice = string.Empty;
        private string ExtrasChoice = string.Empty;

        public SubMaker()
        {
            InitializeComponent();

            SubStringSetter();
        }

        public void SubMaker_Load(object sender, EventArgs e)
        {
            SubMakerDisplay.Text += Environment.NewLine
                + "Name : " + Form1.userInfo.UserName + Environment.NewLine
                + "Street Address : " + Form1.userInfo.StreetAddress + Environment.NewLine
                + "City/State/Zip : " + Form1.userInfo.CityStateZip
                + "-------------------------------------------------------------------" + Environment.NewLine;
        }

        private void SubStringSetter()
        {
            SubMakerDisplay.Text = Environment.NewLine
                + "Name : " + Form1.userInfo.UserName + Environment.NewLine
                + "Street Address : " + Form1.userInfo.StreetAddress + Environment.NewLine
                + "City/State/Zip : " + Form1.userInfo.CityStateZip
                + "-------------------------------------------------------------------" + Environment.NewLine;

            SubMakerDisplay.Text += "Sub 1:" + Environment.NewLine
                + "-------------------------------------------------------------------" + Environment.NewLine
                + "Sub Size : " + SubSizeChoice + Environment.NewLine
                + "Meat : " + MeatChoice + Environment.NewLine
                + "Cheese : " + CheeseChoice + Environment.NewLine
                + "Veggies : " + VeggieChoice + Environment.NewLine
                + "Sauces/Seasonings : " + SauceSeasonChoice + Environment.NewLine
                + "Extras : " + ExtrasChoice + Environment.NewLine;
        }

        public void MakeBoxesEnabled()
        {
            MeatsBox.Enabled = true;
            CheeseBox.Enabled = true;
            VeggieBox.Enabled = true;
            SaucesSeasonBox.Enabled = true;
            ExtrasBox.Enabled = true;
        }

        public static bool CheckIfAnySubSizeSelected(bool KidSize, bool SixIn, bool EightIn, bool TwelveIn)
        {
            
            if(KidSize == true || SixIn == true || EightIn == true || TwelveIn == false)
                return true;
            else
                return false;
        }

        private void KidSizeRadio_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckIfAnySubSizeSelected(KidSizeRadio.Checked, SixInRadio.Checked, EightInRadio.Checked, TwelveInRadio.Checked))
            {
                MakeBoxesEnabled();

                if (KidSizeRadio.Checked == true)
                {
                    SixInRadio.Checked = false;
                    EightInRadio.Checked = false;
                    TwelveInRadio.Checked = false;

                    SubSizeChoice = "3 in.";
                    SubStringSetter();
                }
            }   
        }

        private void SixInRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckIfAnySubSizeSelected(KidSizeRadio.Checked, SixInRadio.Checked, EightInRadio.Checked, TwelveInRadio.Checked))
            {
                MakeBoxesEnabled();

                if (SixInRadio.Checked == true)
                {
                    KidSizeRadio.Checked = false;
                    EightInRadio.Checked = false;
                    TwelveInRadio.Checked = false;

                    SubSizeChoice = "6 in.";
                    SubStringSetter();
                }
            }
        }

        private void EightInRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckIfAnySubSizeSelected(KidSizeRadio.Checked, SixInRadio.Checked, EightInRadio.Checked, TwelveInRadio.Checked))
            {
                MakeBoxesEnabled();

                if (EightInRadio.Checked == true)
                {
                    KidSizeRadio.Checked = false;
                    SixInRadio.Checked = false;
                    TwelveInRadio.Checked = false;

                    SubSizeChoice = "8 in.";
                    SubStringSetter();
                }
            }
        }

        private void TwelveInRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckIfAnySubSizeSelected(KidSizeRadio.Checked, SixInRadio.Checked, EightInRadio.Checked, TwelveInRadio.Checked))
            {
                MakeBoxesEnabled();

                if (TwelveInRadio.Checked == true)
                {
                    SixInRadio.Checked = false;
                    EightInRadio.Checked = false;
                    KidSizeRadio.Checked = false;

                    SubSizeChoice = "12 in.";
                    SubStringSetter();
                }
            }
        }

        private void HamRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (HamRadio.Checked == true)
            {
                RoastBeefRadio.Checked = false;
                TurkeyRadio.Checked = false;
                RoastedChickenRadio.Checked = false;
                MeatChoice = HamRadio.Text;
                SubStringSetter();
            }
        }

        private void RoastBeefRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (RoastBeefRadio.Checked == true)
            {
                HamRadio.Checked = false;
                TurkeyRadio.Checked = false;
                RoastedChickenRadio.Checked = false;
                MeatChoice = RoastBeefRadio.Text;
                SubStringSetter();
            }
        }

        private void TurkeyRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (TurkeyRadio.Checked == true)
            {
                HamRadio.Checked = false;
                RoastBeefRadio.Checked = false;
                RoastedChickenRadio.Checked = false;
                MeatChoice = TurkeyRadio.Text;
                SubStringSetter();
            }
        }

        private void RoastedChickenRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (RoastedChickenRadio.Checked == true)
            {
                HamRadio.Checked = false;
                RoastBeefRadio.Checked = false;
                TurkeyRadio.Checked = false;
                MeatChoice = RoastedChickenRadio.Text;
                SubStringSetter();
            }
        }

        private void ProvoRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (ProvoRadio.Checked == true)
            {
                PepperJackRadio.Checked = false;
                CheddarRadio.Checked = false;
                SwissRadio.Checked = false;
                AmericanRadio.Checked = false;
                CheeseChoice = ProvoRadio.Text;
                SubStringSetter();
            }
        }

        private void PepperJackRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (PepperJackRadio.Checked == true)
            {
                ProvoRadio.Checked = false;
                CheddarRadio.Checked = false;
                SwissRadio.Checked = false;
                AmericanRadio.Checked = false;
                CheeseChoice = PepperJackRadio.Text;
                SubStringSetter();
            }
        }

        private void CheddarRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (CheddarRadio.Checked == true)
            {
                ProvoRadio.Checked = false;
                PepperJackRadio.Checked = false;
                SwissRadio.Checked = false;
                AmericanRadio.Checked = false;
                CheeseChoice = CheddarRadio.Text;
                SubStringSetter();
            }
        }

        private void SwissRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (SwissRadio.Checked == true)
            {
                ProvoRadio.Checked = false;
                PepperJackRadio.Checked = false;
                CheddarRadio.Checked = false;
                AmericanRadio.Checked = false;
                CheeseChoice = SwissRadio.Text;
                SubStringSetter();
            }
        }

        private void AmericanRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (AmericanRadio.Checked == true)
            {
                ProvoRadio.Checked = false;
                PepperJackRadio.Checked = false;
                CheddarRadio.Checked = false;
                SwissRadio.Checked = false;
                CheeseChoice = AmericanRadio.Text;
                SubStringSetter();
            }
        }
        
        private void VeggiesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            VeggieChoice = string.Empty;

            SubStringSetter();

            foreach (int indexChecked in VeggiesList.CheckedIndices)
            {
                switch (indexChecked)
                {
                    case 0:
                        VeggieChoice += "Lettuce, ";
                        Debug.WriteLine(0);
                        break;
                    case 1:
                        VeggieChoice += "Spinach, ";
                        Debug.WriteLine(1);
                        break;
                    case 2:
                        VeggieChoice += "Tomato, ";
                        Debug.WriteLine(2);
                        break;
                    case 3:
                        VeggieChoice += "Pickles, ";
                        Debug.WriteLine(3);
                        break;
                    case 4:
                        VeggieChoice += "Onions, ";
                        Debug.WriteLine(4);
                        break;
                    case 5:
                        VeggieChoice += "Bell Peppers, ";
                        Debug.WriteLine(5);
                        break;
                    case 6:
                        VeggieChoice += "Hot Peppers, ";
                        Debug.WriteLine(7);
                        break;
                    default:
                        break;
                }

                SubStringSetter();
            }
        }

        private void SuacesSeasonsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SauceSeasonChoice = string.Empty;

            SubStringSetter();

            foreach(int indexChecked in SuacesSeasonsList.CheckedIndices)
            {
                switch (indexChecked)
                {
                    case 0:
                        SauceSeasonChoice += "Mayo, ";
                        break;
                    case 1:
                        SauceSeasonChoice += "Mustard, ";
                        break;
                    case 2:
                        SauceSeasonChoice += "Spicy Mustard, ";
                        break;
                    case 3:
                        SauceSeasonChoice += "Ranch, ";
                        break;
                    case 4:
                        SauceSeasonChoice += "Oil and Vinegar, ";
                        break;
                    case 5:
                        SauceSeasonChoice += "Salt, ";
                        break;
                    case 6:
                        SauceSeasonChoice += "Pepper, ";
                        break;
                    default:
                        break;
                }

                SubStringSetter();
            }
        }

        private void ExtrasListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExtrasChoice = string.Empty;

            SubStringSetter();

            foreach(int indexChecked in ExtrasListBox.CheckedIndices)
            {
                switch (indexChecked)
                {
                    case 0:
                        ExtrasChoice += "Extra Ham(+ $1.50), ";
                        break;
                    case 1:
                        ExtrasChoice += "Extra Roast Beef(+ $1.50), ";
                        break;
                    case 2:
                        ExtrasChoice += "Extra Turkey(+ $1.50), ";
                        break;
                    case 3:
                        ExtrasChoice += "Extra Roasted Chicken(+ $1.50), ";
                        break;
                    case 4:
                        ExtrasChoice += "Extra Cheese(+ $0.75), ";
                        break;
                    case 5:
                        ExtrasChoice += "Bacon(+ $0.75), ";
                        break;
                    case 6:
                        ExtrasChoice += "Avacado Spread(+ $0.75), ";
                        break;
                    default:
                        break;
                }

                SubStringSetter();
            }
                
        }
    }
}