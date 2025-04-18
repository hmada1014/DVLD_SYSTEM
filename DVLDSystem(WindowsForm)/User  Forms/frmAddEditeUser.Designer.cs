namespace DVLDSystem_WindowsForm_.User
{
    partial class frmAddEditeUser
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
            this.lblTitleHeader = new System.Windows.Forms.Label();
            this.tcUser = new System.Windows.Forms.TabControl();
            this.TPPersonalInfo = new System.Windows.Forms.TabPage();
            this.ucFindPerson1 = new DVLDSystem_WindowsForm_.User_Control.ucFindPerson();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.TPLoginInfo = new System.Windows.Forms.TabPage();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbUsers = new System.Windows.Forms.CheckBox();
            this.cbDrivers = new System.Windows.Forms.CheckBox();
            this.cbPeople = new System.Windows.Forms.CheckBox();
            this.cbApplication = new System.Windows.Forms.CheckBox();
            this.cbAllPermission = new System.Windows.Forms.CheckBox();
            this.ToggleSwitchISActive = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.tcUser.SuspendLayout();
            this.TPPersonalInfo.SuspendLayout();
            this.TPLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleHeader
            // 
            this.lblTitleHeader.AutoSize = true;
            this.lblTitleHeader.Font = new System.Drawing.Font("Souvenir Lt BT", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleHeader.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitleHeader.Location = new System.Drawing.Point(333, 9);
            this.lblTitleHeader.Name = "lblTitleHeader";
            this.lblTitleHeader.Size = new System.Drawing.Size(185, 42);
            this.lblTitleHeader.TabIndex = 0;
            this.lblTitleHeader.Text = "Tile Name";
            // 
            // tcUser
            // 
            this.tcUser.Controls.Add(this.TPPersonalInfo);
            this.tcUser.Controls.Add(this.TPLoginInfo);
            this.tcUser.Location = new System.Drawing.Point(0, 49);
            this.tcUser.Name = "tcUser";
            this.tcUser.SelectedIndex = 0;
            this.tcUser.Size = new System.Drawing.Size(916, 417);
            this.tcUser.TabIndex = 1;
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
            // TPLoginInfo
            // 
            this.TPLoginInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.TPLoginInfo.Controls.Add(this.txtConfirmPassword);
            this.TPLoginInfo.Controls.Add(this.label2);
            this.TPLoginInfo.Controls.Add(this.iconPictureBox2);
            this.TPLoginInfo.Controls.Add(this.groupBox1);
            this.TPLoginInfo.Controls.Add(this.ToggleSwitchISActive);
            this.TPLoginInfo.Controls.Add(this.txtUsername);
            this.TPLoginInfo.Controls.Add(this.txtPassword);
            this.TPLoginInfo.Controls.Add(this.lblUserID);
            this.TPLoginInfo.Controls.Add(this.label5);
            this.TPLoginInfo.Controls.Add(this.label4);
            this.TPLoginInfo.Controls.Add(this.label3);
            this.TPLoginInfo.Controls.Add(this.label1);
            this.TPLoginInfo.Controls.Add(this.iconPictureBox5);
            this.TPLoginInfo.Controls.Add(this.iconPictureBox4);
            this.TPLoginInfo.Controls.Add(this.iconPictureBox3);
            this.TPLoginInfo.Controls.Add(this.iconPictureBox1);
            this.TPLoginInfo.Location = new System.Drawing.Point(4, 22);
            this.TPLoginInfo.Name = "TPLoginInfo";
            this.TPLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TPLoginInfo.Size = new System.Drawing.Size(908, 391);
            this.TPLoginInfo.TabIndex = 1;
            this.TPLoginInfo.Text = "LoginInfo";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(215, 161);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(151, 20);
            this.txtConfirmPassword.TabIndex = 13;
            this.txtConfirmPassword.Tag = "Confirm password is required to fill.";
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label2.Location = new System.Drawing.Point(0, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Confirm Password :";
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
            this.iconPictureBox2.Location = new System.Drawing.Point(180, 161);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(25, 20);
            this.iconPictureBox2.TabIndex = 17;
            this.iconPictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbUsers);
            this.groupBox1.Controls.Add(this.cbDrivers);
            this.groupBox1.Controls.Add(this.cbPeople);
            this.groupBox1.Controls.Add(this.cbApplication);
            this.groupBox1.Controls.Add(this.cbAllPermission);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Location = new System.Drawing.Point(390, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 186);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permission :";
            this.groupBox1.Validating += new System.ComponentModel.CancelEventHandler(this.cb_Validating);
            // 
            // cbUsers
            // 
            this.cbUsers.AutoSize = true;
            this.cbUsers.ForeColor = System.Drawing.Color.DarkGray;
            this.cbUsers.Location = new System.Drawing.Point(232, 95);
            this.cbUsers.Name = "cbUsers";
            this.cbUsers.Size = new System.Drawing.Size(110, 37);
            this.cbUsers.TabIndex = 4;
            this.cbUsers.Text = "Users";
            this.cbUsers.UseVisualStyleBackColor = true;
            // 
            // cbDrivers
            // 
            this.cbDrivers.AutoSize = true;
            this.cbDrivers.ForeColor = System.Drawing.Color.DarkGray;
            this.cbDrivers.Location = new System.Drawing.Point(232, 50);
            this.cbDrivers.Name = "cbDrivers";
            this.cbDrivers.Size = new System.Drawing.Size(132, 37);
            this.cbDrivers.TabIndex = 3;
            this.cbDrivers.Text = "Drivers";
            this.cbDrivers.UseVisualStyleBackColor = true;
            // 
            // cbPeople
            // 
            this.cbPeople.AutoSize = true;
            this.cbPeople.ForeColor = System.Drawing.Color.DarkGray;
            this.cbPeople.Location = new System.Drawing.Point(6, 140);
            this.cbPeople.Name = "cbPeople";
            this.cbPeople.Size = new System.Drawing.Size(126, 37);
            this.cbPeople.TabIndex = 2;
            this.cbPeople.Text = "People";
            this.cbPeople.UseVisualStyleBackColor = true;
            // 
            // cbApplication
            // 
            this.cbApplication.AutoSize = true;
            this.cbApplication.ForeColor = System.Drawing.Color.DarkGray;
            this.cbApplication.Location = new System.Drawing.Point(6, 95);
            this.cbApplication.Name = "cbApplication";
            this.cbApplication.Size = new System.Drawing.Size(185, 37);
            this.cbApplication.TabIndex = 1;
            this.cbApplication.Text = "Application";
            this.cbApplication.UseVisualStyleBackColor = true;
            // 
            // cbAllPermission
            // 
            this.cbAllPermission.AutoSize = true;
            this.cbAllPermission.ForeColor = System.Drawing.Color.DarkGray;
            this.cbAllPermission.Location = new System.Drawing.Point(6, 50);
            this.cbAllPermission.Name = "cbAllPermission";
            this.cbAllPermission.Size = new System.Drawing.Size(68, 37);
            this.cbAllPermission.TabIndex = 0;
            this.cbAllPermission.Text = "All";
            this.cbAllPermission.UseVisualStyleBackColor = true;
            this.cbAllPermission.CheckedChanged += new System.EventHandler(this.cbAllPermission_CheckedChanged);
            // 
            // ToggleSwitchISActive
            // 
            this.ToggleSwitchISActive.Checked = true;
            this.ToggleSwitchISActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ToggleSwitchISActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ToggleSwitchISActive.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleSwitchISActive.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ToggleSwitchISActive.Location = new System.Drawing.Point(215, 200);
            this.ToggleSwitchISActive.Name = "ToggleSwitchISActive";
            this.ToggleSwitchISActive.Size = new System.Drawing.Size(50, 31);
            this.ToggleSwitchISActive.TabIndex = 13;
            this.ToggleSwitchISActive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleSwitchISActive.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleSwitchISActive.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleSwitchISActive.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(215, 83);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(151, 20);
            this.txtUsername.TabIndex = 10;
            this.txtUsername.Tag = "username canot be blank";
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(215, 122);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(151, 20);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.Tag = "Password is required to fill.";
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.lblUserID.Location = new System.Drawing.Point(215, 43);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(37, 23);
            this.lblUserID.TabIndex = 5;
            this.lblUserID.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label5.Location = new System.Drawing.Point(79, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Is Active :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label4.Location = new System.Drawing.Point(71, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label3.Location = new System.Drawing.Point(63, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "UserName :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label1.Location = new System.Drawing.Point(86, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID :";
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
            this.iconPictureBox5.Location = new System.Drawing.Point(180, 200);
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
            this.iconPictureBox4.Location = new System.Drawing.Point(180, 83);
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
            this.iconPictureBox3.Location = new System.Drawing.Point(180, 122);
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
            this.iconPictureBox1.Location = new System.Drawing.Point(180, 44);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(25, 20);
            this.iconPictureBox1.TabIndex = 6;
            this.iconPictureBox1.TabStop = false;
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
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
            this.btnClose.Location = new System.Drawing.Point(650, 470);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 38);
            this.btnClose.TabIndex = 40;
            this.btnClose.Text = "close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnSave.Location = new System.Drawing.Point(784, 470);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 38);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddEditeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 513);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tcUser);
            this.Controls.Add(this.lblTitleHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAddEditeUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddEditeUser";
            this.Load += new System.EventHandler(this.frmAddEditeUser_Load);
            this.tcUser.ResumeLayout(false);
            this.TPPersonalInfo.ResumeLayout(false);
            this.TPLoginInfo.ResumeLayout(false);
            this.TPLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleHeader;
        private System.Windows.Forms.TabControl tcUser;
        private System.Windows.Forms.TabPage TPPersonalInfo;
        private System.Windows.Forms.TabPage TPLoginInfo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ToggleSwitchISActive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbUsers;
        private System.Windows.Forms.CheckBox cbDrivers;
        private System.Windows.Forms.CheckBox cbPeople;
        private System.Windows.Forms.CheckBox cbApplication;
        private System.Windows.Forms.CheckBox cbAllPermission;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private User_Control.ucFindPerson ucFindPerson1;
    }
}