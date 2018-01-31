using System.Windows.Forms;

namespace Project1
{
    partial class SubMaker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SubSizeBox = new System.Windows.Forms.GroupBox();
            this.TwelveInRadio = new System.Windows.Forms.RadioButton();
            this.EightInRadio = new System.Windows.Forms.RadioButton();
            this.SixInRadio = new System.Windows.Forms.RadioButton();
            this.KidSizeRadio = new System.Windows.Forms.RadioButton();
            this.MeatsBox = new System.Windows.Forms.GroupBox();
            this.RoastedChickenRadio = new System.Windows.Forms.RadioButton();
            this.TurkeyRadio = new System.Windows.Forms.RadioButton();
            this.RoastBeefRadio = new System.Windows.Forms.RadioButton();
            this.HamRadio = new System.Windows.Forms.RadioButton();
            this.ExtrasBox = new System.Windows.Forms.GroupBox();
            this.ExtrasListBox = new System.Windows.Forms.CheckedListBox();
            this.CheeseBox = new System.Windows.Forms.GroupBox();
            this.AmericanRadio = new System.Windows.Forms.RadioButton();
            this.SwissRadio = new System.Windows.Forms.RadioButton();
            this.CheddarRadio = new System.Windows.Forms.RadioButton();
            this.PepperJackRadio = new System.Windows.Forms.RadioButton();
            this.ProvoRadio = new System.Windows.Forms.RadioButton();
            this.SubMakerDisplay = new System.Windows.Forms.TextBox();
            this.SaucesSeasonBox = new System.Windows.Forms.GroupBox();
            this.SuacesSeasonsList = new System.Windows.Forms.CheckedListBox();
            this.VeggieBox = new System.Windows.Forms.GroupBox();
            this.VeggiesList = new System.Windows.Forms.CheckedListBox();
            this.MakeYourOwnSub = new System.Windows.Forms.GroupBox();
            this.YourOrderBox = new System.Windows.Forms.GroupBox();
            this.SubSizeBox.SuspendLayout();
            this.MeatsBox.SuspendLayout();
            this.ExtrasBox.SuspendLayout();
            this.CheeseBox.SuspendLayout();
            this.SaucesSeasonBox.SuspendLayout();
            this.VeggieBox.SuspendLayout();
            this.YourOrderBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubSizeBox
            // 
            this.SubSizeBox.Controls.Add(this.TwelveInRadio);
            this.SubSizeBox.Controls.Add(this.EightInRadio);
            this.SubSizeBox.Controls.Add(this.SixInRadio);
            this.SubSizeBox.Controls.Add(this.KidSizeRadio);
            this.SubSizeBox.Location = new System.Drawing.Point(36, 45);
            this.SubSizeBox.Name = "SubSizeBox";
            this.SubSizeBox.Size = new System.Drawing.Size(210, 225);
            this.SubSizeBox.TabIndex = 0;
            this.SubSizeBox.TabStop = false;
            this.SubSizeBox.Text = "Sub Size";
            // 
            // TwelveInRadio
            // 
            this.TwelveInRadio.AutoSize = true;
            this.TwelveInRadio.Location = new System.Drawing.Point(9, 176);
            this.TwelveInRadio.Name = "TwelveInRadio";
            this.TwelveInRadio.Size = new System.Drawing.Size(169, 29);
            this.TwelveInRadio.TabIndex = 3;
            this.TwelveInRadio.TabStop = true;
            this.TwelveInRadio.Text = "12 in. Sub  - $9";
            this.TwelveInRadio.UseVisualStyleBackColor = true;
            this.TwelveInRadio.CheckedChanged += new System.EventHandler(this.TwelveInRadio_CheckedChanged);
            // 
            // EightInRadio
            // 
            this.EightInRadio.AutoSize = true;
            this.EightInRadio.Location = new System.Drawing.Point(9, 129);
            this.EightInRadio.Name = "EightInRadio";
            this.EightInRadio.Size = new System.Drawing.Size(168, 29);
            this.EightInRadio.TabIndex = 2;
            this.EightInRadio.TabStop = true;
            this.EightInRadio.Text = "8 in. Sub    - $7";
            this.EightInRadio.UseVisualStyleBackColor = true;
            this.EightInRadio.CheckedChanged += new System.EventHandler(this.EightInRadio_CheckedChanged);
            // 
            // SixInRadio
            // 
            this.SixInRadio.AutoSize = true;
            this.SixInRadio.Location = new System.Drawing.Point(9, 85);
            this.SixInRadio.Name = "SixInRadio";
            this.SixInRadio.Size = new System.Drawing.Size(168, 29);
            this.SixInRadio.TabIndex = 1;
            this.SixInRadio.TabStop = true;
            this.SixInRadio.Text = "6 in. Sub    - $5";
            this.SixInRadio.UseVisualStyleBackColor = true;
            this.SixInRadio.CheckedChanged += new System.EventHandler(this.SixInRadio_CheckedChanged);
            // 
            // KidSizeRadio
            // 
            this.KidSizeRadio.AutoSize = true;
            this.KidSizeRadio.Location = new System.Drawing.Point(9, 40);
            this.KidSizeRadio.Name = "KidSizeRadio";
            this.KidSizeRadio.Size = new System.Drawing.Size(171, 29);
            this.KidSizeRadio.TabIndex = 0;
            this.KidSizeRadio.TabStop = true;
            this.KidSizeRadio.Text = "3 in. Kids    - $2";
            this.KidSizeRadio.UseVisualStyleBackColor = true;
            this.KidSizeRadio.CheckedChanged += new System.EventHandler(this.KidSizeRadio_CheckedChanged);
            // 
            // MeatsBox
            // 
            this.MeatsBox.Controls.Add(this.RoastedChickenRadio);
            this.MeatsBox.Controls.Add(this.TurkeyRadio);
            this.MeatsBox.Controls.Add(this.RoastBeefRadio);
            this.MeatsBox.Controls.Add(this.HamRadio);
            this.MeatsBox.Enabled = false;
            this.MeatsBox.Location = new System.Drawing.Point(252, 45);
            this.MeatsBox.Name = "MeatsBox";
            this.MeatsBox.Size = new System.Drawing.Size(210, 225);
            this.MeatsBox.TabIndex = 2;
            this.MeatsBox.TabStop = false;
            this.MeatsBox.Text = "Meats";
            // 
            // RoastedChickenRadio
            // 
            this.RoastedChickenRadio.AutoSize = true;
            this.RoastedChickenRadio.Location = new System.Drawing.Point(16, 176);
            this.RoastedChickenRadio.Name = "RoastedChickenRadio";
            this.RoastedChickenRadio.Size = new System.Drawing.Size(186, 29);
            this.RoastedChickenRadio.TabIndex = 3;
            this.RoastedChickenRadio.TabStop = true;
            this.RoastedChickenRadio.Text = "Roasted Chicken";
            this.RoastedChickenRadio.UseVisualStyleBackColor = true;
            this.RoastedChickenRadio.CheckedChanged += new System.EventHandler(this.RoastedChickenRadio_CheckedChanged);
            // 
            // TurkeyRadio
            // 
            this.TurkeyRadio.AutoSize = true;
            this.TurkeyRadio.Location = new System.Drawing.Point(16, 129);
            this.TurkeyRadio.Name = "TurkeyRadio";
            this.TurkeyRadio.Size = new System.Drawing.Size(98, 29);
            this.TurkeyRadio.TabIndex = 2;
            this.TurkeyRadio.TabStop = true;
            this.TurkeyRadio.Text = "Turkey";
            this.TurkeyRadio.UseVisualStyleBackColor = true;
            this.TurkeyRadio.CheckedChanged += new System.EventHandler(this.TurkeyRadio_CheckedChanged);
            // 
            // RoastBeefRadio
            // 
            this.RoastBeefRadio.AutoSize = true;
            this.RoastBeefRadio.Location = new System.Drawing.Point(16, 85);
            this.RoastBeefRadio.Name = "RoastBeefRadio";
            this.RoastBeefRadio.Size = new System.Drawing.Size(132, 29);
            this.RoastBeefRadio.TabIndex = 1;
            this.RoastBeefRadio.TabStop = true;
            this.RoastBeefRadio.Text = "Roast Beef";
            this.RoastBeefRadio.UseVisualStyleBackColor = true;
            this.RoastBeefRadio.CheckedChanged += new System.EventHandler(this.RoastBeefRadio_CheckedChanged);
            // 
            // HamRadio
            // 
            this.HamRadio.AutoSize = true;
            this.HamRadio.Location = new System.Drawing.Point(16, 40);
            this.HamRadio.Name = "HamRadio";
            this.HamRadio.Size = new System.Drawing.Size(78, 29);
            this.HamRadio.TabIndex = 0;
            this.HamRadio.TabStop = true;
            this.HamRadio.Text = "Ham";
            this.HamRadio.UseVisualStyleBackColor = true;
            this.HamRadio.CheckedChanged += new System.EventHandler(this.HamRadio_CheckedChanged);
            // 
            // ExtrasBox
            // 
            this.ExtrasBox.Controls.Add(this.ExtrasListBox);
            this.ExtrasBox.Enabled = false;
            this.ExtrasBox.Location = new System.Drawing.Point(468, 288);
            this.ExtrasBox.Name = "ExtrasBox";
            this.ExtrasBox.Size = new System.Drawing.Size(335, 256);
            this.ExtrasBox.TabIndex = 3;
            this.ExtrasBox.TabStop = false;
            this.ExtrasBox.Text = "Extras";
            // 
            // ExtrasListBox
            // 
            this.ExtrasListBox.BackColor = System.Drawing.SystemColors.Control;
            this.ExtrasListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExtrasListBox.FormattingEnabled = true;
            this.ExtrasListBox.Items.AddRange(new object[] {
            "Extra Ham (+ $1.50)",
            "Extra Roast Beef (+ $1.50)",
            "Extra Turkey (+ $1.50)",
            "Extra Roasted Chicken (+ $1.50)",
            "Extra Cheese (+ $0.75)",
            "Bacon (+ $0.75)",
            "Avacado Spread (+ $0.75)"});
            this.ExtrasListBox.Location = new System.Drawing.Point(6, 37);
            this.ExtrasListBox.Name = "ExtrasListBox";
            this.ExtrasListBox.Size = new System.Drawing.Size(323, 216);
            this.ExtrasListBox.TabIndex = 4;
            this.ExtrasListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ExtrasListBox_ItemCheck);
            // 
            // CheeseBox
            // 
            this.CheeseBox.Controls.Add(this.AmericanRadio);
            this.CheeseBox.Controls.Add(this.SwissRadio);
            this.CheeseBox.Controls.Add(this.CheddarRadio);
            this.CheeseBox.Controls.Add(this.PepperJackRadio);
            this.CheeseBox.Controls.Add(this.ProvoRadio);
            this.CheeseBox.Enabled = false;
            this.CheeseBox.Location = new System.Drawing.Point(468, 45);
            this.CheeseBox.Name = "CheeseBox";
            this.CheeseBox.Size = new System.Drawing.Size(210, 225);
            this.CheeseBox.TabIndex = 4;
            this.CheeseBox.TabStop = false;
            this.CheeseBox.Text = "Cheese";
            // 
            // AmericanRadio
            // 
            this.AmericanRadio.AutoSize = true;
            this.AmericanRadio.Location = new System.Drawing.Point(15, 180);
            this.AmericanRadio.Name = "AmericanRadio";
            this.AmericanRadio.Size = new System.Drawing.Size(120, 29);
            this.AmericanRadio.TabIndex = 5;
            this.AmericanRadio.TabStop = true;
            this.AmericanRadio.Text = "American";
            this.AmericanRadio.UseVisualStyleBackColor = true;
            this.AmericanRadio.CheckedChanged += new System.EventHandler(this.AmericanRadio_CheckedChanged);
            // 
            // SwissRadio
            // 
            this.SwissRadio.AutoSize = true;
            this.SwissRadio.Location = new System.Drawing.Point(15, 145);
            this.SwissRadio.Name = "SwissRadio";
            this.SwissRadio.Size = new System.Drawing.Size(89, 29);
            this.SwissRadio.TabIndex = 3;
            this.SwissRadio.TabStop = true;
            this.SwissRadio.Text = "Swiss";
            this.SwissRadio.UseVisualStyleBackColor = true;
            this.SwissRadio.CheckedChanged += new System.EventHandler(this.SwissRadio_CheckedChanged);
            // 
            // CheddarRadio
            // 
            this.CheddarRadio.AutoSize = true;
            this.CheddarRadio.Location = new System.Drawing.Point(15, 110);
            this.CheddarRadio.Name = "CheddarRadio";
            this.CheddarRadio.Size = new System.Drawing.Size(113, 29);
            this.CheddarRadio.TabIndex = 2;
            this.CheddarRadio.TabStop = true;
            this.CheddarRadio.Text = "Cheddar";
            this.CheddarRadio.UseVisualStyleBackColor = true;
            this.CheddarRadio.CheckedChanged += new System.EventHandler(this.CheddarRadio_CheckedChanged);
            // 
            // PepperJackRadio
            // 
            this.PepperJackRadio.AutoSize = true;
            this.PepperJackRadio.Location = new System.Drawing.Point(15, 75);
            this.PepperJackRadio.Name = "PepperJackRadio";
            this.PepperJackRadio.Size = new System.Drawing.Size(147, 29);
            this.PepperJackRadio.TabIndex = 1;
            this.PepperJackRadio.TabStop = true;
            this.PepperJackRadio.Text = "Pepper Jack";
            this.PepperJackRadio.UseVisualStyleBackColor = true;
            this.PepperJackRadio.CheckedChanged += new System.EventHandler(this.PepperJackRadio_CheckedChanged);
            // 
            // ProvoRadio
            // 
            this.ProvoRadio.AutoSize = true;
            this.ProvoRadio.Location = new System.Drawing.Point(15, 40);
            this.ProvoRadio.Name = "ProvoRadio";
            this.ProvoRadio.Size = new System.Drawing.Size(125, 29);
            this.ProvoRadio.TabIndex = 0;
            this.ProvoRadio.TabStop = true;
            this.ProvoRadio.Text = "Provolone";
            this.ProvoRadio.UseVisualStyleBackColor = true;
            this.ProvoRadio.CheckedChanged += new System.EventHandler(this.ProvoRadio_CheckedChanged);
            // 
            // SubMakerDisplay
            // 
            this.SubMakerDisplay.Location = new System.Drawing.Point(6, 42);
            this.SubMakerDisplay.Multiline = true;
            this.SubMakerDisplay.Name = "SubMakerDisplay";
            this.SubMakerDisplay.ReadOnly = true;
            this.SubMakerDisplay.Size = new System.Drawing.Size(411, 490);
            this.SubMakerDisplay.TabIndex = 5;
            this.SubMakerDisplay.Text = "\r\n";
            // 
            // SaucesSeasonBox
            // 
            this.SaucesSeasonBox.Controls.Add(this.SuacesSeasonsList);
            this.SaucesSeasonBox.Enabled = false;
            this.SaucesSeasonBox.Location = new System.Drawing.Point(252, 288);
            this.SaucesSeasonBox.Name = "SaucesSeasonBox";
            this.SaucesSeasonBox.Size = new System.Drawing.Size(210, 256);
            this.SaucesSeasonBox.TabIndex = 6;
            this.SaucesSeasonBox.TabStop = false;
            this.SaucesSeasonBox.Text = "Sauces/Seasonings";
            // 
            // SuacesSeasonsList
            // 
            this.SuacesSeasonsList.BackColor = System.Drawing.SystemColors.Control;
            this.SuacesSeasonsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SuacesSeasonsList.FormattingEnabled = true;
            this.SuacesSeasonsList.Items.AddRange(new object[] {
            "Mayo",
            "Mustard",
            "Spicy Mustard",
            "Ranch",
            "Oil and Vinegar",
            "Salt",
            "Pepper"});
            this.SuacesSeasonsList.Location = new System.Drawing.Point(16, 37);
            this.SuacesSeasonsList.Name = "SuacesSeasonsList";
            this.SuacesSeasonsList.Size = new System.Drawing.Size(174, 216);
            this.SuacesSeasonsList.TabIndex = 4;
            this.SuacesSeasonsList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.SuacesSeasonsList_ItemCheck);
            // 
            // VeggieBox
            // 
            this.VeggieBox.Controls.Add(this.VeggiesList);
            this.VeggieBox.Enabled = false;
            this.VeggieBox.Location = new System.Drawing.Point(36, 288);
            this.VeggieBox.Name = "VeggieBox";
            this.VeggieBox.Size = new System.Drawing.Size(210, 256);
            this.VeggieBox.TabIndex = 7;
            this.VeggieBox.TabStop = false;
            this.VeggieBox.Text = "Veggies";
            // 
            // VeggiesList
            // 
            this.VeggiesList.BackColor = System.Drawing.SystemColors.Control;
            this.VeggiesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VeggiesList.CheckOnClick = true;
            this.VeggiesList.FormattingEnabled = true;
            this.VeggiesList.Items.AddRange(new object[] {
            "Lettuce",
            "Spinich",
            "Tomato",
            "Pickles",
            "Onions",
            "Bell Pepper",
            "Hot Peppers"});
            this.VeggiesList.Location = new System.Drawing.Point(16, 37);
            this.VeggiesList.Name = "VeggiesList";
            this.VeggiesList.Size = new System.Drawing.Size(174, 216);
            this.VeggiesList.TabIndex = 4;
            this.VeggiesList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.VeggiesList_ItemCheck);
            // 
            // MakeYourOwnSub
            // 
            this.MakeYourOwnSub.BackColor = System.Drawing.SystemColors.Control;
            this.MakeYourOwnSub.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MakeYourOwnSub.Location = new System.Drawing.Point(24, 12);
            this.MakeYourOwnSub.Name = "MakeYourOwnSub";
            this.MakeYourOwnSub.Size = new System.Drawing.Size(785, 538);
            this.MakeYourOwnSub.TabIndex = 8;
            this.MakeYourOwnSub.TabStop = false;
            this.MakeYourOwnSub.Text = "Make Your Own Sub";
            // 
            // YourOrderBox
            // 
            this.YourOrderBox.Controls.Add(this.SubMakerDisplay);
            this.YourOrderBox.Location = new System.Drawing.Point(815, 12);
            this.YourOrderBox.Name = "YourOrderBox";
            this.YourOrderBox.Size = new System.Drawing.Size(423, 538);
            this.YourOrderBox.TabIndex = 9;
            this.YourOrderBox.TabStop = false;
            this.YourOrderBox.Text = "Your Order";
            // 
            // SubMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1683, 562);
            this.Controls.Add(this.YourOrderBox);
            this.Controls.Add(this.VeggieBox);
            this.Controls.Add(this.SaucesSeasonBox);
            this.Controls.Add(this.CheeseBox);
            this.Controls.Add(this.ExtrasBox);
            this.Controls.Add(this.MeatsBox);
            this.Controls.Add(this.SubSizeBox);
            this.Controls.Add(this.MakeYourOwnSub);
            this.Name = "SubMaker";
            this.Text = "John Jimmy\'s Sub Maker";
            this.Load += new System.EventHandler(this.SubMaker_Load);
            this.SubSizeBox.ResumeLayout(false);
            this.SubSizeBox.PerformLayout();
            this.MeatsBox.ResumeLayout(false);
            this.MeatsBox.PerformLayout();
            this.ExtrasBox.ResumeLayout(false);
            this.CheeseBox.ResumeLayout(false);
            this.CheeseBox.PerformLayout();
            this.SaucesSeasonBox.ResumeLayout(false);
            this.VeggieBox.ResumeLayout(false);
            this.YourOrderBox.ResumeLayout(false);
            this.YourOrderBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SubSizeBox;
        private System.Windows.Forms.RadioButton TwelveInRadio;
        private System.Windows.Forms.RadioButton EightInRadio;
        private System.Windows.Forms.RadioButton SixInRadio;
        private System.Windows.Forms.RadioButton KidSizeRadio;
        private GroupBox MeatsBox;
        private RadioButton RoastedChickenRadio;
        private RadioButton TurkeyRadio;
        private RadioButton RoastBeefRadio;
        private RadioButton HamRadio;
        private GroupBox ExtrasBox;
        private CheckedListBox ExtrasListBox;
        private GroupBox CheeseBox;
        private RadioButton SwissRadio;
        private RadioButton CheddarRadio;
        private RadioButton PepperJackRadio;
        private RadioButton ProvoRadio;
        private RadioButton AmericanRadio;
        private TextBox SubMakerDisplay;
        private GroupBox SaucesSeasonBox;
        private CheckedListBox SuacesSeasonsList;
        private GroupBox VeggieBox;
        private CheckedListBox VeggiesList;
        private GroupBox MakeYourOwnSub;
        private GroupBox YourOrderBox;
    }
}