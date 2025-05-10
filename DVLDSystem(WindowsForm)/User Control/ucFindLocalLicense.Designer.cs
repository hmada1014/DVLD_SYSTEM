namespace DVLDSystem_WindowsForm_.User_Control
{
    partial class ucFindLocalLicense
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnIssue = new FontAwesome.Sharp.IconButton();
            this.txtLicenseID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ucDriverLicenseInfo1 = new DVLDSystem_WindowsForm_.User_Control.ucDriverLicenseInfo();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnIssue);
            this.gbFilter.Controls.Add(this.txtLicenseID);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gbFilter.Location = new System.Drawing.Point(8, 8);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(545, 85);
            this.gbFilter.TabIndex = 0;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // btnIssue
            // 
            this.btnIssue.BackgroundImage = global::DVLDSystem_WindowsForm_.Properties.Resources.License_View_32;
            this.btnIssue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIssue.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnIssue.IconColor = System.Drawing.Color.Black;
            this.btnIssue.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIssue.Location = new System.Drawing.Point(440, 26);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(47, 40);
            this.btnIssue.TabIndex = 3;
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // txtLicenseID
            // 
            this.txtLicenseID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtLicenseID.Location = new System.Drawing.Point(134, 34);
            this.txtLicenseID.Name = "txtLicenseID";
            this.txtLicenseID.Size = new System.Drawing.Size(283, 24);
            this.txtLicenseID.TabIndex = 1;
            this.txtLicenseID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLicenseID_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "LicenseID:";
            // 
            // ucDriverLicenseInfo1
            // 
            this.ucDriverLicenseInfo1.ClassName = "[???]";
            this.ucDriverLicenseInfo1.ContainerDriverLicense = "Driver License info";
            this.ucDriverLicenseInfo1.DateOfBirth = "[???]";
            this.ucDriverLicenseInfo1.DriverID = "[???]";
            this.ucDriverLicenseInfo1.ExpirationDate = "[???]";
            this.ucDriverLicenseInfo1.GenderPerson = "[???]";
            this.ucDriverLicenseInfo1.ImagePerson = null;
            this.ucDriverLicenseInfo1.IsActive = "[???]";
            this.ucDriverLicenseInfo1.IsDetained = "[???]";
            this.ucDriverLicenseInfo1.IssueDate = "[???]";
            this.ucDriverLicenseInfo1.IssueReason = "[???]";
            this.ucDriverLicenseInfo1.LicenseID = "[???]";
            this.ucDriverLicenseInfo1.Location = new System.Drawing.Point(8, 98);
            this.ucDriverLicenseInfo1.Name = "ucDriverLicenseInfo1";
            this.ucDriverLicenseInfo1.NamePerson = "[???]";
            this.ucDriverLicenseInfo1.NationalNo = "[???]";
            this.ucDriverLicenseInfo1.Notes = "[???]";
            this.ucDriverLicenseInfo1.Size = new System.Drawing.Size(916, 327);
            this.ucDriverLicenseInfo1.TabIndex = 1;
            // 
            // ucFindLocalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucDriverLicenseInfo1);
            this.Controls.Add(this.gbFilter);
            this.Name = "ucFindLocalLicense";
            this.Size = new System.Drawing.Size(927, 428);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLicenseID;
        private FontAwesome.Sharp.IconButton btnIssue;
        private ucDriverLicenseInfo ucDriverLicenseInfo1;
    }
}
