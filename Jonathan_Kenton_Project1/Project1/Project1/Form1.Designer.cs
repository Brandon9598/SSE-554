namespace Project1
{
    partial class Form1
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
            this.NameAddressGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CityStateZipBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StreetBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.NameAddressGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameAddressGroupBox
            // 
            this.NameAddressGroupBox.Controls.Add(this.label3);
            this.NameAddressGroupBox.Controls.Add(this.CityStateZipBox);
            this.NameAddressGroupBox.Controls.Add(this.label2);
            this.NameAddressGroupBox.Controls.Add(this.label1);
            this.NameAddressGroupBox.Controls.Add(this.StreetBox);
            this.NameAddressGroupBox.Controls.Add(this.NameBox);
            this.NameAddressGroupBox.Location = new System.Drawing.Point(40, 100);
            this.NameAddressGroupBox.Name = "NameAddressGroupBox";
            this.NameAddressGroupBox.Size = new System.Drawing.Size(500, 250);
            this.NameAddressGroupBox.TabIndex = 0;
            this.NameAddressGroupBox.TabStop = false;
            this.NameAddressGroupBox.Text = "Name and Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "City, State, Zip :";
            // 
            // CityStateZipBox
            // 
            this.CityStateZipBox.Location = new System.Drawing.Point(227, 205);
            this.CityStateZipBox.Name = "CityStateZipBox";
            this.CityStateZipBox.Size = new System.Drawing.Size(268, 29);
            this.CityStateZipBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Street Address :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name :";
            // 
            // StreetBox
            // 
            this.StreetBox.Location = new System.Drawing.Point(227, 135);
            this.StreetBox.Name = "StreetBox";
            this.StreetBox.Size = new System.Drawing.Size(268, 29);
            this.StreetBox.TabIndex = 1;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(227, 63);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(268, 29);
            this.NameBox.TabIndex = 0;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(250, 400);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(0);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(100, 40);
            this.SubmitButton.TabIndex = 6;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 536);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.NameAddressGroupBox);
            this.Name = "Form1";
            this.Text = "John Jimmy\'s Subs";
            this.NameAddressGroupBox.ResumeLayout(false);
            this.NameAddressGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox NameAddressGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StreetBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CityStateZipBox;
        private System.Windows.Forms.Button SubmitButton;
    }
}

