using System.Windows.Markup;

namespace DVLDSystem_WindowsForm_.Application_Forms
{
    partial class frmManageLDLApplication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Reference userControl ucTemplateDGVAndSearch1
        // this.ucTemplateDGVAndSearch1 = new DVLDSystem_WindowsForm_.User_Control.ucTemplateDGVAndSearch("frmManageLDLApplication");

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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddLocalDrivingLicenseApplication = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ucTemplateDGVAndSearch1 = new DVLDSystem_WindowsForm_.User_Control.ucTemplateDGVAndSearch("frmManageLDLApplication");
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
            this.label1.Size = new System.Drawing.Size(472, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Local Driving License Applications";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DVLDSystem_WindowsForm_.Properties.Resources.Applications_512;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(497, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
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
            this.btnAddLocalDrivingLicenseApplication.Location = new System.Drawing.Point(1064, 215);
            this.btnAddLocalDrivingLicenseApplication.Name = "btnAddLocalDrivingLicenseApplication";
            this.btnAddLocalDrivingLicenseApplication.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddLocalDrivingLicenseApplication.Size = new System.Drawing.Size(79, 62);
            this.btnAddLocalDrivingLicenseApplication.TabIndex = 8;
            this.btnAddLocalDrivingLicenseApplication.Click += new System.EventHandler(this.btnAddLocalDrivingLicenseApplication_Click);
            // 
            // ucTemplateDGVAndSearch1
            // 
            this.ucTemplateDGVAndSearch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ucTemplateDGVAndSearch1.dgvAutoSizeColumnMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.ucTemplateDGVAndSearch1.dgvAutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.None;
            this.ucTemplateDGVAndSearch1.dgvBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ucTemplateDGVAndSearch1.dgvColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ucTemplateDGVAndSearch1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucTemplateDGVAndSearch1.Location = new System.Drawing.Point(0, 203);
            this.ucTemplateDGVAndSearch1.Name = "ucTemplateDGVAndSearch1";
            this.ucTemplateDGVAndSearch1.Size = new System.Drawing.Size(1172, 386);
            this.ucTemplateDGVAndSearch1.TabIndex = 0;
            this.ucTemplateDGVAndSearch1.TextBoxLocation = new System.Drawing.Point(450, 21);
            // 
            // frmManageLDLApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 589);
            this.Controls.Add(this.btnAddLocalDrivingLicenseApplication);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ucTemplateDGVAndSearch1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageLDLApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageLocalDrivingLicenseApplication";
            this.Load += new System.EventHandler(this.frmManageLocalDrivingLicenseApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private User_Control.ucTemplateDGVAndSearch ucTemplateDGVAndSearch1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ImageButton btnAddLocalDrivingLicenseApplication;
    }
}