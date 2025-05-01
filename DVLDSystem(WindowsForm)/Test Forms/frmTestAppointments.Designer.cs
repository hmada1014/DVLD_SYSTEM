namespace DVLDSystem_WindowsForm_.Test_Forms
{
    partial class frmTestAppointments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

    
       
        /*
         switch (TestType)
            {
                case "VisionTest":
                    this.ucTemplateDGV1 = new DVLDSystem_WindowsForm_.User_Control.ucTemplateDGV("frmVisionTestAppointments");
                    break;
                case "WritingTest":
                    this.ucTemplateDGV1 = new DVLDSystem_WindowsForm_.User_Control.ucTemplateDGV("frmWritingTestAppointments");
                    break;
                case "StreetTest":
                    this.ucTemplateDGV1 = new DVLDSystem_WindowsForm_.User_Control.ucTemplateDGV("frmStreetTestAppointments");
                    break;
                default:
                    this.ucTemplateDGV1 = new DVLDSystem_WindowsForm_.User_Control.ucTemplateDGV();
                    break;
            }*/
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

        
        private void InitializeTestMode(string TestType) 
        {
            this.lblTestType = new System.Windows.Forms.Label();

            switch (TestType)
            {

                case "VisionTest":
                    this.lblTestType.Text = "frmVisionTestAppointments";
                    break;
                case "WritingTest":
                    this.lblTestType.Text = "frmWritingTestAppointments";
                    break;
                case "StreetTest":
                    this.lblTestType.Text = "frmStreetTestAppointments";
                    break;
                default:
                    this.lblTestType.Text = "";
                    break;
            }
            
        }

        private void InitializeComponent()
        {

            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddnewVisionTestAppointment = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ucApplicationBasicInfo1 = new DVLDSystem_WindowsForm_.User_Control.ucApplicationBasicInfo();
            this.ucDrivingLicenseApplicationInfo1 = new DVLDSystem_WindowsForm_.User_Control.ucDrivingLicenseApplicationInfo();
            this.ucTemplateDGV1 = new DVLDSystem_WindowsForm_.User_Control.ucTemplateDGV(this.lblTestType.Text);
            this.lblTestType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Vision_512;
            this.pictureBox1.Location = new System.Drawing.Point(426, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Souvenir Lt BT", 25F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.Brown;
            this.lblHeaderTitle.Location = new System.Drawing.Point(251, 84);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(447, 42);
            this.lblHeaderTitle.TabIndex = 1;
            this.lblHeaderTitle.Text = "Vision Test Appointments";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnClose.Location = new System.Drawing.Point(785, 720);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 38);
            this.btnClose.TabIndex = 46;
            this.btnClose.Text = "close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(29, 526);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 48;
            this.label1.Text = "Appointments:";
            // 
            // btnAddnewVisionTestAppointment
            // 
            this.btnAddnewVisionTestAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddnewVisionTestAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddnewVisionTestAppointment.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddnewVisionTestAppointment.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddnewVisionTestAppointment.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddnewVisionTestAppointment.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.AddAppointment_32;
            this.btnAddnewVisionTestAppointment.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAddnewVisionTestAppointment.ImageRotate = 0F;
            this.btnAddnewVisionTestAppointment.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddnewVisionTestAppointment.Location = new System.Drawing.Point(872, 516);
            this.btnAddnewVisionTestAppointment.Name = "btnAddnewVisionTestAppointment";
            this.btnAddnewVisionTestAppointment.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddnewVisionTestAppointment.Size = new System.Drawing.Size(39, 37);
            this.btnAddnewVisionTestAppointment.TabIndex = 50;
            this.btnAddnewVisionTestAppointment.Click += new System.EventHandler(this.btnAddNewTestAppointment_Click);
            // 
            // ucApplicationBasicInfo1
            // 
            this.ucApplicationBasicInfo1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucApplicationBasicInfo1.Location = new System.Drawing.Point(17, 271);
            this.ucApplicationBasicInfo1.Name = "ucApplicationBasicInfo1";
            this.ucApplicationBasicInfo1.Size = new System.Drawing.Size(909, 239);
            this.ucApplicationBasicInfo1.TabIndex = 3;
            // 
            // ucDrivingLicenseApplicationInfo1
            // 
            this.ucDrivingLicenseApplicationInfo1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(17, 133);
            this.ucDrivingLicenseApplicationInfo1.Name = "ucDrivingLicenseApplicationInfo1";
            this.ucDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(909, 128);
            this.ucDrivingLicenseApplicationInfo1.TabIndex = 2;
            // 
            // lblTestType
            // 
            this.lblTestType.AutoSize = true;
            this.lblTestType.Location = new System.Drawing.Point(12, 4);
            this.lblTestType.Name = "lblTestType";
            this.lblTestType.Size = new System.Drawing.Size(13, 13);
            this.lblTestType.TabIndex = 51;
            this.lblTestType.Text = "2";
            this.lblTestType.Visible = false;
            // 
            // ucTemplateDGV1
            // 
            this.ucTemplateDGV1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucTemplateDGV1.dgvColor = System.Drawing.SystemColors.AppWorkspace;
            this.ucTemplateDGV1.dgvSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.ucTemplateDGV1.Location = new System.Drawing.Point(33, 548);
            this.ucTemplateDGV1.Name = "ucTemplateDGV1";
            this.ucTemplateDGV1.Size = new System.Drawing.Size(880, 197);
            this.ucTemplateDGV1.TabIndex = 49;
            // 
            // frmTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(959, 770);
            this.Controls.Add(this.lblHeaderTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucApplicationBasicInfo1);
            this.Controls.Add(this.ucDrivingLicenseApplicationInfo1);
            this.Controls.Add(this.ucTemplateDGV1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTestType);
            this.Controls.Add(this.btnAddnewVisionTestAppointment);
            this.Name = "frmTestAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmVisionTestAppointments";
            this.Load += new System.EventHandler(this.frmTestAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();


        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHeaderTitle;
        private User_Control.ucTemplateDGV ucTemplateDGV1;
        private User_Control.ucDrivingLicenseApplicationInfo ucDrivingLicenseApplicationInfo1;
        private User_Control.ucApplicationBasicInfo ucApplicationBasicInfo1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton btnAddnewVisionTestAppointment;
        private System.Windows.Forms.Label lblTestType;
    }
}