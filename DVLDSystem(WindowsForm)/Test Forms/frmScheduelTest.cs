using DVLDSystem_BusinessLayer_;
using DVLDSystem_WindowsForm_.User_Control;
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
    public partial class frmScheduelTest : Form
    {
        private clsLocalDrivingLicenseApplication _LDLApplication;
        private int _TestTypeID = -1;

        private enum enMode { Add = 1, Update = 2 }
        private enMode _Mode = enMode.Add;

        private int _ID;

        public frmScheduelTest(int ID,clsLocalDrivingLicenseApplication LDLApplicationID,int TestTypeID ,bool IsRetakTest = false)
        {
            InitializeComponent();

            _LDLApplication = LDLApplicationID;
            _TestTypeID = TestTypeID;
            ucRetakeTest1.Enabled = IsRetakTest;
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmScheduelTest_Load(object sender, EventArgs e)
        {
            

            if (_LDLApplication != null)
            {
                ucTestAppointment1.LDLApplicationID = _LDLApplication.LocalDrivingLicenseApplicationID.ToString();
                ucTestAppointment1.LicenseClasseName = clsLicenseClass.Find(_LDLApplication.LicenseClassID).ClassName;
                ucTestAppointment1.ApplicationPersonName = clsPerson.Find(_LDLApplication.ApplicantPersonID).FullName;
                ucTestAppointment1.DateTestAppointment1.MinDate = DateTime.Now;
                ucTestAppointment1.TestFee = Convert.ToSingle (clsTestType.Find(_TestTypeID).TestTypeFees).ToString();
                ucTestAppointment1.NumberOfRetakenTests = clsTestAppointment.GetTestAppointmentTrial(_LDLApplication.LocalDrivingLicenseApplicationID, _TestTypeID).ToString();
            }
            else
            {
                MessageBox.Show("this form will close");
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
