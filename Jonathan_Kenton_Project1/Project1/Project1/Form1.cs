using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        public static UserInfo userInfo;

        public Form1()
        {
            InitializeComponent();

            NameBox.Text = "Jonathan Kenton";
            StreetBox.Text = "213 Hathersage Dr.";
            CityStateZipBox.Text = "Kathleen, Ga. 31047"; 
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if(NameBox.Text != string.Empty && StreetBox.Text != string.Empty && CityStateZipBox.Text != string.Empty)
            {
                userInfo = new UserInfo(NameBox.Text, StreetBox.Text, CityStateZipBox.Text);
                SubMaker subMaker = new SubMaker();

                subMaker.Show();

                this.Hide();
            }
                
        }
    }
}
