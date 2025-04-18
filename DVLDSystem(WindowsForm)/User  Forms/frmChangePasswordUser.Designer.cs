namespace DVLDSystem_WindowsForm_.User__Forms
{
    partial class frmChangePasswordUser
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
            this.GBPersonInfo = new System.Windows.Forms.GroupBox();
            this.ucPersonCard1 = new DVLDSystem_WindowsForm_.User_Control.ucPersonCard();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ucUserCard1 = new DVLDSystem_WindowsForm_.User_Control.ucUserCard();
            this.lblCurrentPasswordTitle = new System.Windows.Forms.Label();
            this.lblNewPasswordTitle = new System.Windows.Forms.Label();
            this.lblConfirmPasswordTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.txtCurrentPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.ep1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.GBPersonInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).BeginInit();
            this.SuspendLayout();
            // 
            // GBPersonInfo
            // 
            this.GBPersonInfo.Controls.Add(this.ucPersonCard1);
            this.GBPersonInfo.Font = new System.Drawing.Font("Souvenir Lt BT", 15F, System.Drawing.FontStyle.Bold);
            this.GBPersonInfo.Location = new System.Drawing.Point(12, 7);
            this.GBPersonInfo.Name = "GBPersonInfo";
            this.GBPersonInfo.Size = new System.Drawing.Size(882, 296);
            this.GBPersonInfo.TabIndex = 0;
            this.GBPersonInfo.TabStop = false;
            this.GBPersonInfo.Text = "Person information";
            // 
            // ucPersonCard1
            // 
            this.ucPersonCard1.Address = "[????]";
            this.ucPersonCard1.Country = "[????]";
            this.ucPersonCard1.DateOfBirth = "[????]";
            this.ucPersonCard1.Email = "[????]";
            this.ucPersonCard1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucPersonCard1.Gendor = "[????]";
            this.ucPersonCard1.ID = "[????]";
            this.ucPersonCard1.Location = new System.Drawing.Point(34, 34);
            this.ucPersonCard1.Margin = new System.Windows.Forms.Padding(6);
            this.ucPersonCard1.Name = "ucPersonCard1";
            this.ucPersonCard1.NotionalNo = "[????]";
            this.ucPersonCard1.PersonName = "Empty Name ";
            this.ucPersonCard1.Phone = "[????]";
            this.ucPersonCard1.Picture = null;
            this.ucPersonCard1.PictureBackgroundLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucPersonCard1.Size = new System.Drawing.Size(824, 241);
            this.ucPersonCard1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ucUserCard1);
            this.groupBox1.Font = new System.Drawing.Font("Souvenir Lt BT", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(882, 90);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login information";
            // 
            // ucUserCard1
            // 
            this.ucUserCard1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.ucUserCard1.Location = new System.Drawing.Point(60, 34);
            this.ucUserCard1.Margin = new System.Windows.Forms.Padding(6);
            this.ucUserCard1.Name = "ucUserCard1";
            this.ucUserCard1.Size = new System.Drawing.Size(739, 43);
            this.ucUserCard1.TabIndex = 2;
            // 
            // lblCurrentPasswordTitle
            // 
            this.lblCurrentPasswordTitle.AutoSize = true;
            this.lblCurrentPasswordTitle.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lblCurrentPasswordTitle.Location = new System.Drawing.Point(41, 423);
            this.lblCurrentPasswordTitle.Name = "lblCurrentPasswordTitle";
            this.lblCurrentPasswordTitle.Size = new System.Drawing.Size(197, 24);
            this.lblCurrentPasswordTitle.TabIndex = 2;
            this.lblCurrentPasswordTitle.Text = "Current Password:";
            // 
            // lblNewPasswordTitle
            // 
            this.lblNewPasswordTitle.AutoSize = true;
            this.lblNewPasswordTitle.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lblNewPasswordTitle.Location = new System.Drawing.Point(73, 465);
            this.lblNewPasswordTitle.Name = "lblNewPasswordTitle";
            this.lblNewPasswordTitle.Size = new System.Drawing.Size(165, 24);
            this.lblNewPasswordTitle.TabIndex = 3;
            this.lblNewPasswordTitle.Text = "New Password:";
            // 
            // lblConfirmPasswordTitle
            // 
            this.lblConfirmPasswordTitle.AutoSize = true;
            this.lblConfirmPasswordTitle.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lblConfirmPasswordTitle.Location = new System.Drawing.Point(38, 507);
            this.lblConfirmPasswordTitle.Name = "lblConfirmPasswordTitle";
            this.lblConfirmPasswordTitle.Size = new System.Drawing.Size(200, 24);
            this.lblConfirmPasswordTitle.TabIndex = 4;
            this.lblConfirmPasswordTitle.Text = "Confirm Password:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(244, 419);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Number_32;
            this.pictureBox2.Location = new System.Drawing.Point(244, 503);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Number_32;
            this.pictureBox3.Location = new System.Drawing.Point(244, 461);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
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
            this.btnClose.Location = new System.Drawing.Point(632, 566);
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
            this.btnSave.FillColor = System.Drawing.SystemColors.Control;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSave.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSave.Location = new System.Drawing.Point(766, 566);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 38);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurrentPassword.DefaultText = "";
            this.txtCurrentPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCurrentPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCurrentPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrentPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrentPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCurrentPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCurrentPassword.Location = new System.Drawing.Point(293, 417);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '*';
            this.txtCurrentPassword.PlaceholderText = "";
            this.txtCurrentPassword.SelectedText = "";
            this.txtCurrentPassword.Size = new System.Drawing.Size(200, 36);
            this.txtCurrentPassword.TabIndex = 41;
            this.txtCurrentPassword.Tag = "Current password cannot be blank";
            this.txtCurrentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            this.txtCurrentPassword.Validated += new System.EventHandler(this.txtCurrentPassword_Validated);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.DefaultText = "";
            this.txtConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.Location = new System.Drawing.Point(293, 501);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.PlaceholderText = "";
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.Size = new System.Drawing.Size(200, 36);
            this.txtConfirmPassword.TabIndex = 42;
            this.txtConfirmPassword.Tag = "Confirm password Cannot be blank";
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword.DefaultText = "";
            this.txtNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPassword.Location = new System.Drawing.Point(293, 459);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.PlaceholderText = "";
            this.txtNewPassword.SelectedText = "";
            this.txtNewPassword.Size = new System.Drawing.Size(200, 36);
            this.txtNewPassword.TabIndex = 43;
            this.txtNewPassword.Tag = "New Password Cannot be blank";
            this.txtNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // ep1
            // 
            this.ep1.ContainerControl = this;
            // 
            // frmChangePasswordUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 623);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblConfirmPasswordTitle);
            this.Controls.Add(this.lblNewPasswordTitle);
            this.Controls.Add(this.lblCurrentPasswordTitle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GBPersonInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmChangePasswordUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.frmChangePasswordUser_Load);
            this.GBPersonInfo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBPersonInfo;
        private User_Control.ucPersonCard ucPersonCard1;
        private System.Windows.Forms.GroupBox groupBox1;
        private User_Control.ucUserCard ucUserCard1;
        private System.Windows.Forms.Label lblCurrentPasswordTitle;
        private System.Windows.Forms.Label lblNewPasswordTitle;
        private System.Windows.Forms.Label lblConfirmPasswordTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2TextBox txtCurrentPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        private System.Windows.Forms.ErrorProvider ep1;
    }
}