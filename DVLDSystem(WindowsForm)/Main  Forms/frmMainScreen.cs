using DVLDSystem_BusinessLayer_;
using DVLDSystem_WindowsForm_.Properties;
using DVLDSystem_WindowsForm_.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDSystem_WindowsForm_
{
    public partial class frmMainScreen : Form
    {
        private int _UserID = -1;

        private clsUser _User;
        public frmMainScreen(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;

            if (_UserID != -1)
            {
                _User = clsUser.Find(_UserID);   
            }

        }

     /* 
        private Image ResizeImage(Image img, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, 0, 0, width, height);
            }
            return bmp;
        }
        private void ResizeImages()
        {
            tsmApplication.Image = ResizeImage(Resources.Applications, 48, 48);
            tsmPeople.Image = ResizeImage(Resources.People, 48, 48);
            tsmDrivers.Image = ResizeImage(Resources.Drivers, 48, 48);
            tsmUsers.Image = ResizeImage(Resources.Users, 48, 48);
            tsmAccountSettings.Image = ResizeImage(Resources.close, 48, 48);
        }*/
        private void frmMainScreen_Load(object sender, EventArgs e)
        {
            //ResizeImages();
            lblUsername.Text = _User.UserName;
        }
        private bool _CheckIsFormOpen(Type formName)
        {
            foreach (Form openForm in this.MdiChildren)
            {
                if (openForm.GetType() == formName)
                {
                    openForm.BringToFront();
                    return true;
                }
            }

            return false;
        }

        private void TSMPeople_Click(object sender, EventArgs e)
        {
            if (!_CheckIsFormOpen(typeof(frmPeople)))
            {
                frmPeople People = new frmPeople();
                People.MdiParent = this;
                People.Show(); 
            }
        }

        private void TSMUsers_Click(object sender, EventArgs e)
        {
            if (!_CheckIsFormOpen(typeof(frmUser)))
            {
                frmUser User = new frmUser();
                User.MdiParent = this;
                User.Show();
            }
        }

        private void TSMSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
