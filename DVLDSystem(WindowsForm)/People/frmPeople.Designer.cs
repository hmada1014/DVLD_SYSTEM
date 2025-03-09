namespace DVLDSystem_WindowsForm_
{
    partial class frmPeople
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
            this.lblRecordsTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRrecords = new System.Windows.Forms.Label();
            this.ucTemplateDGVAndSearch = new DVLDSystem_WindowsForm_.User_Control.ucTemplateDGVAndSearch("frmPeople");
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecordsTitle
            // 
            this.lblRecordsTitle.AutoSize = true;
            this.lblRecordsTitle.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblRecordsTitle.Location = new System.Drawing.Point(6, 581);
            this.lblRecordsTitle.Name = "lblRecordsTitle";
            this.lblRecordsTitle.Size = new System.Drawing.Size(88, 19);
            this.lblRecordsTitle.TabIndex = 2;
            this.lblRecordsTitle.Text = "#Records :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.peopleBigSize;
            this.pictureBox1.Location = new System.Drawing.Point(377, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.addcontacts_83750;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(48, 48);
            this.guna2ImageButton1.Location = new System.Drawing.Point(833, 220);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(63, 55);
            this.guna2ImageButton1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(345, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Manage People";
            // 
            // lblRrecords
            // 
            this.lblRrecords.AutoSize = true;
            this.lblRrecords.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblRrecords.Location = new System.Drawing.Point(103, 582);
            this.lblRrecords.Name = "lblRrecords";
            this.lblRrecords.Size = new System.Drawing.Size(18, 19);
            this.lblRrecords.TabIndex = 6;
            this.lblRrecords.Text = "0";
            // 
            // ucSearchDGV1
            // 
            this.ucTemplateDGVAndSearch.Location = new System.Drawing.Point(0, 199);
            this.ucTemplateDGVAndSearch.Name = "ucSearchDGV1";
            this.ucTemplateDGVAndSearch.Size = new System.Drawing.Size(910, 377);
            this.ucTemplateDGVAndSearch.TabIndex = 3;
            // 
            // frmPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(908, 601);
            this.Controls.Add(this.lblRrecords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRecordsTitle);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.ucTemplateDGVAndSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "People";
            this.Load += new System.EventHandler(this.frmPeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label lblRecordsTitle;
        private User_Control.ucTemplateDGVAndSearch ucTemplateDGVAndSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRrecords;
    }
}