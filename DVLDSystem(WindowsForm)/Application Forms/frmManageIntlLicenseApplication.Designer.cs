namespace DVLDSystem_WindowsForm_.international_License_Forms
{
    partial class frmManageIntlLicenseApplication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        // frmManageIntLLicenseApplication
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddLocalDrivingLicenseApplication = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ucTemplateDGVAndSearch1 = new DVLDSystem_WindowsForm_.User_Control.ucTemplateDGVAndSearch("frmManageIntLLicenseApplication");
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(356, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "International License Applications";
            // 
            // btnAddLocalDrivingLicenseApplication
            // 
            this.btnAddLocalDrivingLicenseApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddLocalDrivingLicenseApplication.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddLocalDrivingLicenseApplication.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddLocalDrivingLicenseApplication.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddLocalDrivingLicenseApplication.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.New_Application_64;
            this.btnAddLocalDrivingLicenseApplication.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAddLocalDrivingLicenseApplication.ImageRotate = 0F;
            this.btnAddLocalDrivingLicenseApplication.ImageSize = new System.Drawing.Size(48, 48);
            this.btnAddLocalDrivingLicenseApplication.Location = new System.Drawing.Point(1081, 207);
            this.btnAddLocalDrivingLicenseApplication.Name = "btnAddLocalDrivingLicenseApplication";
            this.btnAddLocalDrivingLicenseApplication.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddLocalDrivingLicenseApplication.Size = new System.Drawing.Size(79, 62);
            this.btnAddLocalDrivingLicenseApplication.TabIndex = 11;
            this.btnAddLocalDrivingLicenseApplication.Click += new System.EventHandler(this.btnAddLocalDrivingLicenseApplication_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DVLDSystem_WindowsForm_.Properties.Resources.Applications_Inel_512;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(497, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // ucTemplateDGVAndSearch1
            // 
            this.ucTemplateDGVAndSearch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ucTemplateDGVAndSearch1.dgvAutoSizeColumnMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ucTemplateDGVAndSearch1.dgvAutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.None;
            this.ucTemplateDGVAndSearch1.dgvBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ucTemplateDGVAndSearch1.dgvColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ucTemplateDGVAndSearch1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucTemplateDGVAndSearch1.Location = new System.Drawing.Point(0, 194);
            this.ucTemplateDGVAndSearch1.Name = "ucTemplateDGVAndSearch1";
            this.ucTemplateDGVAndSearch1.Size = new System.Drawing.Size(1172, 395);
            this.ucTemplateDGVAndSearch1.TabIndex = 12;
            this.ucTemplateDGVAndSearch1.TextBoxLocation = new System.Drawing.Point(526, 21);
            // 
            // frmManageIntlLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 589);
            this.Controls.Add(this.btnAddLocalDrivingLicenseApplication);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ucTemplateDGVAndSearch1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageIntlLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageIntLLicenseApplication";
            this.Load += new System.EventHandler(this.frmManageIntlLicenseApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton btnAddLocalDrivingLicenseApplication;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private User_Control.ucTemplateDGVAndSearch ucTemplateDGVAndSearch1;
    }
}