namespace Covid19VaccineRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.IdTb = new System.Windows.Forms.TextBox();
            this.IdLbl = new System.Windows.Forms.Label();
            this.SurnameTb = new System.Windows.Forms.TextBox();
            this.SurnameLbl = new System.Windows.Forms.Label();
            this.FirstnameTb = new System.Windows.Forms.TextBox();
            this.FirstnameLbl = new System.Windows.Forms.Label();
            this.GenderLbl = new System.Windows.Forms.Label();
            this.ProvinceLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.GenderCb = new System.Windows.Forms.ComboBox();
            this.ProvinceCb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // IdTb
            // 
            this.IdTb.Location = new System.Drawing.Point(116, 9);
            this.IdTb.Name = "IdTb";
            this.IdTb.Size = new System.Drawing.Size(138, 22);
            this.IdTb.TabIndex = 3;
            // 
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.Location = new System.Drawing.Point(15, 12);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(21, 17);
            this.IdLbl.TabIndex = 2;
            this.IdLbl.Text = "ID";
            // 
            // SurnameTb
            // 
            this.SurnameTb.Location = new System.Drawing.Point(116, 37);
            this.SurnameTb.Name = "SurnameTb";
            this.SurnameTb.Size = new System.Drawing.Size(138, 22);
            this.SurnameTb.TabIndex = 5;
            // 
            // SurnameLbl
            // 
            this.SurnameLbl.AutoSize = true;
            this.SurnameLbl.Location = new System.Drawing.Point(15, 40);
            this.SurnameLbl.Name = "SurnameLbl";
            this.SurnameLbl.Size = new System.Drawing.Size(65, 17);
            this.SurnameLbl.TabIndex = 4;
            this.SurnameLbl.Text = "Surname";
            // 
            // FirstnameTb
            // 
            this.FirstnameTb.Location = new System.Drawing.Point(116, 65);
            this.FirstnameTb.Name = "FirstnameTb";
            this.FirstnameTb.Size = new System.Drawing.Size(138, 22);
            this.FirstnameTb.TabIndex = 7;
            // 
            // FirstnameLbl
            // 
            this.FirstnameLbl.AutoSize = true;
            this.FirstnameLbl.Location = new System.Drawing.Point(15, 68);
            this.FirstnameLbl.Name = "FirstnameLbl";
            this.FirstnameLbl.Size = new System.Drawing.Size(70, 17);
            this.FirstnameLbl.TabIndex = 6;
            this.FirstnameLbl.Text = "Firstname";
            // 
            // GenderLbl
            // 
            this.GenderLbl.AutoSize = true;
            this.GenderLbl.Location = new System.Drawing.Point(15, 99);
            this.GenderLbl.Name = "GenderLbl";
            this.GenderLbl.Size = new System.Drawing.Size(56, 17);
            this.GenderLbl.TabIndex = 8;
            this.GenderLbl.Text = "Gender";
            // 
            // ProvinceLbl
            // 
            this.ProvinceLbl.AutoSize = true;
            this.ProvinceLbl.Location = new System.Drawing.Point(15, 129);
            this.ProvinceLbl.Name = "ProvinceLbl";
            this.ProvinceLbl.Size = new System.Drawing.Size(63, 17);
            this.ProvinceLbl.TabIndex = 10;
            this.ProvinceLbl.Text = "Province";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 27);
            this.button1.TabIndex = 12;
            this.button1.Text = "Register\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GenderCb
            // 
            this.GenderCb.FormattingEnabled = true;
            this.GenderCb.Items.AddRange(new object[] {
            "Male ",
            "Female",
            "Other"});
            this.GenderCb.Location = new System.Drawing.Point(116, 96);
            this.GenderCb.Name = "GenderCb";
            this.GenderCb.Size = new System.Drawing.Size(138, 24);
            this.GenderCb.TabIndex = 13;
            // 
            // ProvinceCb
            // 
            this.ProvinceCb.FormattingEnabled = true;
            this.ProvinceCb.Items.AddRange(new object[] {
            "Gauteng",
            "Western Cape",
            "Eastern Cape",
            "Northern Cape",
            "FreeState",
            "Limpopo",
            "Kwazulu-Natal",
            "Mpumalanga",
            "North West"});
            this.ProvinceCb.Location = new System.Drawing.Point(116, 126);
            this.ProvinceCb.Name = "ProvinceCb";
            this.ProvinceCb.Size = new System.Drawing.Size(138, 24);
            this.ProvinceCb.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 177);
            this.Controls.Add(this.ProvinceCb);
            this.Controls.Add(this.GenderCb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProvinceLbl);
            this.Controls.Add(this.GenderLbl);
            this.Controls.Add(this.FirstnameTb);
            this.Controls.Add(this.FirstnameLbl);
            this.Controls.Add(this.SurnameTb);
            this.Controls.Add(this.SurnameLbl);
            this.Controls.Add(this.IdTb);
            this.Controls.Add(this.IdLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Vaccine Registration Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IdTb;
        private System.Windows.Forms.Label IdLbl;
        private System.Windows.Forms.TextBox SurnameTb;
        private System.Windows.Forms.Label SurnameLbl;
        private System.Windows.Forms.TextBox FirstnameTb;
        private System.Windows.Forms.Label FirstnameLbl;
        private System.Windows.Forms.Label GenderLbl;
        private System.Windows.Forms.Label ProvinceLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox GenderCb;
        private System.Windows.Forms.ComboBox ProvinceCb;
    }
}

