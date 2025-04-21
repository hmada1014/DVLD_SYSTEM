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
            this.dgvShowList = new System.Windows.Forms.DataGridView();
            this.cmsGeneral = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblRrecords = new System.Windows.Forms.Label();
            this.lblRecordsTitle = new System.Windows.Forms.Label();
            this.TSMEditApplicationType = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMManageTestTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMRefresh = new System.Windows.Forms.ToolStripMenuItem();
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
            this.dgvShowList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShowList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowList.ContextMenuStrip = this.cmsGeneral;
            this.dgvShowList.Location = new System.Drawing.Point(0, 26);
            this.dgvShowList.Name = "dgvShowList";
            this.dgvShowList.ReadOnly = true;
            this.dgvShowList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowList.Size = new System.Drawing.Size(640, 330);
            this.dgvShowList.TabIndex = 6;
            // 
            // cmsGeneral
            // 
            this.cmsGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMEditApplicationType,
            this.TSMManageTestTypes,
            this.TSMRefresh});
            this.cmsGeneral.Name = "cmsGeneral";
            this.cmsGeneral.Size = new System.Drawing.Size(202, 140);
            this.cmsGeneral.Opening += new System.ComponentModel.CancelEventHandler(this.cmsGeneral_Opening);
            // 
            // lblRrecords
            // 
            this.lblRrecords.AutoSize = true;
            this.lblRrecords.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblRrecords.Location = new System.Drawing.Point(114, 361);
            this.lblRrecords.Name = "lblRrecords";
            this.lblRrecords.Size = new System.Drawing.Size(18, 19);
            this.lblRrecords.TabIndex = 10;
            this.lblRrecords.Text = "0";
            // 
            // lblRecordsTitle
            // 
            this.lblRecordsTitle.AutoSize = true;
            this.lblRecordsTitle.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblRecordsTitle.Location = new System.Drawing.Point(17, 360);
            this.lblRecordsTitle.Name = "lblRecordsTitle";
            this.lblRecordsTitle.Size = new System.Drawing.Size(88, 19);
            this.lblRecordsTitle.TabIndex = 9;
            this.lblRecordsTitle.Text = "#Records :";
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
            // ucTemplateDGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRrecords);
            this.Controls.Add(this.lblRecordsTitle);
            this.Controls.Add(this.dgvShowList);
            this.Name = "ucTemplateDGV";
            this.Size = new System.Drawing.Size(640, 386);
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
