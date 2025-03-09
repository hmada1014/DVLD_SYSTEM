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
            this.cbFindBy = new System.Windows.Forms.ComboBox();
            this.lblFindBy = new System.Windows.Forms.Label();
            this.dgvShowList = new System.Windows.Forms.DataGridView();
            this.txtSearchDGV = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowList)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFindBy
            // 
            this.cbFindBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbFindBy.FormattingEnabled = true;
            this.cbFindBy.Location = new System.Drawing.Point(108, 29);
            this.cbFindBy.Name = "cbFindBy";
            this.cbFindBy.Size = new System.Drawing.Size(134, 21);
            this.cbFindBy.TabIndex = 0;
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
            this.dgvShowList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvShowList.Location = new System.Drawing.Point(0, 78);
            this.dgvShowList.Name = "dgvShowList";
            this.dgvShowList.ReadOnly = true;
            this.dgvShowList.Size = new System.Drawing.Size(651, 290);
            this.dgvShowList.TabIndex = 2;
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
            this.txtSearchDGV.TextChanged += new System.EventHandler(this.txtSearchDGV_TextChanged);
            // 
            // ucTemplateDGVAndSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSearchDGV);
            this.Controls.Add(this.dgvShowList);
            this.Controls.Add(this.lblFindBy);
            this.Controls.Add(this.cbFindBy);
            this.Name = "ucTemplateDGVAndSearch";
            this.Size = new System.Drawing.Size(651, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFindBy;
        private System.Windows.Forms.Label lblFindBy;
        private System.Windows.Forms.DataGridView dgvShowList;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchDGV;
    }
}
