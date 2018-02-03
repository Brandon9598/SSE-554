using System;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        public static UserInfo userInfo;
        public static SubMaker subMaker;

        public Form1()
        {
            InitializeComponent();

            NameBox.Text = "Jonathan Kenton";
            StreetBox.Text = "213 Hathersage Dr.";
            CityStateZipBox.Text = "Kathleen, Ga. 31047"; 
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

            if(UserDeliveryInput(NameBox.Text, StreetBox.Text, CityStateZipBox.Text))
            {
                subMaker.Show();

                this.Hide();
            }
            
        }

        public bool UserDeliveryInput(string Name, string StreetName, string CityStateZip)
        {
            if (Name != string.Empty && StreetName != string.Empty && CityStateZipBox.Text != string.Empty)
            {
                userInfo = new UserInfo(NameBox.Text, StreetBox.Text, CityStateZipBox.Text);

                return true;
            }

            return false;
        }
    }
}
