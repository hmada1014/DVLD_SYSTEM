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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddPerson = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ucTemplateDGVAndSearch1 = new DVLDSystem_WindowsForm_.User_Control.ucTemplateDGVAndSearch("frmPeople");
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(476, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Manage People";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DVLDSystem_WindowsForm_.Properties.Resources.People_400;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(508, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddPerson.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddPerson.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddPerson.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Add_Person_40;
            this.btnAddPerson.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAddPerson.ImageRotate = 0F;
            this.btnAddPerson.ImageSize = new System.Drawing.Size(48, 48);
            this.btnAddPerson.Location = new System.Drawing.Point(1061, 208);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddPerson.Size = new System.Drawing.Size(63, 55);
            this.btnAddPerson.TabIndex = 1;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // ucTemplateDGVAndSearch1
            // 
            this.ucTemplateDGVAndSearch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ucTemplateDGVAndSearch1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucTemplateDGVAndSearch1.Location = new System.Drawing.Point(0, 194);
            this.ucTemplateDGVAndSearch1.Name = "ucTemplateDGVAndSearch1";
            this.ucTemplateDGVAndSearch1.Size = new System.Drawing.Size(1172, 395);
            this.ucTemplateDGVAndSearch1.TabIndex = 6;
            // 
            // frmPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1172, 589);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.ucTemplateDGVAndSearch1);
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
        private Guna.UI2.WinForms.Guna2ImageButton btnAddPerson;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private User_Control.ucTemplateDGVAndSearch ucTemplateDGVAndSearch1;
    }
}