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
            this.dgvShowList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShowList
            // 
            this.dgvShowList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvShowList.Location = new System.Drawing.Point(0, 88);
            this.dgvShowList.Name = "dgvShowList";
            this.dgvShowList.Size = new System.Drawing.Size(640, 290);
            this.dgvShowList.TabIndex = 6;
            // 
            // ucTemplateDGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvShowList);
            this.Name = "ucTemplateDGV";
            this.Size = new System.Drawing.Size(640, 378);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvShowList;
    }
}
