namespace DVLDSystem_WindowsForm_.User__Forms
{
    partial class frmShowUserDetails
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ucUserCard1 = new DVLDSystem_WindowsForm_.User_Control.ucUserCard();
            this.GBPersonInfo = new System.Windows.Forms.GroupBox();
            this.ucPersonCard1 = new DVLDSystem_WindowsForm_.User_Control.ucPersonCard();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1.SuspendLayout();
            this.GBPersonInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ucUserCard1);
            this.groupBox1.Font = new System.Drawing.Font("Souvenir Lt BT", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(880, 90);
            this.groupBox1.TabIndex = 3;
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
            // GBPersonInfo
            // 
            this.GBPersonInfo.Controls.Add(this.ucPersonCard1);
            this.GBPersonInfo.Font = new System.Drawing.Font("Souvenir Lt BT", 15F, System.Drawing.FontStyle.Bold);
            this.GBPersonInfo.Location = new System.Drawing.Point(12, 12);
            this.GBPersonInfo.Name = "GBPersonInfo";
            this.GBPersonInfo.Size = new System.Drawing.Size(880, 296);
            this.GBPersonInfo.TabIndex = 2;
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
            this.btnClose.Location = new System.Drawing.Point(759, 422);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 38);
            this.btnClose.TabIndex = 41;
            this.btnClose.Text = "close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmShowUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 470);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GBPersonInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmShowUserDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Details";
            this.Load += new System.EventHandler(this.frmShowUserDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.GBPersonInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private User_Control.ucUserCard ucUserCard1;
        private System.Windows.Forms.GroupBox GBPersonInfo;
        private User_Control.ucPersonCard ucPersonCard1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}