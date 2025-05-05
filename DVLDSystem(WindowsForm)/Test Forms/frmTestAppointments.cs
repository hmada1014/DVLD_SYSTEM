using DVLDSystem_BusinessLayer_; using DVLDSystem_WindowsForm_.Properties;
using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Linq; using System.Text; using System.Threading.Tasks; using System.Windows.Forms;  namespace DVLDSystem_WindowsForm_.Test_Forms {     public partial class frmTestAppointments : Form     {
        private enum enTestType { VisionTest = 1 ,WritingTest = 2 ,StreetTest =3}         private enTestType _enTestMode;         private clsLocalDrivingLicenseApplication _LDLApplication;         private int _LDLApplicationID = -1;          public frmTestAppointments(int LDLApplicationID , string TestType)         {             InitializeTestMode(TestType);             InitializeComponent();                          if (LDLApplicationID > -1)             {                 _LDLApplicationID = LDLApplicationID;             } 
            switch (TestType)
            {
                case "VisionTest":
                    _enTestMode = enTestType.VisionTest;
                    lblHeaderTitle.Text = "Vision Test Appointments";
                    pbMainImage.Image = Resources.Vision_512; 
                    break;
                case "WritingTest":
                    _enTestMode = enTestType.WritingTest;
                    lblHeaderTitle.Text = "Writing Test Appointments";
                    pbMainImage.Image = Resources.Written_Test_512;

                    break;
                case "StreetTest":
                    _enTestMode = enTestType.StreetTest;
                    lblHeaderTitle.Text = "Street Test Appointments";
                    pbMainImage.Image = Resources.driving_test_512; 
                    break;
            }
        }          private void btnClose_Click(object sender, EventArgs e)         {             this.Close();         }         private void _RefreshDGVAppointmentsByTestType(enTestType TestMode)
        { 
            switch (TestMode)
            {
                case enTestType.VisionTest:
                    ucTemplateDGV1.RefreshDGV(clsTestAppointment.GetAllTestAppointment(_LDLApplication.LocalDrivingLicenseApplicationID,1));
                    break;
                case enTestType.WritingTest:
                    ucTemplateDGV1.RefreshDGV(clsTestAppointment.GetAllTestAppointment(_LDLApplication.LocalDrivingLicenseApplicationID, 2));
                    break;
                case enTestType.StreetTest:
                    ucTemplateDGV1.RefreshDGV(clsTestAppointment.GetAllTestAppointment(_LDLApplication.LocalDrivingLicenseApplicationID, 3));
                    break;
            }
        }         private void frmTestAppointments_Load(object sender, EventArgs e)         {             _LDLApplication = clsLocalDrivingLicenseApplication.Find(_LDLApplicationID);              if (_LDLApplication != null)             {                 ucDrivingLicenseApplicationInfo1.LoadDLApplicationInfo(_LDLApplication.LocalDrivingLicenseApplicationID);                 ucApplicationBasicInfo1.LoadApplicationInfo(_LDLApplication.ApplicationID);                 _RefreshDGVAppointmentsByTestType(_enTestMode);             }             else             {                 MessageBox.Show("this form will close");                 this.Close();             }         }
        private void _AddNewTestAppointment(enTestType TestType)
        {
            int TestTypeID = Convert.ToInt32(TestType);

            if (TestTypeID != -1)
            {
                if (clsTestAppointment.IsLDLApplicationIDHasTestAppointmentsExist(_LDLApplication.LocalDrivingLicenseApplicationID , TestTypeID))
                {

                    if (clsTest.IsLDLApplicationIDPassedTest(_LDLApplication.LocalDrivingLicenseApplicationID, TestTypeID, 1))
                    {
                        MessageBox.Show("You already Passed the test", "Passed Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (clsTestAppointment.CheckTestAppointmentLockeStatus(_LDLApplication.LocalDrivingLicenseApplicationID, TestTypeID, false))
                    {

                        MessageBox.Show("You already have active Appointemnt", "active Appointemnt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }
                    else
                    {
                        // -1 mean new mode
                        frmScheduleTest scheduelTest = new frmScheduleTest(-1,_LDLApplication,Convert.ToInt32(_enTestMode),true);
                        scheduelTest.ShowDialog();
                    }
                }
                else
                {
                    // -1 mean new mode
                    frmScheduleTest scheduelTest = new frmScheduleTest(-1,_LDLApplication, Convert.ToInt32(_enTestMode));
                    scheduelTest.ShowDialog();
                } 
            }
        }         private void btnAddNewTestAppointment_Click(object sender, EventArgs e)         {             _AddNewTestAppointment(_enTestMode);             _RefreshDGVAppointmentsByTestType(_enTestMode);         }

        private void ucTemplateDGV1_onPersonPassedTest(int obj)
        {
            ucDrivingLicenseApplicationInfo1.PassedTest = $"{obj}/3";
        }
    } } 