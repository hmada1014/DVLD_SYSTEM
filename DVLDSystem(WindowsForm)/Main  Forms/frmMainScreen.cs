using DVLDSystem_BusinessLayer_;
using DVLDSystem_WindowsForm_.Application_Forms;
using DVLDSystem_WindowsForm_.Driver_Forms;
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

        public static clsUser _CurrentUser;
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
                userDetails.StartPosition = FormStartPosition.CenterScreen;
                userDetails.MdiParent = this;
                userDetails.Show(); 
            }
        }

        private void TSMChangePassword_Click(object sender, EventArgs e)
        {
            if (_CurrentUser != null)
            {
                frmChangePasswordUser changePasswordUser = new frmChangePasswordUser(_CurrentUser.UserID);
                changePasswordUser.StartPosition = FormStartPosition.CenterScreen;
                changePasswordUser.MdiParent = this;
                changePasswordUser.Show();
            }
        }

        private void TSMManageApplicationTypes_Click(object sender, EventArgs e)
        {

            if (!_CheckIsFormOpen(typeof(frmManageApplicationTypes)))
            {
                frmManageApplicationTypes applicationTypes = new frmManageApplicationTypes();
                applicationTypes.MdiParent = this;
                applicationTypes.Show();

            }
        }

        private void TSMManageTestTypes_Click(object sender, EventArgs e)
        {
            if (!_CheckIsFormOpen(typeof(frmManageTestTypes)))
            {
                frmManageTestTypes applicationTypes = new frmManageTestTypes();
                applicationTypes.MdiParent = this;
                applicationTypes.Show();
            }
        }

        private void TSMNewLocalLicenseApplication_Click(object sender, EventArgs e)
        {
            frmAddEditLDLApplication editLocalDrivingLicenseApplication  = new frmAddEditLDLApplication(-1);
            editLocalDrivingLicenseApplication.MdiParent = this;
            editLocalDrivingLicenseApplication.Show();
        }

        private void TSMlocalDrivingLicenseApplications_Click(object sender, EventArgs e)
        {

            frmManageLDLApplication manageLocalDrivingLicenseApplication = new frmManageLDLApplication();
            manageLocalDrivingLicenseApplication.MdiParent = this;
            manageLocalDrivingLicenseApplication.Show();

        }

        private void TSMinternationalLinceseApplications_Click(object sender, EventArgs e)
        {
           
        }

        private void tsmDrivers_Click(object sender, EventArgs e)
        {
            if (!_CheckIsFormOpen(typeof(frmDriver)))
            {
                frmDriver driver = new frmDriver();
                driver.MdiParent = this;
                driver.Show();
            }
          
        }
    }
}
