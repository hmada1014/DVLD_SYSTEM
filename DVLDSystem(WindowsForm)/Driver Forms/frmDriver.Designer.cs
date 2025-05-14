namespace DVLDSystem_WindowsForm_.Driver_Forms
{
    partial class frmDriver
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
            this.ucTemplateDGVAndSearch1 = new DVLDSystem_WindowsForm_.User_Control.ucTemplateDGVAndSearch("frmDrivers");
            this.pbMainImge = new System.Windows.Forms.PictureBox();
            this.lblMainHeadar = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainImge)).BeginInit();
            this.SuspendLayout();
            // 
            // ucTemplateDGVAndSearch1
            // 
            this.ucTemplateDGVAndSearch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ucTemplateDGVAndSearch1.dgvAutoSizeColumnMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ucTemplateDGVAndSearch1.dgvAutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.None;
            this.ucTemplateDGVAndSearch1.dgvBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ucTemplateDGVAndSearch1.dgvColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ucTemplateDGVAndSearch1.Location = new System.Drawing.Point(2, 202);
            this.ucTemplateDGVAndSearch1.Name = "ucTemplateDGVAndSearch1";
            this.ucTemplateDGVAndSearch1.Size = new System.Drawing.Size(872, 429);
            this.ucTemplateDGVAndSearch1.TabIndex = 0;
            this.ucTemplateDGVAndSearch1.TextBoxLocation = new System.Drawing.Point(300, 21);
            // 
            // pbMainImge
            // 
            this.pbMainImge.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Driver_Main;
            this.pbMainImge.Location = new System.Drawing.Point(337, 12);
            this.pbMainImge.Name = "pbMainImge";
            this.pbMainImge.Size = new System.Drawing.Size(246, 162);
            this.pbMainImge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMainImge.TabIndex = 1;
            this.pbMainImge.TabStop = false;
            // 
            // lblMainHeadar
            // 
            this.lblMainHeadar.AutoSize = true;
            this.lblMainHeadar.Font = new System.Drawing.Font("Souvenir Lt BT", 20F, System.Drawing.FontStyle.Bold);
            this.lblMainHeadar.ForeColor = System.Drawing.Color.Maroon;
            this.lblMainHeadar.Location = new System.Drawing.Point(351, 177);
            this.lblMainHeadar.Name = "lblMainHeadar";
            this.lblMainHeadar.Size = new System.Drawing.Size(218, 33);
            this.lblMainHeadar.TabIndex = 2;
            this.lblMainHeadar.Text = "Manege Drivers";
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
            this.btnClose.Location = new System.Drawing.Point(707, 626);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 38);
            this.btnClose.TabIndex = 39;
            this.btnClose.Text = "close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 674);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblMainHeadar);
            this.Controls.Add(this.pbMainImge);
            this.Controls.Add(this.ucTemplateDGVAndSearch1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDriver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDriver";
            this.Load += new System.EventHandler(this.frmDriver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMainImge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private User_Control.ucTemplateDGVAndSearch ucTemplateDGVAndSearch1;
        private System.Windows.Forms.PictureBox pbMainImge;
        private System.Windows.Forms.Label lblMainHeadar;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}