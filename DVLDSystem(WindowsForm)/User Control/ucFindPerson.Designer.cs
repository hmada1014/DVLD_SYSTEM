namespace DVLDSystem_WindowsForm_.User_Control
{
    partial class ucFindPerson
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddPerson = new FontAwesome.Sharp.IconButton();
            this.btnSearchPerson = new FontAwesome.Sharp.IconButton();
            this.cbFinder = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchAPerson = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ucPersonCard1 = new DVLDSystem_WindowsForm_.User_Control.ucPersonCard();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ucPersonCard1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(20, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(869, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Person Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddPerson);
            this.groupBox2.Controls.Add(this.btnSearchPerson);
            this.groupBox2.Controls.Add(this.cbFinder);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSearchAPerson);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(20, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(844, 72);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.BackgroundImage = global::DVLDSystem_WindowsForm_.Properties.Resources.AddPerson_32;
            this.btnAddPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddPerson.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAddPerson.IconColor = System.Drawing.Color.Black;
            this.btnAddPerson.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddPerson.Location = new System.Drawing.Point(731, 20);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(47, 38);
            this.btnAddPerson.TabIndex = 11;
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnSearchPerson
            // 
            this.btnSearchPerson.BackgroundImage = global::DVLDSystem_WindowsForm_.Properties.Resources.SearchPerson;
            this.btnSearchPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchPerson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchPerson.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSearchPerson.IconColor = System.Drawing.Color.Black;
            this.btnSearchPerson.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchPerson.Location = new System.Drawing.Point(678, 20);
            this.btnSearchPerson.Name = "btnSearchPerson";
            this.btnSearchPerson.Size = new System.Drawing.Size(47, 38);
            this.btnSearchPerson.TabIndex = 10;
            this.btnSearchPerson.UseVisualStyleBackColor = true;
            this.btnSearchPerson.Click += new System.EventHandler(this.btnSearchPerson_Click);
            // 
            // cbFinder
            // 
            this.cbFinder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFinder.FormattingEnabled = true;
            this.cbFinder.Location = new System.Drawing.Point(163, 37);
            this.cbFinder.Name = "cbFinder";
            this.cbFinder.Size = new System.Drawing.Size(121, 21);
            this.cbFinder.TabIndex = 9;
            this.cbFinder.SelectedIndexChanged += new System.EventHandler(this.cbFinder_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label2.Location = new System.Drawing.Point(66, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Find By :";
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
            this.txtSearchAPerson.Location = new System.Drawing.Point(301, 14);
            this.txtSearchAPerson.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchAPerson.Name = "txtSearchAPerson";
            this.txtSearchAPerson.Size = new System.Drawing.Size(358, 44);
            this.txtSearchAPerson.TabIndex = 7;
            this.txtSearchAPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchAPerson.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchAPerson_KeyPress);
            // 
            // ucPersonCard1
            // 
            this.ucPersonCard1.Address = "[????]";
            this.ucPersonCard1.Country = "[????]";
            this.ucPersonCard1.DateOfBirth = "[????]";
            this.ucPersonCard1.Email = "[????]";
            this.ucPersonCard1.Gendor = "[????]";
            this.ucPersonCard1.ID = "[????]";
            this.ucPersonCard1.Location = new System.Drawing.Point(12, 27);
            this.ucPersonCard1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ucPersonCard1.Name = "ucPersonCard1";
            this.ucPersonCard1.NotionalNo = "[????]";
            this.ucPersonCard1.PersonName = "Empty Name ";
            this.ucPersonCard1.Phone = "[????]";
            this.ucPersonCard1.Picture = null;
            this.ucPersonCard1.PictureBackgroundLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucPersonCard1.Size = new System.Drawing.Size(857, 238);
            this.ucPersonCard1.TabIndex = 0;
            // 
            // ucFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucFindPerson";
            this.Size = new System.Drawing.Size(902, 382);
            this.Load += new System.EventHandler(this.ucFindPerson_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btnAddPerson;
        private FontAwesome.Sharp.IconButton btnSearchPerson;
        private System.Windows.Forms.ComboBox cbFinder;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearchAPerson;
        private ucPersonCard ucPersonCard1;
    }
}
