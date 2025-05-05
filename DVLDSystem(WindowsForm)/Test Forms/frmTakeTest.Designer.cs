namespace DVLDSystem_WindowsForm_.Test_Forms
{
    partial class frmTakeTest
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
            this.ucTestInfo1 = new DVLDSystem_WindowsForm_.User_Control.ucTestInfo();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.pbMainImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnPass = new System.Windows.Forms.RadioButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnFail = new System.Windows.Forms.RadioButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.gbTestType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTestType
            // 
            this.gbTestType.Controls.Add(this.ucTestInfo1);
            this.gbTestType.Controls.Add(this.lblHeaderTitle);
            this.gbTestType.Controls.Add(this.pbMainImage);
            this.gbTestType.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gbTestType.Location = new System.Drawing.Point(12, 4);
            this.gbTestType.Name = "gbTestType";
            this.gbTestType.Size = new System.Drawing.Size(504, 470);
            this.gbTestType.TabIndex = 1;
            this.gbTestType.TabStop = false;
            this.gbTestType.Text = "TestType";
            // 
            // ucTestInfo1
            // 
            this.ucTestInfo1.ApplicationPersonName = "???";
            this.ucTestInfo1.DateTest = "???";
            this.ucTestInfo1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.ucTestInfo1.LDLApplicationID = "???";
            this.ucTestInfo1.LicenseClasseName = "???";
            this.ucTestInfo1.Location = new System.Drawing.Point(8, 182);
            this.ucTestInfo1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ucTestInfo1.Name = "ucTestInfo1";
            this.ucTestInfo1.NumberOfRetakenTests = "???";
            this.ucTestInfo1.Size = new System.Drawing.Size(488, 280);
            this.ucTestInfo1.TabIndex = 3;
            this.ucTestInfo1.TestFee = "???";
            this.ucTestInfo1.TestID = "???";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Souvenir Lt BT", 23F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblHeaderTitle.Location = new System.Drawing.Point(128, 140);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(229, 38);
            this.lblHeaderTitle.TabIndex = 2;
            this.lblHeaderTitle.Text = "Schedule Test";
            // 
            // pbMainImage
            // 
            this.pbMainImage.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.driving_test_512;
            this.pbMainImage.Location = new System.Drawing.Point(180, 19);
            this.pbMainImage.Name = "pbMainImage";
            this.pbMainImage.Size = new System.Drawing.Size(124, 114);
            this.pbMainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMainImage.TabIndex = 1;
            this.pbMainImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(40, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Result:";
            // 
            // rbtnPass
            // 
            this.rbtnPass.AutoSize = true;
            this.rbtnPass.Checked = true;
            this.rbtnPass.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.rbtnPass.Location = new System.Drawing.Point(165, 486);
            this.rbtnPass.Name = "rbtnPass";
            this.rbtnPass.Size = new System.Drawing.Size(57, 21);
            this.rbtnPass.TabIndex = 3;
            this.rbtnPass.TabStop = true;
            this.rbtnPass.Text = "Pass";
            this.rbtnPass.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Number_32;
            this.pictureBox6.Location = new System.Drawing.Point(113, 479);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(35, 32);
            this.pictureBox6.TabIndex = 61;
            this.pictureBox6.TabStop = false;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(165, 523);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(344, 95);
            this.txtNote.TabIndex = 62;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Notes_32;
            this.pictureBox1.Location = new System.Drawing.Point(113, 523);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 32);
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(40, 530);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 63;
            this.label2.Text = "Notes:";
            // 
            // rbtnFail
            // 
            this.rbtnFail.AutoSize = true;
            this.rbtnFail.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.rbtnFail.Location = new System.Drawing.Point(234, 486);
            this.rbtnFail.Name = "rbtnFail";
            this.rbtnFail.Size = new System.Drawing.Size(48, 21);
            this.rbtnFail.TabIndex = 65;
            this.rbtnFail.Text = "Fail";
            this.rbtnFail.UseVisualStyleBackColor = true;
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
            this.btnClose.Location = new System.Drawing.Point(247, 635);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 38);
            this.btnClose.TabIndex = 67;
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
            this.btnSave.Location = new System.Drawing.Point(381, 635);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 38);
            this.btnSave.TabIndex = 66;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 685);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rbtnFail);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.rbtnPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbTestType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTakeTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTakeTest";
            this.Load += new System.EventHandler(this.frmTakeTest_Load);
            this.gbTestType.ResumeLayout(false);
            this.gbTestType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

     
        private System.Windows.Forms.GroupBox gbTestType;
        private System.Windows.Forms.PictureBox pbMainImage;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnPass;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnFail;
        private User_Control.ucTestInfo ucTestInfo1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
    }
}