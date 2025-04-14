namespace DVLDSystem_WindowsForm_.People__Forms
{
    partial class frmShowPersonDetails
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ucPersonCard1 = new DVLDSystem_WindowsForm_.User_Control.ucPersonCard();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ucPersonCard1);
            this.groupBox1.Location = new System.Drawing.Point(12, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 271);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Person Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Souvenir Lt BT", 37F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(229, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Person Details";
            // 
            // ucPersonCard1
            // 
            this.ucPersonCard1.Address = "[????]";
            this.ucPersonCard1.Country = "[????]";
            this.ucPersonCard1.DateOfBirth = "[????]";
            this.ucPersonCard1.Email = "[????]";
            this.ucPersonCard1.Gendor = "[????]";
            this.ucPersonCard1.ID = "[????]";
            this.ucPersonCard1.Location = new System.Drawing.Point(6, 16);
            this.ucPersonCard1.Name = "ucPersonCard1";
            this.ucPersonCard1.NotionalNo = "[????]";
            this.ucPersonCard1.PersonName = "Empty Name ";
            this.ucPersonCard1.Phone = "[????]";
            this.ucPersonCard1.Picture = null;
            this.ucPersonCard1.PictureBackgroundLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucPersonCard1.Size = new System.Drawing.Size(814, 238);
            this.ucPersonCard1.TabIndex = 0;
            // 
            // frmShowPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 363);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmShowPersonDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Person Details";
            this.Load += new System.EventHandler(this.frmShowPersonDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private User_Control.ucPersonCard ucPersonCard1;
        private System.Windows.Forms.Label label1;
    }
}