using DVLDSystem_BusinessLayer_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;
using static DVLDSystem_BusinessLayer_.clsTest;

namespace DVLDSystem_WindowsForm_.Issue
{
    public partial class frmIssueLicenseForFirstTime : Form
    {
        private clsLocalDrivingLicenseApplication _LDLApplication;
        private clsPerson _Person;
        private clsLicense _License = new clsLicense();
        private clsDriver _Driver;
        private int _LDLApplicationID = -1;
        public frmIssueLicenseForFirstTime(int LDLApplicationID)
        {
            InitializeComponent();
            if (LDLApplicationID > -1)
            {
                _LDLApplicationID = LDLApplicationID;
            }
        }

        private void frmIssueLicenseForFirstTime_Load(object sender, EventArgs e)
        {
            _LDLApplication = clsLocalDrivingLicenseApplication.Find(_LDLApplicationID);
          
            if (_LDLApplication != null)
            {
                ucDrivingLicenseApplicationInfo1.LoadDLApplicationInfo(_LDLApplication.LocalDrivingLicenseApplicationID);
                ucApplicationBasicInfo1.LoadApplicationInfo(_LDLApplication.ApplicationID);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("this form will close");
                this.Close();
            }
        }
        
        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to issue a License for First Time?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int LicesneID = _License.IssueFirstTimeLicense(_LDLApplication, frmMainScreen._CurrentUser.UserID, txtNotes.Text);

                if (LicesneID != -1)
                {
                    System.Windows.Forms.MessageBox.Show($"License Issued Successfully with License ID = {_License.LicenseID}", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ucDrivingLicenseApplicationInfo1.LoadDLApplicationInfo(_LDLApplication.LocalDrivingLicenseApplicationID);
                    btnIssue.Enabled = false;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show($"License Issued Failed with License ", "Failde", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
