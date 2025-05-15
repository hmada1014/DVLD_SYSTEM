namespace DVLDSystem_WindowsForm_.RenewLicense_Forms
{
    partial class frmRenewLicense
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
            this.lklShowNewLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.lklLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.btnRenew = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.ucFindLocalLicense1 = new DVLDSystem_WindowsForm_.User_Control.ucFindLocalLicense();
            this.ucApplicationNewLicenseInfo1 = new DVLDSystem_WindowsForm_.User_Control.ucApplicationNewLicenseInfo();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Souvenir Lt BT", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(231, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 42);
            this.label1.TabIndex = 52;
            this.label1.Text = "Renew License Application";
            // 
            // lklShowNewLicenseInfo
            // 
            this.lklShowNewLicenseInfo.AutoSize = true;
            this.lklShowNewLicenseInfo.Enabled = false;
            this.lklShowNewLicenseInfo.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lklShowNewLicenseInfo.Location = new System.Drawing.Point(298, 770);
            this.lklShowNewLicenseInfo.Name = "lklShowNewLicenseInfo";
            this.lklShowNewLicenseInfo.Size = new System.Drawing.Size(223, 24);
            this.lklShowNewLicenseInfo.TabIndex = 57;
            this.lklShowNewLicenseInfo.TabStop = true;
            this.lklShowNewLicenseInfo.Text = "Show New Licenses info";
            this.lklShowNewLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklShowNewLicenseInfo_LinkClicked);
            // 
            // lklLicenseHistory
            // 
            this.lklLicenseHistory.AutoSize = true;
            this.lklLicenseHistory.Enabled = false;
            this.lklLicenseHistory.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lklLicenseHistory.Location = new System.Drawing.Point(52, 770);
            this.lklLicenseHistory.Name = "lklLicenseHistory";
            this.lklLicenseHistory.Size = new System.Drawing.Size(208, 24);
            this.lklLicenseHistory.TabIndex = 56;
            this.lklLicenseHistory.TabStop = true;
            this.lklLicenseHistory.Text = "Show Licenses History";
            this.lklLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklLicenseHistory_LinkClicked);
            // 
            // btnRenew
            // 
            this.btnRenew.BackColor = System.Drawing.SystemColors.Control;
            this.btnRenew.BorderThickness = 1;
            this.btnRenew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRenew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRenew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRenew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRenew.Enabled = false;
            this.btnRenew.FillColor = System.Drawing.SystemColors.Control;
            this.btnRenew.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnRenew.ForeColor = System.Drawing.Color.Black;
            this.btnRenew.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.IssueDrivingLicense_32;
            this.btnRenew.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRenew.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRenew.Location = new System.Drawing.Point(802, 761);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(128, 38);
            this.btnRenew.TabIndex = 54;
            this.btnRenew.Text = "  Renew";
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
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
            this.btnClose.Location = new System.Drawing.Point(662, 761);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 38);
            this.btnClose.TabIndex = 55;
            this.btnClose.Text = " Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ucFindLocalLicense1
            // 
            this.ucFindLocalLicense1.Location = new System.Drawing.Point(12, 33);
            this.ucFindLocalLicense1.Name = "ucFindLocalLicense1";
            this.ucFindLocalLicense1.Size = new System.Drawing.Size(908, 429);
            this.ucFindLocalLicense1.TabIndex = 53;
            this.ucFindLocalLicense1.onLicenseSelected += new System.Action<DVLDSystem_BusinessLayer_.clsLicense>(this.ucFindLocalLicense1_onLicenseSelected);
            // 
            // ucApplicationNewLicenseInfo1
            // 
            this.ucApplicationNewLicenseInfo1.ApplicationDate = "[???]";
            this.ucApplicationNewLicenseInfo1.ApplicationFees = "[???]";
            this.ucApplicationNewLicenseInfo1.CreatedBy = "[???]";
            this.ucApplicationNewLicenseInfo1.ExpireDate = "[???]";
            this.ucApplicationNewLicenseInfo1.IssueDate = "[???]";
            this.ucApplicationNewLicenseInfo1.LicenseFees = "[???]";
            this.ucApplicationNewLicenseInfo1.Location = new System.Drawing.Point(22, 463);
            this.ucApplicationNewLicenseInfo1.Name = "ucApplicationNewLicenseInfo1";
            this.ucApplicationNewLicenseInfo1.Notes = "";
            this.ucApplicationNewLicenseInfo1.OldLicenseID = "[???]";
            this.ucApplicationNewLicenseInfo1.RenewedLicenseID = "[???]";
            this.ucApplicationNewLicenseInfo1.RenewLocalApplicationID = "[???]";
            this.ucApplicationNewLicenseInfo1.Size = new System.Drawing.Size(904, 280);
            this.ucApplicationNewLicenseInfo1.TabIndex = 58;
            this.ucApplicationNewLicenseInfo1.TotalFees = "Total Fees:";
            // 
            // frmRenewLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 811);
            this.Controls.Add(this.ucApplicationNewLicenseInfo1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lklShowNewLicenseInfo);
            this.Controls.Add(this.lklLicenseHistory);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ucFindLocalLicense1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRenewLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRenewLicense";
            this.Load += new System.EventHandler(this.frmRenewLicense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lklShowNewLicenseInfo;
        private System.Windows.Forms.LinkLabel lklLicenseHistory;
        private Guna.UI2.WinForms.Guna2Button btnRenew;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private User_Control.ucFindLocalLicense ucFindLocalLicense1;
        private User_Control.ucApplicationNewLicenseInfo ucApplicationNewLicenseInfo1;
    }
}