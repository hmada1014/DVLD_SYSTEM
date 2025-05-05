using DVLDSystem_BusinessLayer_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLDSystem_BusinessLayer_.clsTest;

namespace DVLDSystem_WindowsForm_.Issue
{
    public partial class frmIssueLicenseForFirstTime : Form
    {
        private clsLocalDrivingLicenseApplication _LDLApplication;
        private clsPerson _Person;
        private clsLicense _License;
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
                MessageBox.Show("this form will close");
                this.Close();
            }
        }
        private void _FillObjectDriver()
        {

            _Driver = new clsDriver();
            _Driver.CreatedDate = DateTime.Now;
            _Driver.CreatedByUserID = frmMainScreen._CurrentUser.UserID;
            _Driver.PersonID = _LDLApplication.ApplicantPersonID;
        }
        private void _FillObjectLicense()
        {
            _License = new clsLicense();
            _License.ApplicationID = _LDLApplication.ApplicationID;
            _License.DriverID = _Driver.DriverID;
            _License.LicenseClass = _LDLApplication.LicenseClassID;
            _License.IssueDate = DateTime.Now;
            _License.ExpirationDate = _License.IssueDate.AddYears(clsLicenseClass.Find(_LDLApplication.LicenseClassID).DefaultValidityLength);
            _License.Notes = txtNotes.Text;
            _License.PaidFees = clsLicenseClass.Find(_LDLApplication.LicenseClassID).ClassFees;
            _License.IsActive = true;
            _License.IssueReason = 1;
            _License.CreatedByUserID = frmMainScreen._CurrentUser.UserID;
        }
        private void _FillObjectLDLApplication()
        {
            _LDLApplication.ApplicationStatus = 3;
        }
        private void btnIssue_Click(object sender, EventArgs e)
        {

            _FillObjectDriver();
            if (_Driver.Save())
            {
                _FillObjectLicense();
                if (_License.Save())
                {
                    _FillObjectLDLApplication();
                    if (_LDLApplication.Save())
                    {
                        MessageBox.Show($"License Issued Successfully with License ID = {_License.LicenseID}", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ucDrivingLicenseApplicationInfo1.LoadDLApplicationInfo(_LDLApplication.LocalDrivingLicenseApplicationID);
                    }
                }
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
