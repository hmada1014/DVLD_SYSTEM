using DVLDSystem_BusinessLayer_;
using DVLDSystem_WindowsForm_.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDSystem_WindowsForm_.Test_Forms
{
    public partial class frmTakeTest : Form
    {
        private clsTestAppointment _TestAppointment;
        private clsLocalDrivingLicenseApplication _LDLApplication;
        private clsTest _Test;
        private int _ID;
        private int _TestTypeID;
        public frmTakeTest(int iD , int TestType)
        {
           
            _ID = iD; 
            _TestTypeID = TestType;
            InitializeComponent();
            _InitializeImageAndGbTestType();
        }

        private void _InitializeImageAndGbTestType()
        {
            switch (_TestTypeID)
            {
                case 1:
                    pbMainImage.Image = Resources.Vision_512;
                    gbTestType.Text = "Vision Test";

                    break;
                case 2:
                    pbMainImage.Image = Resources.Written_Test_512;
                    gbTestType.Text = "Written Test";

                    break;
                case 3:
                    pbMainImage.Image = Resources.driving_test_512;
                    gbTestType.Text = "Street Test";

                    break;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            _TestAppointment = clsTestAppointment.Find(_ID);
            _LDLApplication = clsLocalDrivingLicenseApplication.Find(_TestAppointment.LocalDrivingLicenseApplicationID);
          

            if (_TestAppointment == null && _LDLApplication == null)
            {
                MessageBox.Show("this page will colse becuese no Test Appointment found ", "Error Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            _Test = new clsTest();
            ucTestInfo1.LDLApplicationID = _TestAppointment.LocalDrivingLicenseApplicationID.ToString();
            ucTestInfo1.LicenseClasseName = clsLicenseClass.Find(_LDLApplication.LicenseClassID).ClassName.ToString();
            ucTestInfo1.ApplicationPersonName = clsPerson.Find(_LDLApplication.ApplicantPersonID).FullName;
            ucTestInfo1.DateTest = _TestAppointment.AppointmentDate.ToString("d/MMMM/yyyy");
            ucTestInfo1.NumberOfRetakenTests = clsTestAppointment.GetTestAppointmentTrial(_LDLApplication.LocalDrivingLicenseApplicationID, _TestTypeID).ToString();
            ucTestInfo1.TestFee = Convert.ToSingle( _TestAppointment.PaidFees).ToString();
            ucTestInfo1.TestID = "Not Taken Yet";
            
        }

        private void _SaveObject()
        {
            if (_Test.Save())
            {
                if (_TestAppointment.Save())
                {
                    MessageBox.Show("Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ucTestInfo1.TestID = _Test.TestID.ToString();
                    btnSave.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Failed to save.", "Save failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _FillObject()
        {
            _Test.TestAppointmentID = _TestAppointment.TestAppointmentID;
            _Test.TestResult = rbtnPass.Checked == true ? true : false;
            _Test.Notes = string.IsNullOrEmpty(txtNote.Text) ? "" : txtNote.Text;
            _Test.CreatedByUserID = frmMainScreen._CurrentUser.UserID;

            _TestAppointment.IsLocked = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _FillObject();

            if (MessageBox.Show("Are you sure you want to save? After that you cannot change\nthe Pass/Fail result after you save?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _SaveObject();
            }
        }
    }
}
