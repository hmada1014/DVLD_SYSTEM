namespace DVLDSystem_WindowsForm_.Test_Forms
{
    partial class frmScheduleTest
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
            this.gbTestType = new System.Windows.Forms.GroupBox();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.pbMainImage = new System.Windows.Forms.PictureBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.lblMessageForLoackedAppointment = new System.Windows.Forms.Label();
            this.ucRetakeTest1 = new DVLDSystem_WindowsForm_.User_Control.ucRetakeTest();
            this.ucTestAppointment1 = new DVLDSystem_WindowsForm_.User_Control.ucTestAppointment();
            this.gbTestType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTestType
            // 
            this.gbTestType.Controls.Add(this.lblHeaderTitle);
            this.gbTestType.Controls.Add(this.lblMessageForLoackedAppointment);
            this.gbTestType.Controls.Add(this.ucTestAppointment1);
            this.gbTestType.Controls.Add(this.pbMainImage);
            this.gbTestType.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gbTestType.Location = new System.Drawing.Point(13, 3);
            this.gbTestType.Name = "gbTestType";
            this.gbTestType.Size = new System.Drawing.Size(504, 458);
            this.gbTestType.TabIndex = 0;
            this.gbTestType.TabStop = false;
            this.gbTestType.Text = "Vision Test";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Souvenir Lt BT", 23F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblHeaderTitle.Location = new System.Drawing.Point(61, 140);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(344, 38);
            this.lblHeaderTitle.TabIndex = 1;
            this.lblHeaderTitle.Text = "Schedule Retake Test";
            // 
            // pbMainImage
            // 
            this.pbMainImage.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.driving_test_512;
            this.pbMainImage.Location = new System.Drawing.Point(171, 23);
            this.pbMainImage.Name = "pbMainImage";
            this.pbMainImage.Size = new System.Drawing.Size(124, 114);
            this.pbMainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMainImage.TabIndex = 0;
            this.pbMainImage.TabStop = false;
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
            this.btnClose.Location = new System.Drawing.Point(195, 640);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 38);
            this.btnClose.TabIndex = 42;
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
            this.btnSave.Location = new System.Drawing.Point(375, 593);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 38);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblMessageForLoackedAppointment
            // 
            this.lblMessageForLoackedAppointment.AutoSize = true;
            this.lblMessageForLoackedAppointment.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.lblMessageForLoackedAppointment.ForeColor = System.Drawing.Color.Maroon;
            this.lblMessageForLoackedAppointment.Location = new System.Drawing.Point(7, 187);
            this.lblMessageForLoackedAppointment.Name = "lblMessageForLoackedAppointment";
            this.lblMessageForLoackedAppointment.Size = new System.Drawing.Size(483, 22);
            this.lblMessageForLoackedAppointment.TabIndex = 3;
            this.lblMessageForLoackedAppointment.Text = "Person already sat for the test, appointment loacked";
            this.lblMessageForLoackedAppointment.Visible = false;
            // 
            // ucRetakeTest1
            // 
            this.ucRetakeTest1.Enabled = false;
            this.ucRetakeTest1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.ucRetakeTest1.Location = new System.Drawing.Point(13, 468);
            this.ucRetakeTest1.Margin = new System.Windows.Forms.Padding(4);
            this.ucRetakeTest1.Name = "ucRetakeTest1";
            this.ucRetakeTest1.Size = new System.Drawing.Size(514, 120);
            this.ucRetakeTest1.TabIndex = 43;
            // 
            // ucTestAppointment1
            // 
            this.ucTestAppointment1.ApplicationPersonName = "???";
            this.ucTestAppointment1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.ucTestAppointment1.LDLApplicationID = "???";
            this.ucTestAppointment1.LicenseClasseName = "???";
            this.ucTestAppointment1.Location = new System.Drawing.Point(8, 206);
            this.ucTestAppointment1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ucTestAppointment1.Name = "ucTestAppointment1";
            this.ucTestAppointment1.NumberOfRetakenTests = "???";
            this.ucTestAppointment1.Size = new System.Drawing.Size(506, 246);
            this.ucTestAppointment1.TabIndex = 2;
            this.ucTestAppointment1.TestFee = "???";
            // 
            // frmScheduelTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 685);
            this.Controls.Add(this.ucRetakeTest1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbTestType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmScheduelTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmScheduelTest";
            this.Load += new System.EventHandler(this.frmScheduleTest_Load);
            this.gbTestType.ResumeLayout(false);
            this.gbTestType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTestType;
        private System.Windows.Forms.PictureBox pbMainImage;
        private System.Windows.Forms.Label lblHeaderTitle;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private User_Control.ucTestAppointment ucTestAppointment1;
        private User_Control.ucRetakeTest ucRetakeTest1;
        private System.Windows.Forms.Label lblMessageForLoackedAppointment;
    }
}