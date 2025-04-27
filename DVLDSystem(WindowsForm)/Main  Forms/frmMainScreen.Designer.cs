namespace DVLDSystem_WindowsForm_
{
    partial class frmMainScreen
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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.drivingLicensesServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMNewLocalLicenseApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replacementForLostOrDamagedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.releaseDetainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retakeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.manageApplicationsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMlocalDrivingLicenseApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMinternationalLinceseApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.detainLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDetainedLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseDetainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMManageApplicationTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMManageTestTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPeople = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDrivers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAccountSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMCurrentUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmApplication,
            this.tsmPeople,
            this.tsmDrivers,
            this.tsmUsers,
            this.tsmAccountSettings});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(959, 72);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "MainMenu";
            // 
            // tsmApplication
            // 
            this.tsmApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsmApplication.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivingLicensesServicesToolStripMenuItem,
            this.manageApplicationsToolStripMenuItem,
            this.manageApplicationsToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.detainLicensesToolStripMenuItem,
            this.TSMManageApplicationTypes,
            this.TSMManageTestTypes});
            this.tsmApplication.Font = new System.Drawing.Font("Simplified Arabic Backslanted", 9F, System.Drawing.FontStyle.Bold);
            this.tsmApplication.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Applications_64;
            this.tsmApplication.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmApplication.Name = "tsmApplication";
            this.tsmApplication.Size = new System.Drawing.Size(163, 68);
            this.tsmApplication.Text = "Application";
            // 
            // drivingLicensesServicesToolStripMenuItem
            // 
            this.drivingLicensesServicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLicenseToolStripMenuItem,
            this.renewDrivingLicenseToolStripMenuItem,
            this.replacementForLostOrDamagedLicenseToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.releaseDetainToolStripMenuItem,
            this.retakeTestToolStripMenuItem});
            this.drivingLicensesServicesToolStripMenuItem.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Driver_License_48;
            this.drivingLicensesServicesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.drivingLicensesServicesToolStripMenuItem.Name = "drivingLicensesServicesToolStripMenuItem";
            this.drivingLicensesServicesToolStripMenuItem.Size = new System.Drawing.Size(313, 70);
            this.drivingLicensesServicesToolStripMenuItem.Text = "Driving Licenses Services";
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            this.newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMNewLocalLicenseApplication,
            this.internationalLicenseToolStripMenuItem});
            this.newDrivingLicenseToolStripMenuItem.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.New_Driving_License_32;
            this.newDrivingLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            this.newDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(389, 38);
            this.newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            // 
            // TSMNewLocalLicenseApplication
            // 
            this.TSMNewLocalLicenseApplication.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Local_32;
            this.TSMNewLocalLicenseApplication.Name = "TSMNewLocalLicenseApplication";
            this.TSMNewLocalLicenseApplication.Size = new System.Drawing.Size(237, 38);
            this.TSMNewLocalLicenseApplication.Text = "Local License";
            this.TSMNewLocalLicenseApplication.Click += new System.EventHandler(this.TSMNewLocalLicenseApplication_Click);
            // 
            // internationalLicenseToolStripMenuItem
            // 
            this.internationalLicenseToolStripMenuItem.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.International_32;
            this.internationalLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            this.internationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(237, 38);
            this.internationalLicenseToolStripMenuItem.Text = "International License";
            // 
            // renewDrivingLicenseToolStripMenuItem
            // 
            this.renewDrivingLicenseToolStripMenuItem.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Renew_Driving_License_32;
            this.renewDrivingLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.renewDrivingLicenseToolStripMenuItem.Name = "renewDrivingLicenseToolStripMenuItem";
            this.renewDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(389, 38);
            this.renewDrivingLicenseToolStripMenuItem.Text = "Renew Driving License";
            // 
            // replacementForLostOrDamagedLicenseToolStripMenuItem
            // 
            this.replacementForLostOrDamagedLicenseToolStripMenuItem.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Damaged_Driving_License_32;
            this.replacementForLostOrDamagedLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.replacementForLostOrDamagedLicenseToolStripMenuItem.Name = "replacementForLostOrDamagedLicenseToolStripMenuItem";
            this.replacementForLostOrDamagedLicenseToolStripMenuItem.Size = new System.Drawing.Size(389, 38);
            this.replacementForLostOrDamagedLicenseToolStripMenuItem.Text = "Replacement for Lost or Damaged License";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(386, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(386, 6);
            // 
            // releaseDetainToolStripMenuItem
            // 
            this.releaseDetainToolStripMenuItem.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Detained_Driving_License_32;
            this.releaseDetainToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.releaseDetainToolStripMenuItem.Name = "releaseDetainToolStripMenuItem";
            this.releaseDetainToolStripMenuItem.Size = new System.Drawing.Size(389, 38);
            this.releaseDetainToolStripMenuItem.Text = "Release Detained Driving License";
            // 
            // retakeTestToolStripMenuItem
            // 
            this.retakeTestToolStripMenuItem.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Retake_Test_32;
            this.retakeTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            this.retakeTestToolStripMenuItem.Size = new System.Drawing.Size(389, 38);
            this.retakeTestToolStripMenuItem.Text = "Retake Test";
            // 
            // manageApplicationsToolStripMenuItem
            // 
            this.manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            this.manageApplicationsToolStripMenuItem.Size = new System.Drawing.Size(310, 6);
            // 
            // manageApplicationsToolStripMenuItem1
            // 
            this.manageApplicationsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMlocalDrivingLicenseApplications,
            this.TSMinternationalLinceseApplications});
            this.manageApplicationsToolStripMenuItem1.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Manage_Applications_64;
            this.manageApplicationsToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageApplicationsToolStripMenuItem1.Name = "manageApplicationsToolStripMenuItem1";
            this.manageApplicationsToolStripMenuItem1.Size = new System.Drawing.Size(313, 70);
            this.manageApplicationsToolStripMenuItem1.Text = "Manage Applications";
            // 
            // TSMlocalDrivingLicenseApplications
            // 
            this.TSMlocalDrivingLicenseApplications.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.LocalDriving_License;
            this.TSMlocalDrivingLicenseApplications.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMlocalDrivingLicenseApplications.Name = "TSMlocalDrivingLicenseApplications";
            this.TSMlocalDrivingLicenseApplications.Size = new System.Drawing.Size(333, 38);
            this.TSMlocalDrivingLicenseApplications.Text = "Local Driving License Applications";
            this.TSMlocalDrivingLicenseApplications.Click += new System.EventHandler(this.TSMlocalDrivingLicenseApplications_Click);
            // 
            // TSMinternationalLinceseApplications
            // 
            this.TSMinternationalLinceseApplications.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.International_32;
            this.TSMinternationalLinceseApplications.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMinternationalLinceseApplications.Name = "TSMinternationalLinceseApplications";
            this.TSMinternationalLinceseApplications.Size = new System.Drawing.Size(333, 38);
            this.TSMinternationalLinceseApplications.Text = "International Lincese Applications";
            this.TSMinternationalLinceseApplications.Click += new System.EventHandler(this.TSMinternationalLinceseApplications_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(310, 6);
            // 
            // detainLicensesToolStripMenuItem
            // 
            this.detainLicensesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDetainedLicensesToolStripMenuItem,
            this.detainToolStripMenuItem,
            this.releaseDetainedLicenseToolStripMenuItem});
            this.detainLicensesToolStripMenuItem.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Detain_64;
            this.detainLicensesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.detainLicensesToolStripMenuItem.Name = "detainLicensesToolStripMenuItem";
            this.detainLicensesToolStripMenuItem.Size = new System.Drawing.Size(313, 70);
            this.detainLicensesToolStripMenuItem.Text = "Detain Licenses";
            // 
            // manageDetainedLicensesToolStripMenuItem
            // 
            this.manageDetainedLicensesToolStripMenuItem.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Detain_32;
            this.manageDetainedLicensesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageDetainedLicensesToolStripMenuItem.Name = "manageDetainedLicensesToolStripMenuItem";
            this.manageDetainedLicensesToolStripMenuItem.Size = new System.Drawing.Size(284, 38);
            this.manageDetainedLicensesToolStripMenuItem.Text = "Manage Detained Licenses";
            // 
            // detainToolStripMenuItem
            // 
            this.detainToolStripMenuItem.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Detain_32;
            this.detainToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.detainToolStripMenuItem.Name = "detainToolStripMenuItem";
            this.detainToolStripMenuItem.Size = new System.Drawing.Size(284, 38);
            this.detainToolStripMenuItem.Text = "Detain License";
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            this.releaseDetainedLicenseToolStripMenuItem.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Release_Detained_License_32;
            this.releaseDetainedLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            this.releaseDetainedLicenseToolStripMenuItem.Size = new System.Drawing.Size(284, 38);
            this.releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            // 
            // TSMManageApplicationTypes
            // 
            this.TSMManageApplicationTypes.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Application_Types_64;
            this.TSMManageApplicationTypes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMManageApplicationTypes.Name = "TSMManageApplicationTypes";
            this.TSMManageApplicationTypes.Size = new System.Drawing.Size(313, 70);
            this.TSMManageApplicationTypes.Text = "Manage Application Types";
            this.TSMManageApplicationTypes.Click += new System.EventHandler(this.TSMManageApplicationTypes_Click);
            // 
            // TSMManageTestTypes
            // 
            this.TSMManageTestTypes.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Test_Type_64;
            this.TSMManageTestTypes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMManageTestTypes.Name = "TSMManageTestTypes";
            this.TSMManageTestTypes.Size = new System.Drawing.Size(313, 70);
            this.TSMManageTestTypes.Text = "Manage Test Types";
            this.TSMManageTestTypes.Click += new System.EventHandler(this.TSMManageTestTypes_Click);
            // 
            // tsmPeople
            // 
            this.tsmPeople.Font = new System.Drawing.Font("Simplified Arabic Backslanted", 9F, System.Drawing.FontStyle.Bold);
            this.tsmPeople.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.People_64;
            this.tsmPeople.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmPeople.Name = "tsmPeople";
            this.tsmPeople.Size = new System.Drawing.Size(135, 68);
            this.tsmPeople.Text = "People";
            this.tsmPeople.Click += new System.EventHandler(this.TSMPeople_Click);
            // 
            // tsmDrivers
            // 
            this.tsmDrivers.Font = new System.Drawing.Font("Simplified Arabic Backslanted", 9F, System.Drawing.FontStyle.Bold);
            this.tsmDrivers.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Drivers_64;
            this.tsmDrivers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmDrivers.Name = "tsmDrivers";
            this.tsmDrivers.Size = new System.Drawing.Size(135, 68);
            this.tsmDrivers.Text = "Drivers";
            // 
            // tsmUsers
            // 
            this.tsmUsers.Font = new System.Drawing.Font("Simplified Arabic Backslanted", 9F, System.Drawing.FontStyle.Bold);
            this.tsmUsers.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Users_2_64;
            this.tsmUsers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmUsers.Name = "tsmUsers";
            this.tsmUsers.Size = new System.Drawing.Size(126, 68);
            this.tsmUsers.Text = "Users";
            this.tsmUsers.Click += new System.EventHandler(this.TSMUsers_Click);
            // 
            // tsmAccountSettings
            // 
            this.tsmAccountSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsmAccountSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMCurrentUserInfo,
            this.TSMChangePassword,
            this.TSMSignOut});
            this.tsmAccountSettings.Font = new System.Drawing.Font("Simplified Arabic Backslanted", 9F, System.Drawing.FontStyle.Bold);
            this.tsmAccountSettings.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.account_settings_64;
            this.tsmAccountSettings.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.tsmAccountSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmAccountSettings.Name = "tsmAccountSettings";
            this.tsmAccountSettings.Size = new System.Drawing.Size(200, 68);
            this.tsmAccountSettings.Text = "Account Settings";
            // 
            // TSMCurrentUserInfo
            // 
            this.TSMCurrentUserInfo.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.PersonDetails_32;
            this.TSMCurrentUserInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMCurrentUserInfo.Name = "TSMCurrentUserInfo";
            this.TSMCurrentUserInfo.Size = new System.Drawing.Size(219, 38);
            this.TSMCurrentUserInfo.Text = "Current User info";
            this.TSMCurrentUserInfo.Click += new System.EventHandler(this.TSMCurrentUserInfo_Click);
            // 
            // TSMChangePassword
            // 
            this.TSMChangePassword.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Password_32;
            this.TSMChangePassword.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMChangePassword.Name = "TSMChangePassword";
            this.TSMChangePassword.Size = new System.Drawing.Size(219, 38);
            this.TSMChangePassword.Text = "Change Password";
            this.TSMChangePassword.Click += new System.EventHandler(this.TSMChangePassword_Click);
            // 
            // TSMSignOut
            // 
            this.TSMSignOut.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.sign_out_32__2;
            this.TSMSignOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMSignOut.Name = "TSMSignOut";
            this.TSMSignOut.Size = new System.Drawing.Size(219, 38);
            this.TSMSignOut.Text = "Sign out";
            this.TSMSignOut.Click += new System.EventHandler(this.TSMSignOut_Click);
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(959, 498);
            this.Controls.Add(this.msMain);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMain;
            this.Name = "frmMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMainScreen_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmApplication;
        private System.Windows.Forms.ToolStripMenuItem tsmPeople;
        private System.Windows.Forms.ToolStripMenuItem tsmDrivers;
        private System.Windows.Forms.ToolStripMenuItem tsmUsers;
        private System.Windows.Forms.ToolStripMenuItem tsmAccountSettings;
        private System.Windows.Forms.ToolStripMenuItem drivingLicensesServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem replacementForLostOrDamagedLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator manageApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem detainLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMManageApplicationTypes;
        private System.Windows.Forms.ToolStripMenuItem TSMManageTestTypes;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMNewLocalLicenseApplication;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retakeTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDetainedLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMlocalDrivingLicenseApplications;
        private System.Windows.Forms.ToolStripMenuItem TSMinternationalLinceseApplications;
        private System.Windows.Forms.ToolStripMenuItem TSMCurrentUserInfo;
        private System.Windows.Forms.ToolStripMenuItem TSMChangePassword;
        private System.Windows.Forms.ToolStripMenuItem TSMSignOut;
    }
}