namespace DVLDSystem_WindowsForm_.Application_Forms
{
    partial class frmAddEditLDLApplication
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
            this.components = new System.ComponentModel.Container();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.TPApplicationInfo = new System.Windows.Forms.TabPage();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.cbLicenseClass = new System.Windows.Forms.ComboBox();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.lblDLApplicationID = new System.Windows.Forms.Label();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.TPPersonalInfo = new System.Windows.Forms.TabPage();
            this.ucFindPerson1 = new DVLDSystem_WindowsForm_.User_Control.ucFindPerson();
            this.tcApplicationInfo = new System.Windows.Forms.TabControl();
            this.lblTitleHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.TPApplicationInfo.SuspendLayout();
            this.TPPersonalInfo.SuspendLayout();
            this.tcApplicationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.BorderThickness = 1;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Enabled = false;
            this.btnSave.FillColor = System.Drawing.SystemColors.Control;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSave.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSave.Location = new System.Drawing.Point(796, 483);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 38);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label5.Location = new System.Drawing.Point(76, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Created By :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label4.Location = new System.Drawing.Point(53, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "License Class  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label3.Location = new System.Drawing.Point(31, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Application Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label1.Location = new System.Drawing.Point(16, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "D.L.Application ID :";
            // 
            // iconPictureBox5
            // 
            this.iconPictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox5.BackgroundImage = global::DVLDSystem_WindowsForm_.Properties.Resources.Toggle_Indeterminate;
            this.iconPictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconPictureBox5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox5.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox5.IconSize = 25;
            this.iconPictureBox5.Location = new System.Drawing.Point(212, 213);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(25, 27);
            this.iconPictureBox5.TabIndex = 14;
            this.iconPictureBox5.TabStop = false;
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox4.BackgroundImage = global::DVLDSystem_WindowsForm_.Properties.Resources.Person_32;
            this.iconPictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconPictureBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox4.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.IconSize = 20;
            this.iconPictureBox4.Location = new System.Drawing.Point(212, 96);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(25, 20);
            this.iconPictureBox4.TabIndex = 11;
            this.iconPictureBox4.TabStop = false;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox3.BackgroundImage = global::DVLDSystem_WindowsForm_.Properties.Resources.Password;
            this.iconPictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 20;
            this.iconPictureBox3.Location = new System.Drawing.Point(212, 135);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(25, 20);
            this.iconPictureBox3.TabIndex = 9;
            this.iconPictureBox3.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.BackgroundImage = global::DVLDSystem_WindowsForm_.Properties.Resources.Identification_Documents;
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 20;
            this.iconPictureBox1.Location = new System.Drawing.Point(212, 57);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(25, 20);
            this.iconPictureBox1.TabIndex = 6;
            this.iconPictureBox1.TabStop = false;
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
            this.btnClose.Location = new System.Drawing.Point(662, 483);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 38);
            this.btnClose.TabIndex = 44;
            this.btnClose.Text = "close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label2.Location = new System.Drawing.Point(32, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Application Fees :";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.BackgroundImage = global::DVLDSystem_WindowsForm_.Properties.Resources.Password;
            this.iconPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 20;
            this.iconPictureBox2.Location = new System.Drawing.Point(212, 174);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(25, 20);
            this.iconPictureBox2.TabIndex = 17;
            this.iconPictureBox2.TabStop = false;
            // 
            // TPApplicationInfo
            // 
            this.TPApplicationInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.TPApplicationInfo.Controls.Add(this.lblCreatedBy);
            this.TPApplicationInfo.Controls.Add(this.lblApplicationFees);
            this.TPApplicationInfo.Controls.Add(this.cbLicenseClass);
            this.TPApplicationInfo.Controls.Add(this.lblApplicationDate);
            this.TPApplicationInfo.Controls.Add(this.lblDLApplicationID);
            this.TPApplicationInfo.Controls.Add(this.label2);
            this.TPApplicationInfo.Controls.Add(this.iconPictureBox2);
            this.TPApplicationInfo.Controls.Add(this.label5);
            this.TPApplicationInfo.Controls.Add(this.label4);
            this.TPApplicationInfo.Controls.Add(this.label3);
            this.TPApplicationInfo.Controls.Add(this.label1);
            this.TPApplicationInfo.Controls.Add(this.iconPictureBox5);
            this.TPApplicationInfo.Controls.Add(this.iconPictureBox4);
            this.TPApplicationInfo.Controls.Add(this.iconPictureBox3);
            this.TPApplicationInfo.Controls.Add(this.iconPictureBox1);
            this.TPApplicationInfo.Location = new System.Drawing.Point(4, 22);
            this.TPApplicationInfo.Name = "TPApplicationInfo";
            this.TPApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TPApplicationInfo.Size = new System.Drawing.Size(908, 391);
            this.TPApplicationInfo.TabIndex = 1;
            this.TPApplicationInfo.Text = "Application Info";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.lblCreatedBy.Location = new System.Drawing.Point(269, 213);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(91, 23);
            this.lblCreatedBy.TabIndex = 22;
            this.lblCreatedBy.Text = "Msaqer77";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.lblApplicationFees.Location = new System.Drawing.Point(269, 173);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(30, 23);
            this.lblApplicationFees.TabIndex = 21;
            this.lblApplicationFees.Text = "15";
            // 
            // cbLicenseClass
            // 
            this.cbLicenseClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLicenseClass.FormattingEnabled = true;
            this.cbLicenseClass.Location = new System.Drawing.Point(269, 136);
            this.cbLicenseClass.Name = "cbLicenseClass";
            this.cbLicenseClass.Size = new System.Drawing.Size(205, 21);
            this.cbLicenseClass.TabIndex = 20;
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.lblApplicationDate.Location = new System.Drawing.Point(265, 95);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(94, 23);
            this.lblApplicationDate.TabIndex = 19;
            this.lblApplicationDate.Text = "10/9/2023";
            // 
            // lblDLApplicationID
            // 
            this.lblDLApplicationID.AutoSize = true;
            this.lblDLApplicationID.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.lblDLApplicationID.Location = new System.Drawing.Point(265, 56);
            this.lblDLApplicationID.Name = "lblDLApplicationID";
            this.lblDLApplicationID.Size = new System.Drawing.Size(57, 23);
            this.lblDLApplicationID.TabIndex = 18;
            this.lblDLApplicationID.Text = "[???] ";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.Control;
            this.btnNext.BorderThickness = 1;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.SystemColors.Control;
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Next_32;
            this.btnNext.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnNext.ImageSize = new System.Drawing.Size(30, 30);
            this.btnNext.Location = new System.Drawing.Point(780, 354);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(105, 30);
            this.btnNext.TabIndex = 41;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // TPPersonalInfo
            // 
            this.TPPersonalInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.TPPersonalInfo.Controls.Add(this.ucFindPerson1);
            this.TPPersonalInfo.Controls.Add(this.btnNext);
            this.TPPersonalInfo.Location = new System.Drawing.Point(4, 22);
            this.TPPersonalInfo.Name = "TPPersonalInfo";
            this.TPPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TPPersonalInfo.Size = new System.Drawing.Size(908, 391);
            this.TPPersonalInfo.TabIndex = 0;
            this.TPPersonalInfo.Text = "Personal info ";
            // 
            // ucFindPerson1
            // 
            this.ucFindPerson1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ucFindPerson1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ucFindPerson1.GBFilterMode = true;
            this.ucFindPerson1.Location = new System.Drawing.Point(8, 3);
            this.ucFindPerson1.Name = "ucFindPerson1";
            this.ucFindPerson1.Size = new System.Drawing.Size(890, 346);
            this.ucFindPerson1.TabIndex = 42;
            this.ucFindPerson1.onPersonSelected += new System.Action<int>(this.ucFindPerson1_onPersonSelected);
            // 
            // tcApplicationInfo
            // 
            this.tcApplicationInfo.Controls.Add(this.TPPersonalInfo);
            this.tcApplicationInfo.Controls.Add(this.TPApplicationInfo);
            this.tcApplicationInfo.Location = new System.Drawing.Point(12, 62);
            this.tcApplicationInfo.Name = "tcApplicationInfo";
            this.tcApplicationInfo.SelectedIndex = 0;
            this.tcApplicationInfo.Size = new System.Drawing.Size(916, 417);
            this.tcApplicationInfo.TabIndex = 42;
            // 
            // lblTitleHeader
            // 
            this.lblTitleHeader.AutoSize = true;
            this.lblTitleHeader.Font = new System.Drawing.Font("Souvenir Lt BT", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleHeader.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitleHeader.Location = new System.Drawing.Point(91, 9);
            this.lblTitleHeader.Name = "lblTitleHeader";
            this.lblTitleHeader.Size = new System.Drawing.Size(185, 42);
            this.lblTitleHeader.TabIndex = 41;
            this.lblTitleHeader.Text = "Tile Name";
            // 
            // frmAddEditLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 536);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tcApplicationInfo);
            this.Controls.Add(this.lblTitleHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddEditLocalDrivingLicenseApplication";
            this.Text = "frmLocalDrivingLicenseApplication";
            this.Load += new System.EventHandler(this.frmAddLocalDrivingLicenseApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.TPApplicationInfo.ResumeLayout(false);
            this.TPApplicationInfo.PerformLayout();
            this.TPPersonalInfo.ResumeLayout(false);
            this.tcApplicationInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.ErrorProvider ep;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.TabControl tcApplicationInfo;
        private System.Windows.Forms.TabPage TPPersonalInfo;
        private User_Control.ucFindPerson ucFindPerson1;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private System.Windows.Forms.TabPage TPApplicationInfo;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label lblTitleHeader;
        private System.Windows.Forms.Label lblDLApplicationID;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.ComboBox cbLicenseClass;
        private System.Windows.Forms.Label lblApplicationDate;
    }
}