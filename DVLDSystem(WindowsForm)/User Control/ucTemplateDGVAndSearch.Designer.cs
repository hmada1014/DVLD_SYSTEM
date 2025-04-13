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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbFindBy = new System.Windows.Forms.ComboBox();
            this.lblFindBy = new System.Windows.Forms.Label();
            this.dgvShowList = new System.Windows.Forms.DataGridView();
            this.cmsEditDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.EeleteGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearchDGV = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblRrecords = new System.Windows.Forms.Label();
            this.lblRecordsTitle = new System.Windows.Forms.Label();
            this.btnRefreshDGV = new FontAwesome.Sharp.IconPictureBox();
            this.TSM_Refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.cbGendor = new System.Windows.Forms.ComboBox();
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
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(204)))), ((int)(((byte)(197)))));
            this.dgvShowList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvShowList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShowList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvShowList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 11.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvShowList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowList.ContextMenuStrip = this.cmsEditDelete;
            this.dgvShowList.EnableHeadersVisualStyles = false;
            this.dgvShowList.GridColor = System.Drawing.Color.Black;
            this.dgvShowList.Location = new System.Drawing.Point(0, 78);
            this.dgvShowList.Name = "dgvShowList";
            this.dgvShowList.ReadOnly = true;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dgvShowList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvShowList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowList.Size = new System.Drawing.Size(651, 290);
            this.dgvShowList.TabIndex = 2;
            // 
            // cmsEditDelete
            // 
            this.cmsEditDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditGeneral,
            this.EeleteGeneral,
            this.TSM_Refresh});
            this.cmsEditDelete.Name = "cmsAddEdit";
            this.cmsEditDelete.Size = new System.Drawing.Size(114, 70);
            // 
            // EditGeneral
            // 
            this.EditGeneral.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Edit;
            this.EditGeneral.Name = "EditGeneral";
            this.EditGeneral.Size = new System.Drawing.Size(113, 22);
            this.EditGeneral.Text = "Edit";
            this.EditGeneral.Click += new System.EventHandler(this.EditGeneral_Click);
            // 
            // EeleteGeneral
            // 
            this.EeleteGeneral.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.delete;
            this.EeleteGeneral.Name = "EeleteGeneral";
            this.EeleteGeneral.Size = new System.Drawing.Size(113, 22);
            this.EeleteGeneral.Text = "Delete";
            this.EeleteGeneral.Click += new System.EventHandler(this.DeleteGeneral_Click);
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
            // TSM_Refresh
            // 
            this.TSM_Refresh.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Screenshot_2025_03_15_201348;
            this.TSM_Refresh.Name = "TSM_Refresh";
            this.TSM_Refresh.Size = new System.Drawing.Size(113, 22);
            this.TSM_Refresh.Text = "Refresh";
            this.TSM_Refresh.Click += new System.EventHandler(this.TSM_Refresh_Click);
            // 
            // cbGendor
            // 
            this.cbGendor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbGendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGendor.FormattingEnabled = true;
            this.cbGendor.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGendor.Location = new System.Drawing.Point(281, 29);
            this.cbGendor.Name = "cbGendor";
            this.cbGendor.Size = new System.Drawing.Size(134, 21);
            this.cbGendor.TabIndex = 9;
            this.cbGendor.Visible = false;
            this.cbGendor.SelectedIndexChanged += new System.EventHandler(this.cbGendor_SelectedIndexChanged);
            // 
            // ucTemplateDGVAndSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.cbGendor);
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
        private System.Windows.Forms.ToolStripMenuItem EditGeneral;
        private System.Windows.Forms.ToolStripMenuItem EeleteGeneral;
        private System.Windows.Forms.ToolStripMenuItem TSM_Refresh;
        private System.Windows.Forms.ComboBox cbGendor;
    }
}
