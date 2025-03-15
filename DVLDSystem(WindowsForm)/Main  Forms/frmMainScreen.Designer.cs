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
            this.tsmPeople = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDrivers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClose = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsername = new System.Windows.Forms.Label();
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
            this.tsmClose});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(959, 24);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "MainMenu";
            // 
            // tsmApplication
            // 
            this.tsmApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsmApplication.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmApplication.Name = "tsmApplication";
            this.tsmApplication.Size = new System.Drawing.Size(80, 20);
            this.tsmApplication.Text = "Application";
            // 
            // tsmPeople
            // 
            this.tsmPeople.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmPeople.Name = "tsmPeople";
            this.tsmPeople.Size = new System.Drawing.Size(55, 20);
            this.tsmPeople.Text = "People";
            this.tsmPeople.Click += new System.EventHandler(this.tsmPeople_Click);
            // 
            // tsmDrivers
            // 
            this.tsmDrivers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmDrivers.Name = "tsmDrivers";
            this.tsmDrivers.Size = new System.Drawing.Size(55, 20);
            this.tsmDrivers.Text = "Drivers";
            // 
            // tsmUsers
            // 
            this.tsmUsers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmUsers.Name = "tsmUsers";
            this.tsmUsers.Size = new System.Drawing.Size(47, 20);
            this.tsmUsers.Text = "Users";
            this.tsmUsers.Click += new System.EventHandler(this.tsmUsers_Click);
            // 
            // tsmClose
            // 
            this.tsmClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsmClose.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.tsmClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmClose.Name = "tsmClose";
            this.tsmClose.Size = new System.Drawing.Size(48, 20);
            this.tsmClose.Text = "Close";
            this.tsmClose.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblUsername.Location = new System.Drawing.Point(749, 24);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(57, 19);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "User : ";
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(959, 498);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.msMain);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMain;
            this.Name = "frmMainScreen";
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
        private System.Windows.Forms.ToolStripMenuItem tsmClose;
        private System.Windows.Forms.Label lblUsername;
    }
}