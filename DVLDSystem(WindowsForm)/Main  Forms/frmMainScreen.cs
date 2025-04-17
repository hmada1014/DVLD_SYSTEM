using DVLDSystem_BusinessLayer_;
using DVLDSystem_WindowsForm_.Properties;
using DVLDSystem_WindowsForm_.User;
using DVLDSystem_WindowsForm_.User__Forms;
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

        private clsUser _CurrentUser;
        public frmMainScreen(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;

            if (_UserID != -1)
            {
                _CurrentUser = clsUser.Find(_UserID);   
            }

        }

     
        private void frmMainScreen_Load(object sender, EventArgs e)
        {

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

        private void TSMCurrentUserInfo_Click(object sender, EventArgs e)
        {
            if (_CurrentUser != null)
            {
                frmShowUserDetails userDetails = new frmShowUserDetails(_CurrentUser.UserID);
                userDetails.MdiParent = this;
                userDetails.Show(); 
            }
        }

        private void TSMChangePassword_Click(object sender, EventArgs e)
        {
            if (_CurrentUser != null)
            {
                frmChangePasswordUser changePasswordUser = new frmChangePasswordUser(_CurrentUser.UserID);
                changePasswordUser.MdiParent = this;
                changePasswordUser.Show();
            }
        }
    }
}
