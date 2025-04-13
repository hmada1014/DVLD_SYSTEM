namespace DVLDSystem_WindowsForm_.People__Forms
{
    partial class frmPersonInfo
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
            this.ucPersonCard1 = new DVLDSystem_WindowsForm_.User_Control.ucPersonCard();
            this.gbPrsonInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.gbPrsonInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucPersonCard1
            // 
            this.ucPersonCard1.Address = "[????]";
            this.ucPersonCard1.Country = "[????]";
            this.ucPersonCard1.DateOfBirth = "[????]";
            this.ucPersonCard1.Email = "[????]";
            this.ucPersonCard1.Gendor = "[????]";
            this.ucPersonCard1.ID = "[????]";
            this.ucPersonCard1.Location = new System.Drawing.Point(17, 19);
            this.ucPersonCard1.Name = "ucPersonCard1";
            this.ucPersonCard1.NotionalNo = "[????]";
            this.ucPersonCard1.PersonName = "Empty Name ";
            this.ucPersonCard1.Phone = "[????]";
            this.ucPersonCard1.Picture = null;
            this.ucPersonCard1.PictureBackgroundLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucPersonCard1.Size = new System.Drawing.Size(814, 257);
            this.ucPersonCard1.TabIndex = 0;
            // 
            // gbPrsonInfo
            // 
            this.gbPrsonInfo.Controls.Add(this.ucPersonCard1);
            this.gbPrsonInfo.Location = new System.Drawing.Point(12, 61);
            this.gbPrsonInfo.Name = "gbPrsonInfo";
            this.gbPrsonInfo.Size = new System.Drawing.Size(849, 286);
            this.gbPrsonInfo.TabIndex = 1;
            this.gbPrsonInfo.TabStop = false;
            this.gbPrsonInfo.Text = "Person information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swissra-Medium", 22F);
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(310, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "Person Details";
            // 
            // btnClose
            // 
            this.btnClose.BorderThickness = 1;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnClose.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Close_32;
            this.btnClose.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.Location = new System.Drawing.Point(751, 360);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 34);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 406);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbPrsonInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPersonInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Person  Details";
            this.Load += new System.EventHandler(this.frmPersonInfo_Load);
            this.gbPrsonInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private User_Control.ucPersonCard ucPersonCard1;
        private System.Windows.Forms.GroupBox gbPrsonInfo;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}