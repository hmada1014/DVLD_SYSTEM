using DVLDSystem_BusinessLayer_;
using DVLDSystem_WindowsForm_.Properties;
using DVLDSystem_WindowsForm_.User_Control;
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

namespace DVLDSystem_WindowsForm_.Test_Forms
{
    public partial class frmScheduleTest : Form
    {
        private clsLocalDrivingLicenseApplication _LDLApplication;
        private clsTestAppointment _TestAppointment;
        private clsApplication _Application;
        private int _TestTypeID = -1;
        private bool _IsLocked;
        private bool _IsRetakeTest;

        private enum enMode { Add = 1, Update = 2 }
        private enMode _Mode = enMode.Add;


        private enum enTestAppointmentType {FirstTime = 1 , Retake = 2}
        private enTestAppointmentType _ModeTestAppType;


        private int _ID;

        

        public frmScheduleTest(int id,clsLocalDrivingLicenseApplication LDLApplicationID,int TestTypeID ,bool IsRetakeTest = false,bool IsLocked = false)
        {
            

            _IsRetakeTest = IsRetakeTest;
            _LDLApplication = LDLApplicationID;
            _TestTypeID = TestTypeID;
            _IsLocked = IsLocked;
            _ID = id;
             InitializeComponent();
            _InitializeImageAndGbTestType();
            if (_ID == -1)
            {
                _Mode = enMode.Add;
            }
            else
            {
                _Mode = enMode.Update;
            }
           
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

        private void _FillFirstTimeAppointmentForAdd()
        {
            _TestAppointment = new clsTestAppointment();
            ucTestAppointment1.LDLApplicationID = _LDLApplication.LocalDrivingLicenseApplicationID.ToString();
            ucTestAppointment1.LicenseClasseName = clsLicenseClass.Find(_LDLApplication.LicenseClassID).ClassName;
            ucTestAppointment1.ApplicationPersonName = clsPerson.Find(_LDLApplication.ApplicantPersonID).FullName;
            ucTestAppointment1.NumberOfRetakenTests = clsTestAppointment.GetTestAppointmentTrial(_LDLApplication.LocalDrivingLicenseApplicationID, _TestTypeID).ToString();
            ucTestAppointment1.DateTestAppointment1.MinDate = DateTime.Now;
            ucTestAppointment1.TestFee = Convert.ToSingle(clsTestType.Find(_TestTypeID).TestTypeFees).ToString();
            lblHeaderTitle.Text = "Schedule Test";
            _ModeTestAppType = enTestAppointmentType.FirstTime;
        }
        private void _FillRetakeAppointmentForAdd()
        {
            _TestAppointment = new clsTestAppointment();
            _Application = new clsApplication();
            ucTestAppointment1.LDLApplicationID = _LDLApplication.LocalDrivingLicenseApplicationID.ToString();
            ucTestAppointment1.LicenseClasseName = clsLicenseClass.Find(_LDLApplication.LicenseClassID).ClassName;
            ucTestAppointment1.ApplicationPersonName = clsPerson.Find(_LDLApplication.ApplicantPersonID).FullName;
            ucTestAppointment1.NumberOfRetakenTests = clsTestAppointment.GetTestAppointmentTrial(_LDLApplication.LocalDrivingLicenseApplicationID, _TestTypeID).ToString();
            ucTestAppointment1.DateTestAppointment1.MinDate = DateTime.Now;
            ucTestAppointment1.TestFee = Convert.ToSingle(clsTestType.Find(_TestTypeID).TestTypeFees).ToString();
            ucRetakeTest1.RetakeApplicationFees.Text = Convert.ToSingle(clsApplicationTypes.Find(7).ApplicationFees).ToString();
            ucRetakeTest1.TotalFees.Text = (Convert.ToDecimal(ucTestAppointment1.TestFee) + Convert.ToDecimal(ucRetakeTest1.RetakeApplicationFees.Text)).ToString();
            lblHeaderTitle.Text = "Schedule Retake Test";
            _ModeTestAppType = enTestAppointmentType.Retake;
            ucRetakeTest1.Enabled = true;
        }
        private void _FillAppointmentForUpdate_NotLocked()
        {
            ucTestAppointment1.LDLApplicationID = _TestAppointment.LocalDrivingLicenseApplicationID.ToString();
            ucTestAppointment1.LicenseClasseName = clsLicenseClass.Find(_LDLApplication.LicenseClassID).ClassName;
            ucTestAppointment1.ApplicationPersonName = clsPerson.Find(_LDLApplication.ApplicantPersonID).FullName;
            ucTestAppointment1.NumberOfRetakenTests = clsTestAppointment.GetTestAppointmentTrial(_LDLApplication.LocalDrivingLicenseApplicationID, _TestTypeID).ToString();
            ucTestAppointment1.DateTestAppointment1.Value = _TestAppointment.AppointmentDate;
            ucTestAppointment1.DateTestAppointment1.MinDate = DateTime.Now;
            ucTestAppointment1.TestFee = Convert.ToSingle(_TestAppointment.PaidFees).ToString();
            lblHeaderTitle.Text = _TestAppointment.RetakeTestApplicationID == -1 ? "Schedule Test" : "Schedule Retake Test";
            ucRetakeTest1.Enabled = _TestAppointment.RetakeTestApplicationID == -1 ? false : true;
            if (ucRetakeTest1.Enabled)
            {
                ucRetakeTest1.RetakeTestApplicationID.Text = _TestAppointment.RetakeTestApplicationID.ToString();
                ucRetakeTest1.RetakeApplicationFees.Text = Convert.ToSingle(clsApplicationTypes.Find(7).ApplicationFees).ToString();
                ucRetakeTest1.TotalFees.Text = (Convert.ToDecimal(ucTestAppointment1.TestFee) + Convert.ToDecimal(ucRetakeTest1.RetakeApplicationFees.Text)).ToString();
            }
        }
        private void _FillAppointmentForUpdate_IsLocked()
        {
            lblMessageForLoackedAppointment.Visible = true;
            btnSave.Enabled = false;
            ucTestAppointment1.DateTestAppointment1.Enabled = false;
            ucTestAppointment1.LDLApplicationID = _TestAppointment.LocalDrivingLicenseApplicationID.ToString();
            ucTestAppointment1.LicenseClasseName = clsLicenseClass.Find(_LDLApplication.LicenseClassID).ClassName;
            ucTestAppointment1.ApplicationPersonName = clsPerson.Find(_LDLApplication.ApplicantPersonID).FullName;
            ucTestAppointment1.NumberOfRetakenTests = clsTestAppointment.GetTestAppointmentTrial(_LDLApplication.LocalDrivingLicenseApplicationID, _TestTypeID).ToString();
            ucTestAppointment1.DateTestAppointment1.Value = _TestAppointment.AppointmentDate;
            ucTestAppointment1.TestFee = Convert.ToSingle(_TestAppointment.PaidFees).ToString();
            lblHeaderTitle.Text = _TestAppointment.RetakeTestApplicationID == -1 ? "Schedule Test" : "Schedule Retake Test";
            ucRetakeTest1.Enabled = _TestAppointment.RetakeTestApplicationID == -1 ? false : true;
            if (ucRetakeTest1.Enabled)
            {
                ucRetakeTest1.RetakeTestApplicationID.Text = _TestAppointment.RetakeTestApplicationID.ToString();
                ucRetakeTest1.RetakeApplicationFees.Text = Convert.ToSingle(clsApplicationTypes.Find(7).ApplicationFees).ToString();
                ucRetakeTest1.TotalFees.Text = (Convert.ToDecimal(ucTestAppointment1.TestFee) + Convert.ToDecimal(ucRetakeTest1.RetakeApplicationFees.Text)).ToString();
            }
        }
        private void frmScheduleTest_Load(object sender, EventArgs e)
        {
         
            if ( _LDLApplication == null)
            {
                MessageBox.Show("this page will colse becuese no Test Appointment found ", "Error Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // here mean add new Test Appointment for first Time
            if (_Mode == enMode.Add && _IsRetakeTest == false)
            {
                _FillFirstTimeAppointmentForAdd();
                _SetTheLocatioForlblHeaderTitle();
                return;
            }

            // here mean add new Test Appointment for Retake Test
            if (_Mode == enMode.Add && _IsRetakeTest == true)
            {
                _FillRetakeAppointmentForAdd();
                _SetTheLocatioForlblHeaderTitle();
                return;
            }

            _TestAppointment = clsTestAppointment.Find(_ID);

            if (_TestAppointment == null)
            {
                MessageBox.Show("this page will colse becuese no Test Appointment found ", "Error Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // here to check is Appointment is locked , in this case not locked
            if (_Mode == enMode.Update && _IsLocked == false)
            {
                _FillAppointmentForUpdate_NotLocked();
                _SetTheLocatioForlblHeaderTitle();
                return;
            }

            // here to check is Appointment is locked , in this case locked
            if (_Mode == enMode.Update && _IsLocked == true)
            {
                _FillAppointmentForUpdate_IsLocked();
                _SetTheLocatioForlblHeaderTitle();
                return;
            }


        }

        private void _SetTheLocatioForlblHeaderTitle()
        {
            switch (lblHeaderTitle.Text)
            {
                case "Schedule Test":
                    lblHeaderTitle.Location = new System.Drawing.Point(119, 140);
                    break;
                case "Schedule Retake Test":
                    lblHeaderTitle.Location = new System.Drawing.Point(61, 140);
                    break;
            }
        }

        private bool _SaveApplicationForRetake()
        {

            _Application.ApplicantPersonID = _LDLApplication.ApplicantPersonID;
            _Application.ApplicationDate = DateTime.Now;
            // 7 is Retake Test
            _Application.ApplicationTypeID = 7;
            // 3 is complated
            _Application.ApplicationStatus = 3;
            _Application.LastStatusDate = DateTime.Now;
            // find Paid fees for Retake Test
            _Application.PaidFees = clsApplicationTypes.Find(7).ApplicationFees;
            _Application.CreatedByUserID = frmMainScreen._CurrentUser.UserID;
           return _Application.Save();
        }

        private void _FillObjectForAddFirstTime()
        {
            _TestAppointment.LocalDrivingLicenseApplicationID = _LDLApplication.LocalDrivingLicenseApplicationID;
            _TestAppointment.TestTypeID = _TestTypeID;
            _TestAppointment.AppointmentDate = ucTestAppointment1.DateTestAppointment1.Value;
            _TestAppointment.PaidFees = Convert.ToDecimal(ucTestAppointment1.TestFee);
            _TestAppointment.CreatedByUserID = frmMainScreen._CurrentUser.UserID;
            _TestAppointment.IsLocked = false;
        }


        private void _FillObjectForAddRetake()
        {
            _TestAppointment.LocalDrivingLicenseApplicationID = _LDLApplication.LocalDrivingLicenseApplicationID;
            _TestAppointment.TestTypeID = _TestTypeID;
            _TestAppointment.AppointmentDate = ucTestAppointment1.DateTestAppointment1.Value;
            _TestAppointment.PaidFees = Convert.ToDecimal(ucTestAppointment1.TestFee);
            _TestAppointment.CreatedByUserID = frmMainScreen._CurrentUser.UserID;
            _TestAppointment.IsLocked = false;
            _TestAppointment.RetakeTestApplicationID = _Application.ApplicationID;
            ucRetakeTest1.RetakeTestApplicationID.Text = _Application.ApplicationID.ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            if (_Mode == enMode.Add && _ModeTestAppType == enTestAppointmentType.FirstTime)
            {
                _FillObjectForAddFirstTime();
            }
            else if(_Mode == enMode.Add && _ModeTestAppType == enTestAppointmentType.Retake)
            {
                if (_SaveApplicationForRetake())
                {
                    _FillObjectForAddRetake();
                }
                else
                {
                    MessageBox.Show("Failed to save.", "Save failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
            }
            else if(_Mode == enMode.Update)
            {
                _TestAppointment.AppointmentDate = ucTestAppointment1.DateTestAppointment1.Value;
            }

            if (_TestAppointment.Save())
            {
                MessageBox.Show("Saved Successfully.","Saved",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Failed to save.", "Save failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
