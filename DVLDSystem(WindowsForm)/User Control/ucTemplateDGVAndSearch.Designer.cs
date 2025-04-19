namespace DVLDSystem_WindowsForm_.User_Control
{
    partial class ucTemplateDGVAndSearch
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbFindBy = new System.Windows.Forms.ComboBox();
            this.lblFindBy = new System.Windows.Forms.Label();
            this.dgvShowList = new System.Windows.Forms.DataGridView();
            this.cmsEditDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMShowDetailsGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMAddNewGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMEditGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMDeleteGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMRefreshGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.TSSchangePassword = new System.Windows.Forms.ToolStripSeparator();
            this.TSMSendEmailGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMPhoneCallGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearchDGV = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblRrecords = new System.Windows.Forms.Label();
            this.lblRecordsTitle = new System.Windows.Forms.Label();
            this.cbGeneral = new System.Windows.Forms.ComboBox();
            this.btnRefreshDGV = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowList)).BeginInit();
            this.cmsEditDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefreshDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFindBy
            // 
            this.cbFindBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbFindBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFindBy.FormattingEnabled = true;
            this.cbFindBy.Location = new System.Drawing.Point(108, 29);
            this.cbFindBy.Name = "cbFindBy";
            this.cbFindBy.Size = new System.Drawing.Size(134, 21);
            this.cbFindBy.TabIndex = 0;
            this.cbFindBy.SelectedIndexChanged += new System.EventHandler(this.cbFindBy_SelectedIndexChanged);
            // 
            // lblFindBy
            // 
            this.lblFindBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFindBy.AutoSize = true;
            this.lblFindBy.Font = new System.Drawing.Font("Tahoma", 13F);
            this.lblFindBy.Location = new System.Drawing.Point(27, 28);
            this.lblFindBy.Name = "lblFindBy";
            this.lblFindBy.Size = new System.Drawing.Size(75, 22);
            this.lblFindBy.TabIndex = 1;
            this.lblFindBy.Text = "Find By ";
            // 
            // dgvShowList
            // 
            this.dgvShowList.AllowUserToAddRows = false;
            this.dgvShowList.AllowUserToDeleteRows = false;
            this.dgvShowList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(204)))), ((int)(((byte)(197)))));
            this.dgvShowList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShowList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShowList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvShowList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShowList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowList.ContextMenuStrip = this.cmsEditDelete;
            this.dgvShowList.EnableHeadersVisualStyles = false;
            this.dgvShowList.GridColor = System.Drawing.Color.Black;
            this.dgvShowList.Location = new System.Drawing.Point(0, 78);
            this.dgvShowList.Name = "dgvShowList";
            this.dgvShowList.ReadOnly = true;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgvShowList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvShowList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowList.Size = new System.Drawing.Size(651, 290);
            this.dgvShowList.TabIndex = 2;
            this.dgvShowList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowList_ShowDeitails_CellDoubleClick);
            // 
            // cmsEditDelete
            // 
            this.cmsEditDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMShowDetailsGeneral,
            this.toolStripMenuItem1,
            this.TSMAddNewGeneral,
            this.TSMEditGeneral,
            this.TSMDeleteGeneral,
            this.TSMRefreshGeneral,
            this.toolStripSeparator1,
            this.TSMChangePassword,
            this.TSSchangePassword,
            this.TSMSendEmailGeneral,
            this.TSMPhoneCallGeneral});
            this.cmsEditDelete.Name = "cmsAddEdit";
            this.cmsEditDelete.Size = new System.Drawing.Size(185, 326);
            this.cmsEditDelete.Opening += new System.ComponentModel.CancelEventHandler(this.cmsEditDelete_opening);
            // 
            // TSMShowDetailsGeneral
            // 
            this.TSMShowDetailsGeneral.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.PersonDetails_32;
            this.TSMShowDetailsGeneral.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMShowDetailsGeneral.Name = "TSMShowDetailsGeneral";
            this.TSMShowDetailsGeneral.Size = new System.Drawing.Size(184, 38);
            this.TSMShowDetailsGeneral.Text = "Show Details";
            this.TSMShowDetailsGeneral.Click += new System.EventHandler(this.TSMShowDetailsGeneral_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 6);
            // 
            // TSMAddNewGeneral
            // 
            this.TSMAddNewGeneral.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.AddPerson_32;
            this.TSMAddNewGeneral.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMAddNewGeneral.Name = "TSMAddNewGeneral";
            this.TSMAddNewGeneral.Size = new System.Drawing.Size(184, 38);
            this.TSMAddNewGeneral.Text = "Add new ";
            this.TSMAddNewGeneral.Click += new System.EventHandler(this.TSMAddNewGeneral_Click);
            // 
            // TSMEditGeneral
            // 
            this.TSMEditGeneral.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Edit_32_1;
            this.TSMEditGeneral.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMEditGeneral.Name = "TSMEditGeneral";
            this.TSMEditGeneral.Size = new System.Drawing.Size(184, 38);
            this.TSMEditGeneral.Text = "Edit";
            this.TSMEditGeneral.Click += new System.EventHandler(this.EditGeneral_Click);
            // 
            // TSMDeleteGeneral
            // 
            this.TSMDeleteGeneral.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.delete;
            this.TSMDeleteGeneral.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMDeleteGeneral.Name = "TSMDeleteGeneral";
            this.TSMDeleteGeneral.Size = new System.Drawing.Size(184, 38);
            this.TSMDeleteGeneral.Text = "Delete";
            this.TSMDeleteGeneral.Click += new System.EventHandler(this.DeleteGeneral_Click);
            // 
            // TSMRefreshGeneral
            // 
            this.TSMRefreshGeneral.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Refresh_32;
            this.TSMRefreshGeneral.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMRefreshGeneral.Name = "TSMRefreshGeneral";
            this.TSMRefreshGeneral.Size = new System.Drawing.Size(184, 38);
            this.TSMRefreshGeneral.Text = "Refresh";
            this.TSMRefreshGeneral.Click += new System.EventHandler(this.TSM_Refresh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // TSMChangePassword
            // 
            this.TSMChangePassword.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Password_32;
            this.TSMChangePassword.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMChangePassword.Name = "TSMChangePassword";
            this.TSMChangePassword.Size = new System.Drawing.Size(184, 38);
            this.TSMChangePassword.Text = "Change Password";
            this.TSMChangePassword.Visible = false;
            this.TSMChangePassword.Click += new System.EventHandler(this.TSMChangePassword_Click);
            // 
            // TSSchangePassword
            // 
            this.TSSchangePassword.Name = "TSSchangePassword";
            this.TSSchangePassword.Size = new System.Drawing.Size(181, 6);
            this.TSSchangePassword.Visible = false;
            // 
            // TSMSendEmailGeneral
            // 
            this.TSMSendEmailGeneral.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.send_email_32;
            this.TSMSendEmailGeneral.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMSendEmailGeneral.Name = "TSMSendEmailGeneral";
            this.TSMSendEmailGeneral.Size = new System.Drawing.Size(184, 38);
            this.TSMSendEmailGeneral.Text = "Send Email";
            this.TSMSendEmailGeneral.Click += new System.EventHandler(this.TSMSendEmailGeneral_Click);
            // 
            // TSMPhoneCallGeneral
            // 
            this.TSMPhoneCallGeneral.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.call_32;
            this.TSMPhoneCallGeneral.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMPhoneCallGeneral.Name = "TSMPhoneCallGeneral";
            this.TSMPhoneCallGeneral.Size = new System.Drawing.Size(184, 38);
            this.TSMPhoneCallGeneral.Text = "Phone Call";
            this.TSMPhoneCallGeneral.Click += new System.EventHandler(this.TSMPhoneCallGeneral_Click);
            // 
            // txtSearchDGV
            // 
            this.txtSearchDGV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearchDGV.BorderRadius = 10;
            this.txtSearchDGV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchDGV.DefaultText = "";
            this.txtSearchDGV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchDGV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchDGV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchDGV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchDGV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchDGV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchDGV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchDGV.Location = new System.Drawing.Point(265, 21);
            this.txtSearchDGV.Name = "txtSearchDGV";
            this.txtSearchDGV.PasswordChar = '\0';
            this.txtSearchDGV.PlaceholderText = "";
            this.txtSearchDGV.SelectedText = "";
            this.txtSearchDGV.Size = new System.Drawing.Size(310, 36);
            this.txtSearchDGV.TabIndex = 3;
            this.txtSearchDGV.TextChanged += new System.EventHandler(this._txtSearchDGV_TextChanged);
            this.txtSearchDGV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchDGV_KeyPress);
            // 
            // lblRrecords
            // 
            this.lblRrecords.AutoSize = true;
            this.lblRrecords.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblRrecords.Location = new System.Drawing.Point(105, 372);
            this.lblRrecords.Name = "lblRrecords";
            this.lblRrecords.Size = new System.Drawing.Size(18, 19);
            this.lblRrecords.TabIndex = 8;
            this.lblRrecords.Text = "0";
            // 
            // lblRecordsTitle
            // 
            this.lblRecordsTitle.AutoSize = true;
            this.lblRecordsTitle.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblRecordsTitle.Location = new System.Drawing.Point(8, 371);
            this.lblRecordsTitle.Name = "lblRecordsTitle";
            this.lblRecordsTitle.Size = new System.Drawing.Size(88, 19);
            this.lblRecordsTitle.TabIndex = 7;
            this.lblRecordsTitle.Text = "#Records :";
            // 
            // cbGeneral
            // 
            this.cbGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbGeneral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGeneral.FormattingEnabled = true;
            this.cbGeneral.Location = new System.Drawing.Point(281, 29);
            this.cbGeneral.Name = "cbGeneral";
            this.cbGeneral.Size = new System.Drawing.Size(134, 21);
            this.cbGeneral.TabIndex = 9;
            this.cbGeneral.Visible = false;
            this.cbGeneral.SelectedIndexChanged += new System.EventHandler(this.cbGendor_SelectedIndexChanged);
            // 
            // btnRefreshDGV
            // 
            this.btnRefreshDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshDGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnRefreshDGV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRefreshDGV.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            this.btnRefreshDGV.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnRefreshDGV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefreshDGV.IconSize = 27;
            this.btnRefreshDGV.Location = new System.Drawing.Point(616, 368);
            this.btnRefreshDGV.Name = "btnRefreshDGV";
            this.btnRefreshDGV.Size = new System.Drawing.Size(35, 27);
            this.btnRefreshDGV.TabIndex = 4;
            this.btnRefreshDGV.TabStop = false;
            this.btnRefreshDGV.Click += new System.EventHandler(this.btnRefreshDGV_Click);
            // 
            // ucTemplateDGVAndSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.cbGeneral);
            this.Controls.Add(this.lblRrecords);
            this.Controls.Add(this.lblRecordsTitle);
            this.Controls.Add(this.btnRefreshDGV);
            this.Controls.Add(this.txtSearchDGV);
            this.Controls.Add(this.dgvShowList);
            this.Controls.Add(this.lblFindBy);
            this.Controls.Add(this.cbFindBy);
            this.Name = "ucTemplateDGVAndSearch";
            this.Size = new System.Drawing.Size(651, 395);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowList)).EndInit();
            this.cmsEditDelete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRefreshDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFindBy;
        private System.Windows.Forms.Label lblFindBy;
        private System.Windows.Forms.DataGridView dgvShowList;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchDGV;
        private FontAwesome.Sharp.IconPictureBox btnRefreshDGV;
        private System.Windows.Forms.Label lblRrecords;
        private System.Windows.Forms.Label lblRecordsTitle;
        private System.Windows.Forms.ContextMenuStrip cmsEditDelete;
        private System.Windows.Forms.ToolStripMenuItem TSMEditGeneral;
        private System.Windows.Forms.ToolStripMenuItem TSMDeleteGeneral;
        private System.Windows.Forms.ToolStripMenuItem TSMRefreshGeneral;
        private System.Windows.Forms.ComboBox cbGeneral;
        private System.Windows.Forms.ToolStripMenuItem TSMShowDetailsGeneral;
        private System.Windows.Forms.ToolStripMenuItem TSMAddNewGeneral;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem TSMSendEmailGeneral;
        private System.Windows.Forms.ToolStripMenuItem TSMPhoneCallGeneral;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TSMChangePassword;
        private System.Windows.Forms.ToolStripSeparator TSSchangePassword;
    }
}
