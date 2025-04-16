namespace DVLDSystem_WindowsForm_.User_Control
{
    partial class ucUserCard
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
            this.lblUserIDTitle = new System.Windows.Forms.Label();
            this.lblUsernameTitle = new System.Windows.Forms.Label();
            this.lblIsActiveTitle = new System.Windows.Forms.Label();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserIDTitle
            // 
            this.lblUserIDTitle.AutoSize = true;
            this.lblUserIDTitle.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblUserIDTitle.Location = new System.Drawing.Point(19, 11);
            this.lblUserIDTitle.Name = "lblUserIDTitle";
            this.lblUserIDTitle.Size = new System.Drawing.Size(110, 27);
            this.lblUserIDTitle.TabIndex = 0;
            this.lblUserIDTitle.Text = "User ID :";
            // 
            // lblUsernameTitle
            // 
            this.lblUsernameTitle.AutoSize = true;
            this.lblUsernameTitle.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblUsernameTitle.Location = new System.Drawing.Point(244, 11);
            this.lblUsernameTitle.Name = "lblUsernameTitle";
            this.lblUsernameTitle.Size = new System.Drawing.Size(137, 27);
            this.lblUsernameTitle.TabIndex = 1;
            this.lblUsernameTitle.Text = "Username :";
            // 
            // lblIsActiveTitle
            // 
            this.lblIsActiveTitle.AutoSize = true;
            this.lblIsActiveTitle.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblIsActiveTitle.Location = new System.Drawing.Point(550, 11);
            this.lblIsActiveTitle.Name = "lblIsActiveTitle";
            this.lblIsActiveTitle.Size = new System.Drawing.Size(123, 27);
            this.lblIsActiveTitle.TabIndex = 2;
            this.lblIsActiveTitle.Text = "Is Active :";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblIsActive.Location = new System.Drawing.Point(676, 11);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(49, 27);
            this.lblIsActive.TabIndex = 3;
            this.lblIsActive.Text = "yes";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblUsername.Location = new System.Drawing.Point(387, 11);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(74, 27);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "user4";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblUserID.Location = new System.Drawing.Point(135, 11);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(68, 27);
            this.lblUserID.TabIndex = 5;
            this.lblUserID.Text = "1023";
            // 
            // ucUserCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblIsActive);
            this.Controls.Add(this.lblIsActiveTitle);
            this.Controls.Add(this.lblUsernameTitle);
            this.Controls.Add(this.lblUserIDTitle);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblUserID);
            this.Name = "ucUserCard";
            this.Size = new System.Drawing.Size(733, 46);
            this.Load += new System.EventHandler(this.ucUserCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserIDTitle;
        private System.Windows.Forms.Label lblUsernameTitle;
        private System.Windows.Forms.Label lblIsActiveTitle;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblUserID;
    }
}
