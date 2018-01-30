using System;
using System.Windows.Forms;

namespace Project1
{
    public partial class SubMaker : Form
    {
        private string SubSizeChoice = string.Empty;
        private string MeatChoice = string.Empty;
        private string CheeseChoice = string.Empty;

        public SubMaker()
        {
            InitializeComponent();

            SubStringSetter();
        }

        private void SubMaker_Load(object sender, EventArgs e)
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
                + "Cheese : " + CheeseChoice + Environment.NewLine;
        }

        private void AddAnotherSub()
        {

        }

        private void MakeBoxesEnabled()
        {
            MeatsBox.Enabled = true;
            CheeseBox.Enabled = true;
            VeggieBox.Enabled = true;
            SaucesSeasonBox.Enabled = true;
            ExtrasBox.Enabled = true;
        }

        private void CheckIfAnySubSizeSelected()
        {
            if( KidSizeRadio.Checked == false 
                && SixInRadio.Checked == false
                && EightInRadio.Checked == false
                && TwelveInRadio.Checked == false)
            {
                MeatsBox.Enabled = false;
                CheeseBox.Enabled = false;
                VeggieBox.Enabled = false;
                SaucesSeasonBox.Enabled = false;
                ExtrasBox.Enabled = false;
            }
                    
        }

        private void KidSizeRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (KidSizeRadio.Checked == true)
            {
                SixInRadio.Checked = false;
                EightInRadio.Checked = false;
                TwelveInRadio.Checked = false;
                SubSizeChoice = "3 in.";
                SubStringSetter();
                MakeBoxesEnabled();
            }
            else
                CheckIfAnySubSizeSelected();
        }

        private void SixInRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (SixInRadio.Checked == true)
            {
                KidSizeRadio.Checked = false;
                EightInRadio.Checked = false;
                TwelveInRadio.Checked = false;
                SubSizeChoice = "6 in.";
                SubStringSetter();
                MakeBoxesEnabled();
            }
            else
                CheckIfAnySubSizeSelected();
        }

        private void EightInRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (EightInRadio.Checked == true)
            {
                KidSizeRadio.Checked = false;
                SixInRadio.Checked = false;
                TwelveInRadio.Checked = false;
                SubSizeChoice = "8 in.";
                SubStringSetter();
                MakeBoxesEnabled();
            }
            else
                CheckIfAnySubSizeSelected();

        }

        private void TwelveInRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (TwelveInRadio.Checked == true)
            {
                SixInRadio.Checked = false;
                EightInRadio.Checked = false;
                KidSizeRadio.Checked = false;
                SubSizeChoice = "12 in.";
                SubStringSetter();
                MakeBoxesEnabled();
            }
            else
                CheckIfAnySubSizeSelected();
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
            
        }
    }
}
