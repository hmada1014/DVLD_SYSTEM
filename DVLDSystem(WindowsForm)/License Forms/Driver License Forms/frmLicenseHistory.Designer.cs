namespace DVLDSystem_WindowsForm_.Driver_License_Forms
{
    partial class frmLicenseHistory
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpLocalHistoryLicense = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tpInternationalHistoryLicense = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.ucTemplateDGV1_Local = new DVLDSystem_WindowsForm_.User_Control.ucTemplateDGV("ucLocalHistory");
            this.ucTemplateDGV1_international = new DVLDSystem_WindowsForm_.User_Control.ucTemplateDGV("ucInternationalHistory");
            this.ucFindPerson1 = new DVLDSystem_WindowsForm_.User_Control.ucFindPerson();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpLocalHistoryLicense.SuspendLayout();
            this.tpInternationalHistoryLicense.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Souvenir Lt BT", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(510, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "License History";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.PersonLicenseHistory_512;
            this.pictureBox1.Location = new System.Drawing.Point(12, 236);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpLocalHistoryLicense);
            this.tabControl1.Controls.Add(this.tpInternationalHistoryLicense);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(1, 404);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1088, 230);
            this.tabControl1.TabIndex = 3;
            // 
            // tpLocalHistoryLicense
            // 
            this.tpLocalHistoryLicense.Controls.Add(this.label2);
            this.tpLocalHistoryLicense.Controls.Add(this.ucTemplateDGV1_Local);
            this.tpLocalHistoryLicense.Font = new System.Drawing.Font("Tahoma", 30F);
            this.tpLocalHistoryLicense.Location = new System.Drawing.Point(4, 30);
            this.tpLocalHistoryLicense.Name = "tpLocalHistoryLicense";
            this.tpLocalHistoryLicense.Padding = new System.Windows.Forms.Padding(3);
            this.tpLocalHistoryLicense.Size = new System.Drawing.Size(1080, 196);
            this.tpLocalHistoryLicense.TabIndex = 0;
            this.tpLocalHistoryLicense.Text = "Local";
            this.tpLocalHistoryLicense.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label2.Location = new System.Drawing.Point(7, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Local Licenses History:";
            // 
            // tpInternationalHistoryLicense
            // 
            this.tpInternationalHistoryLicense.Controls.Add(this.label3);
            this.tpInternationalHistoryLicense.Controls.Add(this.ucTemplateDGV1_international);
            this.tpInternationalHistoryLicense.Location = new System.Drawing.Point(4, 30);
            this.tpInternationalHistoryLicense.Name = "tpInternationalHistoryLicense";
            this.tpInternationalHistoryLicense.Padding = new System.Windows.Forms.Padding(3);
            this.tpInternationalHistoryLicense.Size = new System.Drawing.Size(1080, 196);
            this.tpInternationalHistoryLicense.TabIndex = 1;
            this.tpInternationalHistoryLicense.Text = "International";
            this.tpInternationalHistoryLicense.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label3.Location = new System.Drawing.Point(7, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "International Licenses History:";
            // 
            // ucTemplateDGV1_Local
            // 
            this.ucTemplateDGV1_Local.dgvColor = System.Drawing.SystemColors.AppWorkspace;
            this.ucTemplateDGV1_Local.dgvSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.ucTemplateDGV1_Local.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucTemplateDGV1_Local.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ucTemplateDGV1_Local.Location = new System.Drawing.Point(3, 21);
            this.ucTemplateDGV1_Local.Name = "ucTemplateDGV1_Local";
            this.ucTemplateDGV1_Local.Size = new System.Drawing.Size(1074, 172);
            this.ucTemplateDGV1_Local.TabIndex = 0;
            // 
            // ucTemplateDGV1_international
            // 
            this.ucTemplateDGV1_international.dgvColor = System.Drawing.SystemColors.AppWorkspace;
            this.ucTemplateDGV1_international.dgvSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.ucTemplateDGV1_international.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucTemplateDGV1_international.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ucTemplateDGV1_international.Location = new System.Drawing.Point(3, 21);
            this.ucTemplateDGV1_international.Name = "ucTemplateDGV1_international";
            this.ucTemplateDGV1_international.Size = new System.Drawing.Size(1074, 172);
            this.ucTemplateDGV1_international.TabIndex = 1;
            // 
            // ucFindPerson1
            // 
            this.ucFindPerson1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ucFindPerson1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ucFindPerson1.GBFilterMode = true;
            this.ucFindPerson1.Location = new System.Drawing.Point(209, 57);
            this.ucFindPerson1.Name = "ucFindPerson1";
            this.ucFindPerson1.Size = new System.Drawing.Size(880, 341);
            this.ucFindPerson1.TabIndex = 1;
            this.ucFindPerson1.txtSearch = "";
            // 
            // frmLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 691);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ucFindPerson1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLicenseHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmLicenseHistory";
            this.Load += new System.EventHandler(this.frmLicenseHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpLocalHistoryLicense.ResumeLayout(false);
            this.tpLocalHistoryLicense.PerformLayout();
            this.tpInternationalHistoryLicense.ResumeLayout(false);
            this.tpInternationalHistoryLicense.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private User_Control.ucFindPerson ucFindPerson1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpLocalHistoryLicense;
        private System.Windows.Forms.TabPage tpInternationalHistoryLicense;
        private User_Control.ucTemplateDGV ucTemplateDGV1_Local;
        private User_Control.ucTemplateDGV ucTemplateDGV1_international;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}