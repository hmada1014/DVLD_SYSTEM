using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDSystem_WindowsForm_
{
    public partial class ucRoundedPanel : UserControl
    {
        public ucRoundedPanel()
        {
            this.BackColor = Color.White; // Default background color
            this.Resize += (s, e) => this.Invalidate(); // Redraw on resize
            
            InitializeComponent();
        }

        private int topLeftRadius = 20;
        private int topRightRadius = 20;
        private int bottomLeftRadius = 20;
        private int bottomRightRadius = 20;

        public int TopLeftRadius
        {
            get { return topLeftRadius; }
            set { topLeftRadius = Math.Max(0, value); Invalidate(); }
        }

        public int TopRightRadius
        {
            get { return topRightRadius; }
            set { topRightRadius = Math.Max(0, value); Invalidate(); }
        }

        public int BottomLeftRadius
        {
            get { return bottomLeftRadius; }
            set { bottomLeftRadius = Math.Max(0, value); Invalidate(); }
        }

        public int BottomRightRadius
        {
            get { return bottomRightRadius; }
            set { bottomRightRadius = Math.Max(0, value); Invalidate(); }
        }

     

        

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (GraphicsPath path = GetRoundedPath())
            {
                this.Region = new Region(path);

                using (SolidBrush brush = new SolidBrush(this.BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }
            }
        }

        private GraphicsPath GetRoundedPath()
        {
            GraphicsPath path = new GraphicsPath();

            int width = this.Width;
            int height = this.Height;

            // Ensure arc sizes do not exceed panel dimensions
            int tlArc = Math.Min(topLeftRadius * 2, width);
            int trArc = Math.Min(topRightRadius * 2, width);
            int blArc = Math.Min(bottomLeftRadius * 2, height);
            int brArc = Math.Min(bottomRightRadius * 2, height);

            path.StartFigure();

            // Top-left corner
            if (topLeftRadius > 0)
                path.AddArc(0, 0, tlArc, tlArc, 180, 90);
            else
                path.AddLine(0, 0, 0, 0);

            // Top-right corner
            if (topRightRadius > 0)
                path.AddArc(width - trArc, 0, trArc, trArc, 270, 90);
            else
                path.AddLine(width, 0, width, 0);

            // Bottom-right corner
            if (bottomRightRadius > 0)
                path.AddArc(width - brArc, height - brArc, brArc, brArc, 0, 90);
            else
                path.AddLine(width, height, width, height);

            // Bottom-left corner
            if (bottomLeftRadius > 0)
                path.AddArc(0, height - blArc, blArc, blArc, 90, 90);
            else
                path.AddLine(0, height, 0, height);

            path.CloseFigure();
            return path;
        }

    }
}
