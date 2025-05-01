namespace DVLDSystem_WindowsForm_.User_Control
{
    partial class ucTemplateDGVAndSearch
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbFindBy = new System.Windows.Forms.ComboBox();
            this.lblFindBy = new System.Windows.Forms.Label();
            this.dgvShowList = new System.Windows.Forms.DataGridView();
            this.cmsGeneralMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMShowDetailsGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMAddNewGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMEditGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMDeleteGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMRefreshGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.TSSchangePassword = new System.Windows.Forms.ToolStripSeparator();
            this.TSMSendEmailGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMPhoneCallGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearchDGV = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblRrecords = new System.Windows.Forms.Label();
            this.lblRecordsTitle = new System.Windows.Forms.Label();
            this.cbGeneral = new System.Windows.Forms.ComboBox();
            this.cmsLDLApplication = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMShowApplicationDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMEditApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMDeleteApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMCancelApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMSechduleTests = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMScheduleVisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMScheduleWrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMScheduleStreetTest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMIssueDrivingLicenseFirstTimeApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMShowLicenseApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMShowPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefreshDGV = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowList)).BeginInit();
            this.cmsGeneralMenu.SuspendLayout();
            this.cmsLDLApplication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefreshDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFindBy
            // 
            this.cbFindBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbFindBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFindBy.FormattingEnabled = true;
            this.cbFindBy.Location = new System.Drawing.Point(108, 29);
            this.cbFindBy.Name = "cbFindBy";
            this.cbFindBy.Size = new System.Drawing.Size(134, 21);
            this.cbFindBy.TabIndex = 0;
            this.cbFindBy.SelectedIndexChanged += new System.EventHandler(this._cbFindBy_SelectedIndexChanged);
            // 
            // lblFindBy
            // 
            this.lblFindBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFindBy.AutoSize = true;
            this.lblFindBy.Font = new System.Drawing.Font("Tahoma", 13F);
            this.lblFindBy.Location = new System.Drawing.Point(27, 28);
            this.lblFindBy.Name = "lblFindBy";
            this.lblFindBy.Size = new System.Drawing.Size(75, 22);
            this.lblFindBy.TabIndex = 1;
            this.lblFindBy.Text = "Find By ";
            // 
            // dgvShowList
            // 
            this.dgvShowList.AllowUserToAddRows = false;
            this.dgvShowList.AllowUserToDeleteRows = false;
            this.dgvShowList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(204)))), ((int)(((byte)(197)))));
            this.dgvShowList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShowList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShowList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvShowList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShowList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowList.ContextMenuStrip = this.cmsGeneralMenu;
            this.dgvShowList.EnableHeadersVisualStyles = false;
            this.dgvShowList.GridColor = System.Drawing.Color.Black;
            this.dgvShowList.Location = new System.Drawing.Point(0, 78);
            this.dgvShowList.Name = "dgvShowList";
            this.dgvShowList.ReadOnly = true;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgvShowList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvShowList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowList.Size = new System.Drawing.Size(651, 290);
            this.dgvShowList.TabIndex = 2;
            this.dgvShowList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dgvShowList_ShowDeitailsGeneral_CellDoubleClick);
            // 
            // cmsGeneralMenu
            // 
            this.cmsGeneralMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMShowDetailsGeneral,
            this.toolStripMenuItem1,
            this.TSMAddNewGeneral,
            this.TSMEditGeneral,
            this.TSMDeleteGeneral,
            this.TSMRefreshGeneral,
            this.toolStripSeparator1,
            this.TSMChangePassword,
            this.TSSchangePassword,
            this.TSMSendEmailGeneral,
            this.TSMPhoneCallGeneral});
            this.cmsGeneralMenu.Name = "cmsAddEdit";
            this.cmsGeneralMenu.Size = new System.Drawing.Size(185, 326);
            this.cmsGeneralMenu.Opening += new System.ComponentModel.CancelEventHandler(this._cmsGeneralMenu_opening);
            // 
            // TSMShowDetailsGeneral
            // 
            this.TSMShowDetailsGeneral.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.PersonDetails_32;
            this.TSMShowDetailsGeneral.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMShowDetailsGeneral.Name = "TSMShowDetailsGeneral";
            this.TSMShowDetailsGeneral.Size = new System.Drawing.Size(184, 38);
            this.TSMShowDetailsGeneral.Text = "Show Details";
            this.TSMShowDetailsGeneral.Click += new System.EventHandler(this._TSMShowDetailsGeneral_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 6);
            // 
            // TSMAddNewGeneral
            // 
            this.TSMAddNewGeneral.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.AddPerson_32;
            this.TSMAddNewGeneral.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMAddNewGeneral.Name = "TSMAddNewGeneral";
            this.TSMAddNewGeneral.Size = new System.Drawing.Size(184, 38);
            this.TSMAddNewGeneral.Text = "Add new ";
            this.TSMAddNewGeneral.Click += new System.EventHandler(this._TSMAddNewGeneral_Click);
            // 
            // TSMEditGeneral
            // 
            this.TSMEditGeneral.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Edit_32_1;
            this.TSMEditGeneral.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMEditGeneral.Name = "TSMEditGeneral";
            this.TSMEditGeneral.Size = new System.Drawing.Size(184, 38);
            this.TSMEditGeneral.Text = "Edit";
            this.TSMEditGeneral.Click += new System.EventHandler(this._TSMEditGeneral_Click);
            // 
            // TSMDeleteGeneral
            // 
            this.TSMDeleteGeneral.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.delete;
            this.TSMDeleteGeneral.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMDeleteGeneral.Name = "TSMDeleteGeneral";
            this.TSMDeleteGeneral.Size = new System.Drawing.Size(184, 38);
            this.TSMDeleteGeneral.Text = "Delete";
            this.TSMDeleteGeneral.Click += new System.EventHandler(this._TSMDeleteGeneral_Click);
            // 
            // TSMRefreshGeneral
            // 
            this.TSMRefreshGeneral.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Refresh_32;
            this.TSMRefreshGeneral.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMRefreshGeneral.Name = "TSMRefreshGeneral";
            this.TSMRefreshGeneral.Size = new System.Drawing.Size(184, 38);
            this.TSMRefreshGeneral.Text = "Refresh";
            this.TSMRefreshGeneral.Click += new System.EventHandler(this._TSM_Refresh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // TSMChangePassword
            // 
            this.TSMChangePassword.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Password_32;
            this.TSMChangePassword.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMChangePassword.Name = "TSMChangePassword";
            this.TSMChangePassword.Size = new System.Drawing.Size(184, 38);
            this.TSMChangePassword.Text = "Change Password";
            this.TSMChangePassword.Visible = false;
            this.TSMChangePassword.Click += new System.EventHandler(this._TSMChangePassword_Click);
            // 
            // TSSchangePassword
            // 
            this.TSSchangePassword.Name = "TSSchangePassword";
            this.TSSchangePassword.Size = new System.Drawing.Size(181, 6);
            this.TSSchangePassword.Visible = false;
            // 
            // TSMSendEmailGeneral
            // 
            this.TSMSendEmailGeneral.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.send_email_32;
            this.TSMSendEmailGeneral.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMSendEmailGeneral.Name = "TSMSendEmailGeneral";
            this.TSMSendEmailGeneral.Size = new System.Drawing.Size(184, 38);
            this.TSMSendEmailGeneral.Text = "Send Email";
            this.TSMSendEmailGeneral.Click += new System.EventHandler(this._TSMSendEmailGeneral_Click);
            // 
            // TSMPhoneCallGeneral
            // 
            this.TSMPhoneCallGeneral.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.call_32;
            this.TSMPhoneCallGeneral.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMPhoneCallGeneral.Name = "TSMPhoneCallGeneral";
            this.TSMPhoneCallGeneral.Size = new System.Drawing.Size(184, 38);
            this.TSMPhoneCallGeneral.Text = "Phone Call";
            this.TSMPhoneCallGeneral.Click += new System.EventHandler(this._TSMPhoneCallGeneral_Click);
            // 
            // txtSearchDGV
            // 
            this.txtSearchDGV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearchDGV.BorderRadius = 10;
            this.txtSearchDGV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchDGV.DefaultText = "";
            this.txtSearchDGV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchDGV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchDGV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchDGV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchDGV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchDGV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchDGV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchDGV.Location = new System.Drawing.Point(265, 21);
            this.txtSearchDGV.Name = "txtSearchDGV";
            this.txtSearchDGV.PasswordChar = '\0';
            this.txtSearchDGV.PlaceholderText = "";
            this.txtSearchDGV.SelectedText = "";
            this.txtSearchDGV.Size = new System.Drawing.Size(310, 36);
            this.txtSearchDGV.TabIndex = 3;
            this.txtSearchDGV.TextChanged += new System.EventHandler(this._txtSearchDGV_TextChanged);
            this.txtSearchDGV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtSearchDGV_KeyPress);
            // 
            // lblRrecords
            // 
            this.lblRrecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRrecords.AutoSize = true;
            this.lblRrecords.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblRrecords.Location = new System.Drawing.Point(105, 372);
            this.lblRrecords.Name = "lblRrecords";
            this.lblRrecords.Size = new System.Drawing.Size(18, 19);
            this.lblRrecords.TabIndex = 8;
            this.lblRrecords.Text = "0";
            // 
            // lblRecordsTitle
            // 
            this.lblRecordsTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecordsTitle.AutoSize = true;
            this.lblRecordsTitle.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblRecordsTitle.Location = new System.Drawing.Point(8, 371);
            this.lblRecordsTitle.Name = "lblRecordsTitle";
            this.lblRecordsTitle.Size = new System.Drawing.Size(88, 19);
            this.lblRecordsTitle.TabIndex = 7;
            this.lblRecordsTitle.Text = "#Records :";
            // 
            // cbGeneral
            // 
            this.cbGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbGeneral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGeneral.FormattingEnabled = true;
            this.cbGeneral.Location = new System.Drawing.Point(281, 29);
            this.cbGeneral.Name = "cbGeneral";
            this.cbGeneral.Size = new System.Drawing.Size(134, 21);
            this.cbGeneral.TabIndex = 9;
            this.cbGeneral.Visible = false;
            this.cbGeneral.SelectedIndexChanged += new System.EventHandler(this._cbGeneral_SelectedIndexChanged);
            // 
            // cmsLDLApplication
            // 
            this.cmsLDLApplication.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMShowApplicationDetails,
            this.toolStripMenuItem2,
            this.TSMEditApplication,
            this.TSMDeleteApplication,
            this.TSMCancelApplication,
            this.toolStripMenuItem3,
            this.TSMSechduleTests,
            this.toolStripMenuItem4,
            this.TSMIssueDrivingLicenseFirstTimeApplication,
            this.toolStripMenuItem5,
            this.TSMShowLicenseApplication,
            this.toolStripMenuItem6,
            this.TSMShowPersonLicenseHistory});
            this.cmsLDLApplication.Name = "cmsLDLApplication";
            this.cmsLDLApplication.Size = new System.Drawing.Size(262, 338);
            this.cmsLDLApplication.Opening += new System.ComponentModel.CancelEventHandler(this._cmsLDLApplication_Opening);
            // 
            // TSMShowApplicationDetails
            // 
            this.TSMShowApplicationDetails.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.PersonDetails_32;
            this.TSMShowApplicationDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMShowApplicationDetails.Name = "TSMShowApplicationDetails";
            this.TSMShowApplicationDetails.Size = new System.Drawing.Size(261, 38);
            this.TSMShowApplicationDetails.Text = "Show Application Details";
            this.TSMShowApplicationDetails.Click += new System.EventHandler(this._TSMShowDetailsGeneral_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(258, 6);
            // 
            // TSMEditApplication
            // 
            this.TSMEditApplication.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Edit_32_1;
            this.TSMEditApplication.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMEditApplication.Name = "TSMEditApplication";
            this.TSMEditApplication.Size = new System.Drawing.Size(261, 38);
            this.TSMEditApplication.Text = "Edit Application";
            this.TSMEditApplication.Click += new System.EventHandler(this._TSMEditGeneral_Click);
            // 
            // TSMDeleteApplication
            // 
            this.TSMDeleteApplication.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.delete;
            this.TSMDeleteApplication.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMDeleteApplication.Name = "TSMDeleteApplication";
            this.TSMDeleteApplication.Size = new System.Drawing.Size(261, 38);
            this.TSMDeleteApplication.Text = "Delete Application";
            this.TSMDeleteApplication.Click += new System.EventHandler(this._TSMDeleteGeneral_Click);
            // 
            // TSMCancelApplication
            // 
            this.TSMCancelApplication.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Delete_32;
            this.TSMCancelApplication.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMCancelApplication.Name = "TSMCancelApplication";
            this.TSMCancelApplication.Size = new System.Drawing.Size(261, 38);
            this.TSMCancelApplication.Text = "Cance Applicationl";
            this.TSMCancelApplication.Click += new System.EventHandler(this._TSMCancelApplicationl_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(258, 6);
            // 
            // TSMSechduleTests
            // 
            this.TSMSechduleTests.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMScheduleVisionTest,
            this.TSMScheduleWrittenTest,
            this.TSMScheduleStreetTest});
            this.TSMSechduleTests.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Schedule_Test_32;
            this.TSMSechduleTests.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMSechduleTests.Name = "TSMSechduleTests";
            this.TSMSechduleTests.Size = new System.Drawing.Size(261, 38);
            this.TSMSechduleTests.Text = "Sechdule Tests";
            // 
            // TSMScheduleVisionTest
            // 
            this.TSMScheduleVisionTest.Enabled = false;
            this.TSMScheduleVisionTest.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Vision_Test_32;
            this.TSMScheduleVisionTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMScheduleVisionTest.Name = "TSMScheduleVisionTest";
            this.TSMScheduleVisionTest.Size = new System.Drawing.Size(203, 38);
            this.TSMScheduleVisionTest.Text = "Schedule Vision Test";
            this.TSMScheduleVisionTest.Click += new System.EventHandler(this.TSMScheduleTestGeneral_Click);
            // 
            // TSMScheduleWrittenTest
            // 
            this.TSMScheduleWrittenTest.Enabled = false;
            this.TSMScheduleWrittenTest.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Written_Test_32_Sechdule;
            this.TSMScheduleWrittenTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMScheduleWrittenTest.Name = "TSMScheduleWrittenTest";
            this.TSMScheduleWrittenTest.Size = new System.Drawing.Size(203, 38);
            this.TSMScheduleWrittenTest.Text = "Schedule Written Test";
            this.TSMScheduleWrittenTest.Click += new System.EventHandler(this.TSMScheduleTestGeneral_Click);
            // 
            // TSMScheduleStreetTest
            // 
            this.TSMScheduleStreetTest.Enabled = false;
            this.TSMScheduleStreetTest.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Street_Test_32;
            this.TSMScheduleStreetTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMScheduleStreetTest.Name = "TSMScheduleStreetTest";
            this.TSMScheduleStreetTest.Size = new System.Drawing.Size(203, 38);
            this.TSMScheduleStreetTest.Text = "Schedule Street Test";
            this.TSMScheduleStreetTest.Click += new System.EventHandler(this.TSMScheduleTestGeneral_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(258, 6);
            // 
            // TSMIssueDrivingLicenseFirstTimeApplication
            // 
            this.TSMIssueDrivingLicenseFirstTimeApplication.Enabled = false;
            this.TSMIssueDrivingLicenseFirstTimeApplication.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.IssueDrivingLicense_32;
            this.TSMIssueDrivingLicenseFirstTimeApplication.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMIssueDrivingLicenseFirstTimeApplication.Name = "TSMIssueDrivingLicenseFirstTimeApplication";
            this.TSMIssueDrivingLicenseFirstTimeApplication.Size = new System.Drawing.Size(261, 38);
            this.TSMIssueDrivingLicenseFirstTimeApplication.Text = "Issue Driving License (First Time)";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(258, 6);
            // 
            // TSMShowLicenseApplication
            // 
            this.TSMShowLicenseApplication.Enabled = false;
            this.TSMShowLicenseApplication.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.License_View_32;
            this.TSMShowLicenseApplication.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMShowLicenseApplication.Name = "TSMShowLicenseApplication";
            this.TSMShowLicenseApplication.Size = new System.Drawing.Size(261, 38);
            this.TSMShowLicenseApplication.Text = "show License";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(258, 6);
            // 
            // TSMShowPersonLicenseHistory
            // 
            this.TSMShowPersonLicenseHistory.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.PersonLicenseHistory_32;
            this.TSMShowPersonLicenseHistory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMShowPersonLicenseHistory.Name = "TSMShowPersonLicenseHistory";
            this.TSMShowPersonLicenseHistory.Size = new System.Drawing.Size(261, 38);
            this.TSMShowPersonLicenseHistory.Text = "Show Person License History";
            // 
            // btnRefreshDGV
            // 
            this.btnRefreshDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshDGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnRefreshDGV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRefreshDGV.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            this.btnRefreshDGV.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnRefreshDGV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefreshDGV.IconSize = 27;
            this.btnRefreshDGV.Location = new System.Drawing.Point(616, 368);
            this.btnRefreshDGV.Name = "btnRefreshDGV";
            this.btnRefreshDGV.Size = new System.Drawing.Size(35, 27);
            this.btnRefreshDGV.TabIndex = 4;
            this.btnRefreshDGV.TabStop = false;
            this.btnRefreshDGV.Click += new System.EventHandler(this._btnRefreshDGV_Click);
            // 
            // ucTemplateDGVAndSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.cbGeneral);
            this.Controls.Add(this.lblRrecords);
            this.Controls.Add(this.lblRecordsTitle);
            this.Controls.Add(this.btnRefreshDGV);
            this.Controls.Add(this.txtSearchDGV);
            this.Controls.Add(this.dgvShowList);
            this.Controls.Add(this.lblFindBy);
            this.Controls.Add(this.cbFindBy);
            this.Name = "ucTemplateDGVAndSearch";
            this.Size = new System.Drawing.Size(651, 395);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowList)).EndInit();
            this.cmsGeneralMenu.ResumeLayout(false);
            this.cmsLDLApplication.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRefreshDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFindBy;
        private System.Windows.Forms.Label lblFindBy;
        private System.Windows.Forms.DataGridView dgvShowList;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchDGV;
        private FontAwesome.Sharp.IconPictureBox btnRefreshDGV;
        private System.Windows.Forms.Label lblRrecords;
        private System.Windows.Forms.Label lblRecordsTitle;
        private System.Windows.Forms.ContextMenuStrip cmsGeneralMenu;
        private System.Windows.Forms.ToolStripMenuItem TSMEditGeneral;
        private System.Windows.Forms.ToolStripMenuItem TSMDeleteGeneral;
        private System.Windows.Forms.ToolStripMenuItem TSMRefreshGeneral;
        private System.Windows.Forms.ComboBox cbGeneral;
        private System.Windows.Forms.ToolStripMenuItem TSMShowDetailsGeneral;
        private System.Windows.Forms.ToolStripMenuItem TSMAddNewGeneral;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem TSMSendEmailGeneral;
        private System.Windows.Forms.ToolStripMenuItem TSMPhoneCallGeneral;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TSMChangePassword;
        private System.Windows.Forms.ToolStripSeparator TSSchangePassword;
        private System.Windows.Forms.ContextMenuStrip cmsLDLApplication;
        private System.Windows.Forms.ToolStripMenuItem TSMShowApplicationDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem TSMEditApplication;
        private System.Windows.Forms.ToolStripMenuItem TSMDeleteApplication;
        private System.Windows.Forms.ToolStripMenuItem TSMCancelApplication;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem TSMSechduleTests;
        private System.Windows.Forms.ToolStripMenuItem TSMScheduleVisionTest;
        private System.Windows.Forms.ToolStripMenuItem TSMScheduleWrittenTest;
        private System.Windows.Forms.ToolStripMenuItem TSMScheduleStreetTest;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem TSMIssueDrivingLicenseFirstTimeApplication;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem TSMShowLicenseApplication;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem TSMShowPersonLicenseHistory;
    }
}
