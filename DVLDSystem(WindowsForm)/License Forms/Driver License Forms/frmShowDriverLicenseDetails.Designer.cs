namespace DVLDSystem_WindowsForm_.Driver_License_Forms
{
    partial class frmShowDriverLicenseDetails
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
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.ucDriverLicenseInfo1 = new DVLDSystem_WindowsForm_.User_Control.ucDriverLicenseInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Souvenir Lt BT", 37F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(236, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 62);
            this.label1.TabIndex = 2;
            this.label1.Text = "Driver License Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.LicenseView_400;
            this.pictureBox1.Location = new System.Drawing.Point(419, -13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
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
            this.btnClose.Location = new System.Drawing.Point(888, 522);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 38);
            this.btnClose.TabIndex = 42;
            this.btnClose.Text = "close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ucDriverLicenseInfo1
            // 
            this.ucDriverLicenseInfo1.ClassName = "???";
            this.ucDriverLicenseInfo1.ContainerDriverLicense = "License Info";
            this.ucDriverLicenseInfo1.DateOfBirth = "???";
            this.ucDriverLicenseInfo1.DriverID = "???";
            this.ucDriverLicenseInfo1.ExpirationDate = "???";
            this.ucDriverLicenseInfo1.GenderPerson = "???";
            this.ucDriverLicenseInfo1.ImagePerson = global::DVLDSystem_WindowsForm_.Properties.Resources.person_man;
            this.ucDriverLicenseInfo1.IsActive = "???";
            this.ucDriverLicenseInfo1.IsDetained = "???";
            this.ucDriverLicenseInfo1.IssueDate = "???";
            this.ucDriverLicenseInfo1.IssueReason = "???";
            this.ucDriverLicenseInfo1.LicenseID = "???";
            this.ucDriverLicenseInfo1.Location = new System.Drawing.Point(10, 182);
            this.ucDriverLicenseInfo1.Name = "ucDriverLicenseInfo1";
            this.ucDriverLicenseInfo1.NamePerson = "???";
            this.ucDriverLicenseInfo1.NationalNo = "???";
            this.ucDriverLicenseInfo1.Notes = "???";
            this.ucDriverLicenseInfo1.Size = new System.Drawing.Size(1016, 400);
            this.ucDriverLicenseInfo1.TabIndex = 4;
            // 
            // frmShowDriverLicenseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 569);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ucDriverLicenseInfo1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowDriverLicenseDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmDriverLicenseInfo";
            this.Load += new System.EventHandler(this.frmShowDriverLicenseDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private User_Control.ucDriverLicenseInfo ucDriverLicenseInfo1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}