namespace DVLDSystem_WindowsForm_
{
    partial class frmSelectePerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectePerson));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchAPerson = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFinder = new System.Windows.Forms.ComboBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.ucPersonCard3 = new DVLDSystem_WindowsForm_.User_Control.ucPersonCard();
            this.btnAddPerson = new FontAwesome.Sharp.IconButton();
            this.btnSearchPerson = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(291, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find Person";
            // 
            // txtSearchAPerson
            // 
            this.txtSearchAPerson.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchAPerson.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSearchAPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchAPerson.HintForeColor = System.Drawing.Color.Empty;
            this.txtSearchAPerson.HintText = "Search For a Person";
            this.txtSearchAPerson.isPassword = false;
            this.txtSearchAPerson.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSearchAPerson.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSearchAPerson.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSearchAPerson.LineThickness = 3;
            this.txtSearchAPerson.Location = new System.Drawing.Point(253, 99);
            this.txtSearchAPerson.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchAPerson.Name = "txtSearchAPerson";
            this.txtSearchAPerson.Size = new System.Drawing.Size(358, 44);
            this.txtSearchAPerson.TabIndex = 2;
            this.txtSearchAPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label2.Location = new System.Drawing.Point(18, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Find By :";
            // 
            // cbFinder
            // 
            this.cbFinder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFinder.FormattingEnabled = true;
            this.cbFinder.Location = new System.Drawing.Point(115, 122);
            this.cbFinder.Name = "cbFinder";
            this.cbFinder.Size = new System.Drawing.Size(121, 21);
            this.cbFinder.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(637, 399);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 31);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ucPersonCard3
            // 
            this.ucPersonCard3.Address = "????";
            this.ucPersonCard3.Country = "????";
            this.ucPersonCard3.DateOfBirth = "????";
            this.ucPersonCard3.Email = "????";
            this.ucPersonCard3.Gendor = "???";
            this.ucPersonCard3.ID = "???";
            this.ucPersonCard3.Location = new System.Drawing.Point(2, 150);
            this.ucPersonCard3.Name = "ucPersonCard3";
            this.ucPersonCard3.NotionalNo = "?????";
            this.ucPersonCard3.PersonName = "Empty Name ";
            this.ucPersonCard3.Phone = "????";
            this.ucPersonCard3.Picture = ((System.Drawing.Image)(resources.GetObject("ucPersonCard3.Picture")));
            this.ucPersonCard3.PictureBackgroundLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucPersonCard3.Size = new System.Drawing.Size(761, 243);
            this.ucPersonCard3.TabIndex = 9;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.BackgroundImage = global::DVLDSystem_WindowsForm_.Properties.Resources.Add_User_Male_Skin_Type_7;
            this.btnAddPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddPerson.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAddPerson.IconColor = System.Drawing.Color.Black;
            this.btnAddPerson.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddPerson.Location = new System.Drawing.Point(683, 105);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(47, 38);
            this.btnAddPerson.TabIndex = 6;
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnSearchPerson
            // 
            this.btnSearchPerson.BackgroundImage = global::DVLDSystem_WindowsForm_.Properties.Resources.Find_User_Male;
            this.btnSearchPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchPerson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchPerson.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSearchPerson.IconColor = System.Drawing.Color.Black;
            this.btnSearchPerson.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchPerson.Location = new System.Drawing.Point(630, 105);
            this.btnSearchPerson.Name = "btnSearchPerson";
            this.btnSearchPerson.Size = new System.Drawing.Size(47, 38);
            this.btnSearchPerson.TabIndex = 5;
            this.btnSearchPerson.UseVisualStyleBackColor = true;
            this.btnSearchPerson.Click += new System.EventHandler(this.btnSearchPerson_Click);
            // 
            // frmSelectePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 437);
            this.Controls.Add(this.ucPersonCard3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.btnSearchPerson);
            this.Controls.Add(this.cbFinder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchAPerson);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmSelectePerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Find Person";
            this.Load += new System.EventHandler(this.frmSelectePerson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearchAPerson;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFinder;
        private FontAwesome.Sharp.IconButton btnSearchPerson;
        private FontAwesome.Sharp.IconButton btnAddPerson;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private User_Control.ucPersonCard ucPersonCard3;
    }
}