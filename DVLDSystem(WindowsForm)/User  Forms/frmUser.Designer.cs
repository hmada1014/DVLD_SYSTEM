namespace DVLDSystem_WindowsForm_.User
{
    partial class frmUser
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
            this.btnAddUser = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ucTemplateDGVAndSearch2 = new DVLDSystem_WindowsForm_.User_Control.ucTemplateDGVAndSearch("frmUsers");
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(290, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Manage Users";
            // 
            // btnAddUser
            // 
            this.btnAddUser.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddUser.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddUser.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddUser.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Add_New_User_72;
            this.btnAddUser.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAddUser.ImageRotate = 0F;
            this.btnAddUser.ImageSize = new System.Drawing.Size(48, 48);
            this.btnAddUser.Location = new System.Drawing.Point(697, 223);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddUser.Size = new System.Drawing.Size(63, 55);
            this.btnAddUser.TabIndex = 8;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Users_2_400;
            this.pictureBox1.Location = new System.Drawing.Point(314, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ucTemplateDGVAndSearch2
            // 
            this.ucTemplateDGVAndSearch2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ucTemplateDGVAndSearch2.dgvAutoSizeColumnMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ucTemplateDGVAndSearch2.dgvAutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.None;
            this.ucTemplateDGVAndSearch2.dgvBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ucTemplateDGVAndSearch2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucTemplateDGVAndSearch2.Location = new System.Drawing.Point(0, 206);
            this.ucTemplateDGVAndSearch2.Name = "ucTemplateDGVAndSearch2";
            this.ucTemplateDGVAndSearch2.Size = new System.Drawing.Size(785, 395);
            this.ucTemplateDGVAndSearch2.TabIndex = 7;
            this.ucTemplateDGVAndSearch2.TextBoxLocation = new System.Drawing.Point(320, 21);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 601);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.ucTemplateDGVAndSearch2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUser";
            this.Load += new System.EventHandler(this.frmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private User_Control.ucTemplateDGVAndSearch ucTemplateDGVAndSearch2;
        private Guna.UI2.WinForms.Guna2ImageButton btnAddUser;
    }
}