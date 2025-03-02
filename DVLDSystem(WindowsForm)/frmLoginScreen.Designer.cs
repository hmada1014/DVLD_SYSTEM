namespace DVLDSystem_WindowsForm_
{
    partial class frmLoginScreen
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
            this.ibtnClose = new FontAwesome.Sharp.IconButton();
            this.rPlTop = new DVLDSystem_WindowsForm_.RoundedPanel();
            this.rPlLeft = new DVLDSystem_WindowsForm_.RoundedPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ibtnClose
            // 
            this.ibtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.ibtnClose.FlatAppearance.BorderSize = 0;
            this.ibtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnClose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.ibtnClose.IconColor = System.Drawing.Color.White;
            this.ibtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnClose.IconSize = 30;
            this.ibtnClose.Location = new System.Drawing.Point(909, 2);
            this.ibtnClose.Name = "ibtnClose";
            this.ibtnClose.Size = new System.Drawing.Size(20, 28);
            this.ibtnClose.TabIndex = 5;
            this.ibtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ibtnClose.UseVisualStyleBackColor = false;
            this.ibtnClose.Click += new System.EventHandler(this.ibtnClose_Click);
            // 
            // rPlTop
            // 
            this.rPlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.rPlTop.BottomLeftRadius = 0;
            this.rPlTop.BottomRightRadius = 0;
            this.rPlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.rPlTop.Location = new System.Drawing.Point(0, 0);
            this.rPlTop.Name = "rPlTop";
            this.rPlTop.Size = new System.Drawing.Size(937, 32);
            this.rPlTop.TabIndex = 4;
            this.rPlTop.TopLeftRadius = 0;
            this.rPlTop.TopRightRadius = 0;
            this.rPlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rPlTop_MouseDown);
            this.rPlTop.MouseLeave += new System.EventHandler(this.rPlTop_MouseLeave);
            this.rPlTop.MouseHover += new System.EventHandler(this.rPlTop_MouseHover);
            // 
            // rPlLeft
            // 
            this.rPlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.rPlLeft.BottomLeftRadius = 0;
            this.rPlLeft.BottomRightRadius = 0;
            this.rPlLeft.Location = new System.Drawing.Point(0, 29);
            this.rPlLeft.Name = "rPlLeft";
            this.rPlLeft.Size = new System.Drawing.Size(243, 433);
            this.rPlLeft.TabIndex = 3;
            this.rPlLeft.TopLeftRadius = 0;
            this.rPlLeft.TopRightRadius = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(484, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(469, 179);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(586, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmLoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(205)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(937, 462);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ibtnClose);
            this.Controls.Add(this.rPlTop);
            this.Controls.Add(this.rPlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoginScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundedPanel rPlLeft;
        private RoundedPanel rPlTop;
        private FontAwesome.Sharp.IconButton ibtnClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}