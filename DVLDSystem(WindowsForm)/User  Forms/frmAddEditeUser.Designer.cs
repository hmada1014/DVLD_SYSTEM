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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditeUser));
            this.lblTitleHeader = new System.Windows.Forms.Label();
            this.tcUser = new System.Windows.Forms.TabControl();
            this.tpPersonSelected = new System.Windows.Forms.TabPage();
            this.tpUserInfo = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ToggleSwitchISActive = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbAllPermission = new System.Windows.Forms.CheckBox();
            this.cbApplication = new System.Windows.Forms.CheckBox();
            this.cbPeople = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.cbUsers = new System.Windows.Forms.CheckBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnSelectePerson = new Guna.UI2.WinForms.Guna2Button();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.ucPersonCard4 = new DVLDSystem_WindowsForm_.User_Control.ucPersonCard();
            this.tcUser.SuspendLayout();
            this.tpPersonSelected.SuspendLayout();
            this.tpUserInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleHeader
            // 
            this.lblTitleHeader.AutoSize = true;
            this.lblTitleHeader.Font = new System.Drawing.Font("Tahoma", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleHeader.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitleHeader.Location = new System.Drawing.Point(266, 15);
            this.lblTitleHeader.Name = "lblTitleHeader";
            this.lblTitleHeader.Size = new System.Drawing.Size(261, 57);
            this.lblTitleHeader.TabIndex = 0;
            this.lblTitleHeader.Text = "Tile Name";
            // 
            // tcUser
            // 
            this.tcUser.Controls.Add(this.tpPersonSelected);
            this.tcUser.Controls.Add(this.tpUserInfo);
            this.tcUser.Location = new System.Drawing.Point(0, 78);
            this.tcUser.Name = "tcUser";
            this.tcUser.SelectedIndex = 0;
            this.tcUser.Size = new System.Drawing.Size(794, 323);
            this.tcUser.TabIndex = 1;
            // 
            // tpPersonSelected
            // 
            this.tpPersonSelected.Controls.Add(this.ucPersonCard4);
            this.tpPersonSelected.Controls.Add(this.btnSelectePerson);
            this.tpPersonSelected.Location = new System.Drawing.Point(4, 22);
            this.tpPersonSelected.Name = "tpPersonSelected";
            this.tpPersonSelected.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonSelected.Size = new System.Drawing.Size(786, 297);
            this.tpPersonSelected.TabIndex = 0;
            this.tpPersonSelected.Text = "Person Selected";
            this.tpPersonSelected.UseVisualStyleBackColor = true;
            // 
            // tpUserInfo
            // 
            this.tpUserInfo.Controls.Add(this.groupBox1);
            this.tpUserInfo.Controls.Add(this.ToggleSwitchISActive);
            this.tpUserInfo.Controls.Add(this.textBox1);
            this.tpUserInfo.Controls.Add(this.txtPassword);
            this.tpUserInfo.Controls.Add(this.lblPersonID);
            this.tpUserInfo.Controls.Add(this.lblUserID);
            this.tpUserInfo.Controls.Add(this.label5);
            this.tpUserInfo.Controls.Add(this.label4);
            this.tpUserInfo.Controls.Add(this.label3);
            this.tpUserInfo.Controls.Add(this.label2);
            this.tpUserInfo.Controls.Add(this.label1);
            this.tpUserInfo.Controls.Add(this.iconPictureBox5);
            this.tpUserInfo.Controls.Add(this.iconPictureBox4);
            this.tpUserInfo.Controls.Add(this.iconPictureBox3);
            this.tpUserInfo.Controls.Add(this.iconPictureBox2);
            this.tpUserInfo.Controls.Add(this.iconPictureBox1);
            this.tpUserInfo.Location = new System.Drawing.Point(4, 22);
            this.tpUserInfo.Name = "tpUserInfo";
            this.tpUserInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpUserInfo.Size = new System.Drawing.Size(786, 276);
            this.tpUserInfo.TabIndex = 1;
            this.tpUserInfo.Text = "User info";
            this.tpUserInfo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label2.Location = new System.Drawing.Point(22, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Person ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label3.Location = new System.Drawing.Point(22, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "UserName :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label4.Location = new System.Drawing.Point(22, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label5.Location = new System.Drawing.Point(30, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Is Active :";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.lblUserID.Location = new System.Drawing.Point(166, 45);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(37, 23);
            this.lblUserID.TabIndex = 5;
            this.lblUserID.Text = "???";
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.lblPersonID.Location = new System.Drawing.Point(166, 83);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(37, 23);
            this.lblPersonID.TabIndex = 8;
            this.lblPersonID.Text = "???";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(166, 168);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(112, 20);
            this.txtPassword.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 20);
            this.textBox1.TabIndex = 12;
            // 
            // ToggleSwitchISActive
            // 
            this.ToggleSwitchISActive.Checked = true;
            this.ToggleSwitchISActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ToggleSwitchISActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ToggleSwitchISActive.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleSwitchISActive.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ToggleSwitchISActive.Location = new System.Drawing.Point(166, 200);
            this.ToggleSwitchISActive.Name = "ToggleSwitchISActive";
            this.ToggleSwitchISActive.Size = new System.Drawing.Size(50, 31);
            this.ToggleSwitchISActive.TabIndex = 13;
            this.ToggleSwitchISActive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleSwitchISActive.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleSwitchISActive.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleSwitchISActive.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbUsers);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.cbPeople);
            this.groupBox1.Controls.Add(this.cbApplication);
            this.groupBox1.Controls.Add(this.cbAllPermission);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Location = new System.Drawing.Point(351, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 186);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permission :";
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
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.ForeColor = System.Drawing.Color.DarkGray;
            this.checkBox4.Location = new System.Drawing.Point(203, 50);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(132, 37);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Drivers";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // cbUsers
            // 
            this.cbUsers.AutoSize = true;
            this.cbUsers.ForeColor = System.Drawing.Color.DarkGray;
            this.cbUsers.Location = new System.Drawing.Point(203, 95);
            this.cbUsers.Name = "cbUsers";
            this.cbUsers.Size = new System.Drawing.Size(110, 37);
            this.cbUsers.TabIndex = 4;
            this.cbUsers.Text = "Users";
            this.cbUsers.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 10;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Font = new System.Drawing.Font("Roboto Condensed", 21F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(322, 407);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 35);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            // 
            // btnSelectePerson
            // 
            this.btnSelectePerson.BorderRadius = 10;
            this.btnSelectePerson.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectePerson.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectePerson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelectePerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSelectePerson.Font = new System.Drawing.Font("Roboto Condensed", 11F, System.Drawing.FontStyle.Bold);
            this.btnSelectePerson.ForeColor = System.Drawing.Color.White;
            this.btnSelectePerson.Location = new System.Drawing.Point(662, 4);
            this.btnSelectePerson.Name = "btnSelectePerson";
            this.btnSelectePerson.Size = new System.Drawing.Size(114, 35);
            this.btnSelectePerson.TabIndex = 3;
            this.btnSelectePerson.Text = "select person";
            this.btnSelectePerson.Click += new System.EventHandler(this.btnSelectePerson_Click);
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
            this.iconPictureBox5.Location = new System.Drawing.Point(131, 200);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(25, 27);
            this.iconPictureBox5.TabIndex = 14;
            this.iconPictureBox5.TabStop = false;
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox4.BackgroundImage = global::DVLDSystem_WindowsForm_.Properties.Resources.Person;
            this.iconPictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconPictureBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox4.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.IconSize = 25;
            this.iconPictureBox4.Location = new System.Drawing.Point(131, 123);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(25, 27);
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
            this.iconPictureBox3.IconSize = 25;
            this.iconPictureBox3.Location = new System.Drawing.Point(131, 163);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(25, 27);
            this.iconPictureBox3.TabIndex = 9;
            this.iconPictureBox3.TabStop = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.BackgroundImage = global::DVLDSystem_WindowsForm_.Properties.Resources.Male_User;
            this.iconPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 25;
            this.iconPictureBox2.Location = new System.Drawing.Point(131, 79);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(25, 27);
            this.iconPictureBox2.TabIndex = 7;
            this.iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.BackgroundImage = global::DVLDSystem_WindowsForm_.Properties.Resources.Male_User;
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 25;
            this.iconPictureBox1.Location = new System.Drawing.Point(131, 43);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(25, 27);
            this.iconPictureBox1.TabIndex = 6;
            this.iconPictureBox1.TabStop = false;
            // 
            // ucPersonCard4
            // 
            this.ucPersonCard4.Address = "????";
            this.ucPersonCard4.Country = "????";
            this.ucPersonCard4.DateOfBirth = "????";
            this.ucPersonCard4.Email = "????";
            this.ucPersonCard4.Gendor = "???";
            this.ucPersonCard4.ID = "???";
            this.ucPersonCard4.Location = new System.Drawing.Point(0, 45);
            this.ucPersonCard4.Name = "ucPersonCard4";
            this.ucPersonCard4.NotionalNo = "?????";
            this.ucPersonCard4.PersonName = "Empty Name ";
            this.ucPersonCard4.Phone = "????";
            this.ucPersonCard4.Picture = ((System.Drawing.Image)(resources.GetObject("ucPersonCard4.Picture")));
            this.ucPersonCard4.PictureBackgroundLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucPersonCard4.Size = new System.Drawing.Size(783, 252);
            this.ucPersonCard4.TabIndex = 4;
            // 
            // frmAddEditeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 447);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tcUser);
            this.Controls.Add(this.lblTitleHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAddEditeUser";
            this.Text = "frmAddEditeUser";
            this.Load += new System.EventHandler(this.frmAddEditeUser_Load);
            this.Click += new System.EventHandler(this.frmAddEditeUser_Click);
            this.tcUser.ResumeLayout(false);
            this.tpPersonSelected.ResumeLayout(false);
            this.tpUserInfo.ResumeLayout(false);
            this.tpUserInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleHeader;
        private System.Windows.Forms.TabControl tcUser;
        private System.Windows.Forms.TabPage tpPersonSelected;
        private System.Windows.Forms.TabPage tpUserInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPersonID;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ToggleSwitchISActive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbUsers;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox cbPeople;
        private System.Windows.Forms.CheckBox cbApplication;
        private System.Windows.Forms.CheckBox cbAllPermission;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnSelectePerson;
        private User_Control.ucPersonCard ucPersonCard4;
    }
}