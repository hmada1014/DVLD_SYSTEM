namespace DVLDSystem_WindowsForm_.License_Forms.Replacement_Damaged_or_Lost_Forms
{
    partial class frmReplacementDamagedOrLostLicense
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
            this.gbReplacment = new System.Windows.Forms.GroupBox();
            this.rbtnLostLicense = new System.Windows.Forms.RadioButton();
            this.rbtnDamagedLicense = new System.Windows.Forms.RadioButton();
            this.lklShowNewLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.lklLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.ucApplicationReplacmentInfo1 = new DVLDSystem_WindowsForm_.User_Control.ucApplicationReplacmentInfo();
            this.ucFindLocalLicense1 = new DVLDSystem_WindowsForm_.User_Control.ucFindLocalLicense();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIssueReplacement = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.gbReplacment.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbReplacment
            // 
            this.gbReplacment.Controls.Add(this.rbtnLostLicense);
            this.gbReplacment.Controls.Add(this.rbtnDamagedLicense);
            this.gbReplacment.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gbReplacment.Location = new System.Drawing.Point(575, 58);
            this.gbReplacment.Name = "gbReplacment";
            this.gbReplacment.Size = new System.Drawing.Size(200, 78);
            this.gbReplacment.TabIndex = 1;
            this.gbReplacment.TabStop = false;
            this.gbReplacment.Text = "Replacment For";
            // 
            // rbtnLostLicense
            // 
            this.rbtnLostLicense.AutoSize = true;
            this.rbtnLostLicense.Location = new System.Drawing.Point(6, 50);
            this.rbtnLostLicense.Name = "rbtnLostLicense";
            this.rbtnLostLicense.Size = new System.Drawing.Size(110, 21);
            this.rbtnLostLicense.TabIndex = 1;
            this.rbtnLostLicense.TabStop = true;
            this.rbtnLostLicense.Text = "Lost License";
            this.rbtnLostLicense.UseVisualStyleBackColor = true;
            this.rbtnLostLicense.CheckedChanged += new System.EventHandler(this.rbtnReplacementStatus_CheckedChanged);
            // 
            // rbtnDamagedLicense
            // 
            this.rbtnDamagedLicense.AutoSize = true;
            this.rbtnDamagedLicense.Checked = true;
            this.rbtnDamagedLicense.Location = new System.Drawing.Point(6, 23);
            this.rbtnDamagedLicense.Name = "rbtnDamagedLicense";
            this.rbtnDamagedLicense.Size = new System.Drawing.Size(145, 21);
            this.rbtnDamagedLicense.TabIndex = 0;
            this.rbtnDamagedLicense.TabStop = true;
            this.rbtnDamagedLicense.Text = "Damaged License";
            this.rbtnDamagedLicense.UseVisualStyleBackColor = true;
            this.rbtnDamagedLicense.CheckedChanged += new System.EventHandler(this.rbtnReplacementStatus_CheckedChanged);
            // 
            // lklShowNewLicenseInfo
            // 
            this.lklShowNewLicenseInfo.AutoSize = true;
            this.lklShowNewLicenseInfo.Enabled = false;
            this.lklShowNewLicenseInfo.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lklShowNewLicenseInfo.Location = new System.Drawing.Point(244, 633);
            this.lklShowNewLicenseInfo.Name = "lklShowNewLicenseInfo";
            this.lklShowNewLicenseInfo.Size = new System.Drawing.Size(223, 24);
            this.lklShowNewLicenseInfo.TabIndex = 61;
            this.lklShowNewLicenseInfo.TabStop = true;
            this.lklShowNewLicenseInfo.Text = "Show New Licenses info";
            this.lklShowNewLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklShowNewLicenseInfo_LinkClicked);
            // 
            // lklLicenseHistory
            // 
            this.lklLicenseHistory.AutoSize = true;
            this.lklLicenseHistory.Enabled = false;
            this.lklLicenseHistory.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lklLicenseHistory.Location = new System.Drawing.Point(21, 633);
            this.lklLicenseHistory.Name = "lklLicenseHistory";
            this.lklLicenseHistory.Size = new System.Drawing.Size(208, 24);
            this.lklLicenseHistory.TabIndex = 60;
            this.lklLicenseHistory.TabStop = true;
            this.lklLicenseHistory.Text = "Show Licenses History";
            this.lklLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklLicenseHistory_LinkClicked);
            // 
            // ucApplicationReplacmentInfo1
            // 
            this.ucApplicationReplacmentInfo1.ApplicationDate = "????";
            this.ucApplicationReplacmentInfo1.ApplicationFees = "????";
            this.ucApplicationReplacmentInfo1.CreatedBy = "????";
            this.ucApplicationReplacmentInfo1.LicenseReplacmentApplicationID = "????";
            this.ucApplicationReplacmentInfo1.Location = new System.Drawing.Point(11, 479);
            this.ucApplicationReplacmentInfo1.Name = "ucApplicationReplacmentInfo1";
            this.ucApplicationReplacmentInfo1.OldLicenseID = "????";
            this.ucApplicationReplacmentInfo1.ReplacedLicenseID = "????";
            this.ucApplicationReplacmentInfo1.Size = new System.Drawing.Size(917, 136);
            this.ucApplicationReplacmentInfo1.TabIndex = 2;
            // 
            // ucFindLocalLicense1
            // 
            this.ucFindLocalLicense1.Location = new System.Drawing.Point(3, 43);
            this.ucFindLocalLicense1.Name = "ucFindLocalLicense1";
            this.ucFindLocalLicense1.Size = new System.Drawing.Size(928, 428);
            this.ucFindLocalLicense1.TabIndex = 0;
            this.ucFindLocalLicense1.onLicenseSelected += new System.Action<DVLDSystem_BusinessLayer_.clsLicense>(this.ucFindLocalLicense1_onLicenseSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Souvenir Lt BT", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(165, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(605, 42);
            this.label1.TabIndex = 62;
            this.label1.Text = "Replacement for Damaged License ";
            // 
            // btnIssueReplacement
            // 
            this.btnIssueReplacement.BackColor = System.Drawing.SystemColors.Control;
            this.btnIssueReplacement.BorderThickness = 1;
            this.btnIssueReplacement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIssueReplacement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIssueReplacement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIssueReplacement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIssueReplacement.Enabled = false;
            this.btnIssueReplacement.FillColor = System.Drawing.SystemColors.Control;
            this.btnIssueReplacement.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnIssueReplacement.ForeColor = System.Drawing.Color.Black;
            this.btnIssueReplacement.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.id_reload;
            this.btnIssueReplacement.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnIssueReplacement.ImageSize = new System.Drawing.Size(30, 30);
            this.btnIssueReplacement.Location = new System.Drawing.Point(709, 626);
            this.btnIssueReplacement.Name = "btnIssueReplacement";
            this.btnIssueReplacement.Size = new System.Drawing.Size(212, 38);
            this.btnIssueReplacement.TabIndex = 58;
            this.btnIssueReplacement.Text = "     Issue Replacement";
            this.btnIssueReplacement.Click += new System.EventHandler(this.btnIssueReplacement_Click);
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
            this.btnClose.Location = new System.Drawing.Point(575, 626);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 38);
            this.btnClose.TabIndex = 59;
            this.btnClose.Text = " Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmReplacementDamagedOrLostLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 674);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lklShowNewLicenseInfo);
            this.Controls.Add(this.lklLicenseHistory);
            this.Controls.Add(this.btnIssueReplacement);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ucApplicationReplacmentInfo1);
            this.Controls.Add(this.gbReplacment);
            this.Controls.Add(this.ucFindLocalLicense1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReplacementDamagedOrLostLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReplacementDamagedOrLostLicense";
            this.Load += new System.EventHandler(this.frmReplacementDamagedOrLostLicense_Load);
            this.gbReplacment.ResumeLayout(false);
            this.gbReplacment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private User_Control.ucFindLocalLicense ucFindLocalLicense1;
        private System.Windows.Forms.GroupBox gbReplacment;
        private System.Windows.Forms.RadioButton rbtnLostLicense;
        private System.Windows.Forms.RadioButton rbtnDamagedLicense;
        private User_Control.ucApplicationReplacmentInfo ucApplicationReplacmentInfo1;
        private System.Windows.Forms.LinkLabel lklShowNewLicenseInfo;
        private System.Windows.Forms.LinkLabel lklLicenseHistory;
        private Guna.UI2.WinForms.Guna2Button btnIssueReplacement;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label label1;
    }
}