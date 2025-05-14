namespace DVLDSystem_WindowsForm_.internationalLicenseID
{
    partial class frmNewInternationalLicense
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
            this.lklLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.lklShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.btnIssue = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.ucInternationalApplicationInfo1 = new DVLDSystem_WindowsForm_.User_Control.ucInternationalApplicationInfo();
            this.ucFindLocalLicense1 = new DVLDSystem_WindowsForm_.User_Control.ucFindLocalLicense();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Souvenir Lt BT", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(177, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(577, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "International License Application";
            // 
            // lklLicenseHistory
            // 
            this.lklLicenseHistory.AutoSize = true;
            this.lklLicenseHistory.Enabled = false;
            this.lklLicenseHistory.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lklLicenseHistory.Location = new System.Drawing.Point(34, 654);
            this.lklLicenseHistory.Name = "lklLicenseHistory";
            this.lklLicenseHistory.Size = new System.Drawing.Size(208, 24);
            this.lklLicenseHistory.TabIndex = 49;
            this.lklLicenseHistory.TabStop = true;
            this.lklLicenseHistory.Text = "Show Licenses History";
            this.lklLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklLicenseHistory_LinkClicked);
            // 
            // lklShowLicenseInfo
            // 
            this.lklShowLicenseInfo.AutoSize = true;
            this.lklShowLicenseInfo.Enabled = false;
            this.lklShowLicenseInfo.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lklShowLicenseInfo.Location = new System.Drawing.Point(280, 654);
            this.lklShowLicenseInfo.Name = "lklShowLicenseInfo";
            this.lklShowLicenseInfo.Size = new System.Drawing.Size(178, 24);
            this.lklShowLicenseInfo.TabIndex = 50;
            this.lklShowLicenseInfo.TabStop = true;
            this.lklShowLicenseInfo.Text = "Show Licenses info";
            this.lklShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklShowLicenseInfo_LinkClicked);
            // 
            // btnIssue
            // 
            this.btnIssue.BackColor = System.Drawing.SystemColors.Control;
            this.btnIssue.BorderThickness = 1;
            this.btnIssue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIssue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIssue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIssue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIssue.Enabled = false;
            this.btnIssue.FillColor = System.Drawing.SystemColors.Control;
            this.btnIssue.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnIssue.ForeColor = System.Drawing.Color.Black;
            this.btnIssue.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.International_32;
            this.btnIssue.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnIssue.ImageSize = new System.Drawing.Size(30, 30);
            this.btnIssue.Location = new System.Drawing.Point(784, 645);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(128, 38);
            this.btnIssue.TabIndex = 47;
            this.btnIssue.Text = "Issue";
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
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
            this.btnClose.Location = new System.Drawing.Point(644, 645);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 38);
            this.btnClose.TabIndex = 48;
            this.btnClose.Text = "close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ucInternationalApplicationInfo1
            // 
            this.ucInternationalApplicationInfo1.ApplicationDate = "[???]";
            this.ucInternationalApplicationInfo1.CreatedBy = "[???]";
            this.ucInternationalApplicationInfo1.ExpireDate = "[???]";
            this.ucInternationalApplicationInfo1.InrenationalApplicationID = "[???]";
            this.ucInternationalApplicationInfo1.InrenationalLicenseID = "[???]";
            this.ucInternationalApplicationInfo1.InternationalFees = "[???]";
            this.ucInternationalApplicationInfo1.IssueDate = "[???]";
            this.ucInternationalApplicationInfo1.LocalLicenseID = "[???]";
            this.ucInternationalApplicationInfo1.Location = new System.Drawing.Point(18, 470);
            this.ucInternationalApplicationInfo1.Name = "ucInternationalApplicationInfo1";
            this.ucInternationalApplicationInfo1.Size = new System.Drawing.Size(894, 169);
            this.ucInternationalApplicationInfo1.TabIndex = 51;
            // 
            // ucFindLocalLicense1
            // 
            this.ucFindLocalLicense1.Location = new System.Drawing.Point(18, 43);
            this.ucFindLocalLicense1.Name = "ucFindLocalLicense1";
            this.ucFindLocalLicense1.Size = new System.Drawing.Size(908, 429);
            this.ucFindLocalLicense1.TabIndex = 2;
            this.ucFindLocalLicense1.onLicenseSelected += new System.Action<DVLDSystem_BusinessLayer_.clsLicense>(this.ucFindLocalLicense1_onLicenseSelected);
            // 
            // frmNewInternationalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 691);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucInternationalApplicationInfo1);
            this.Controls.Add(this.lklShowLicenseInfo);
            this.Controls.Add(this.lklLicenseHistory);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ucFindLocalLicense1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNewInternationalLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNewInternationalLicense";
            this.Load += new System.EventHandler(this.frmNewInternationalLicense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private User_Control.ucFindLocalLicense ucFindLocalLicense1;
        private Guna.UI2.WinForms.Guna2Button btnIssue;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.LinkLabel lklLicenseHistory;
        private System.Windows.Forms.LinkLabel lklShowLicenseInfo;
        private User_Control.ucInternationalApplicationInfo ucInternationalApplicationInfo1;
    }
}