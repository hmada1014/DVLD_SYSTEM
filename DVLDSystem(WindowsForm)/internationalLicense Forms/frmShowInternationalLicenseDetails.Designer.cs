namespace DVLDSystem_WindowsForm_.internationalLicense_Forms
{
    partial class frmShowInternationalLicenseDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ucInternationalLicenseInfo1 = new DVLDSystem_WindowsForm_.User_Control.ucInternationalLicenseInfo();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Souvenir Lt BT", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(162, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(626, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Driver  International License Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.LicenseView_400;
            this.pictureBox1.Location = new System.Drawing.Point(376, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ucInternationalLicenseInfo1
            // 
            this.ucInternationalLicenseInfo1.ApplicationID = "[???]";
            this.ucInternationalLicenseInfo1.ContainerDriverLicense = "Driver License info";
            this.ucInternationalLicenseInfo1.DateOfBirth = "[???]";
            this.ucInternationalLicenseInfo1.DriverID = "[???]";
            this.ucInternationalLicenseInfo1.ExpirationDate = "[???]";
            this.ucInternationalLicenseInfo1.GenderPerson = "[???]";
            this.ucInternationalLicenseInfo1.ImagePerson = global::DVLDSystem_WindowsForm_.Properties.Resources.Male_512;
            this.ucInternationalLicenseInfo1.InternationalLicenseID = "[???]";
            this.ucInternationalLicenseInfo1.IsActive = "[???]";
            this.ucInternationalLicenseInfo1.IssueDate = "[???]";
            this.ucInternationalLicenseInfo1.LicenseID = "[???]";
            this.ucInternationalLicenseInfo1.Location = new System.Drawing.Point(10, 180);
            this.ucInternationalLicenseInfo1.Name = "ucInternationalLicenseInfo1";
            this.ucInternationalLicenseInfo1.NamePerson = "mohammed khaled qaid ahmed hassen";
            this.ucInternationalLicenseInfo1.NationalNo = "[???]";
            this.ucInternationalLicenseInfo1.Size = new System.Drawing.Size(929, 252);
            this.ucInternationalLicenseInfo1.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.BorderThickness = 1;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.SystemColors.Control;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClose.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.Location = new System.Drawing.Point(808, 438);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 38);
            this.btnClose.TabIndex = 41;
            this.btnClose.Text = "close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmShowInternationalLicenseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 483);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ucInternationalLicenseInfo1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowInternationalLicenseDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmShowInternationalLicenseDetails";
            this.Load += new System.EventHandler(this.frmShowInternationalLicenseDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private User_Control.ucInternationalLicenseInfo ucInternationalLicenseInfo1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}