namespace DVLDSystem_WindowsForm_.User_Control
{
    partial class ucTemplateDGV
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
            this.dgvShowList = new System.Windows.Forms.DataGridView();
            this.cmsGeneral = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMEditApplicationType = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMManageTestTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRrecords = new System.Windows.Forms.Label();
            this.lblRecordsTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowList)).BeginInit();
            this.cmsGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvShowList
            // 
            this.dgvShowList.AllowUserToAddRows = false;
            this.dgvShowList.AllowUserToDeleteRows = false;
            this.dgvShowList.AllowUserToResizeColumns = false;
            this.dgvShowList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(204)))), ((int)(((byte)(197)))));
            this.dgvShowList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShowList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShowList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowList.ContextMenuStrip = this.cmsGeneral;
            this.dgvShowList.GridColor = System.Drawing.SystemColors.Desktop;
            this.dgvShowList.Location = new System.Drawing.Point(0, 7);
            this.dgvShowList.Name = "dgvShowList";
            this.dgvShowList.ReadOnly = true;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgvShowList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvShowList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowList.Size = new System.Drawing.Size(640, 307);
            this.dgvShowList.TabIndex = 6;
            // 
            // cmsGeneral
            // 
            this.cmsGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMEditApplicationType,
            this.TSMManageTestTypes,
            this.TSMRefresh});
            this.cmsGeneral.Name = "cmsGeneral";
            this.cmsGeneral.Size = new System.Drawing.Size(202, 118);
            this.cmsGeneral.Opening += new System.ComponentModel.CancelEventHandler(this.cmsGeneral_Opening);
            // 
            // TSMEditApplicationType
            // 
            this.TSMEditApplicationType.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.edit_32;
            this.TSMEditApplicationType.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMEditApplicationType.Name = "TSMEditApplicationType";
            this.TSMEditApplicationType.Size = new System.Drawing.Size(201, 38);
            this.TSMEditApplicationType.Text = "Edit Application Type";
            this.TSMEditApplicationType.Visible = false;
            this.TSMEditApplicationType.Click += new System.EventHandler(this.cmsGeneral_Click);
            // 
            // TSMManageTestTypes
            // 
            this.TSMManageTestTypes.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.edit_32;
            this.TSMManageTestTypes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMManageTestTypes.Name = "TSMManageTestTypes";
            this.TSMManageTestTypes.Size = new System.Drawing.Size(201, 38);
            this.TSMManageTestTypes.Text = "Edit Test Type";
            this.TSMManageTestTypes.Visible = false;
            this.TSMManageTestTypes.Click += new System.EventHandler(this.cmsGeneral_Click);
            // 
            // TSMRefresh
            // 
            this.TSMRefresh.Image = global::DVLDSystem_WindowsForm_.Properties.Resources.Refresh_32;
            this.TSMRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMRefresh.Name = "TSMRefresh";
            this.TSMRefresh.Size = new System.Drawing.Size(201, 38);
            this.TSMRefresh.Text = "Refresh";
            this.TSMRefresh.Click += new System.EventHandler(this.TSMRefresh_Click);
            // 
            // lblRrecords
            // 
            this.lblRrecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRrecords.AutoSize = true;
            this.lblRrecords.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblRrecords.Location = new System.Drawing.Point(114, 319);
            this.lblRrecords.Name = "lblRrecords";
            this.lblRrecords.Size = new System.Drawing.Size(18, 19);
            this.lblRrecords.TabIndex = 10;
            this.lblRrecords.Text = "0";
            // 
            // lblRecordsTitle
            // 
            this.lblRecordsTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecordsTitle.AutoSize = true;
            this.lblRecordsTitle.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblRecordsTitle.Location = new System.Drawing.Point(17, 319);
            this.lblRecordsTitle.Name = "lblRecordsTitle";
            this.lblRecordsTitle.Size = new System.Drawing.Size(88, 19);
            this.lblRecordsTitle.TabIndex = 9;
            this.lblRecordsTitle.Text = "#Records :";
            // 
            // ucTemplateDGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRrecords);
            this.Controls.Add(this.lblRecordsTitle);
            this.Controls.Add(this.dgvShowList);
            this.Name = "ucTemplateDGV";
            this.Size = new System.Drawing.Size(640, 345);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowList)).EndInit();
            this.cmsGeneral.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvShowList;
        private System.Windows.Forms.Label lblRrecords;
        private System.Windows.Forms.Label lblRecordsTitle;
        private System.Windows.Forms.ContextMenuStrip cmsGeneral;
        private System.Windows.Forms.ToolStripMenuItem TSMEditApplicationType;
        private System.Windows.Forms.ToolStripMenuItem TSMRefresh;
        private System.Windows.Forms.ToolStripMenuItem TSMManageTestTypes;
    }
}
