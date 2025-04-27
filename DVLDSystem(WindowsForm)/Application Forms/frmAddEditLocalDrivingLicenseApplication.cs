using DVLDSystem_BusinessLayer_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace DVLDSystem_WindowsForm_.Application_Forms
{
    public partial class frmAddEditLocalDrivingLicenseApplication : Form
    {
        private enum enMode { Add = 1, Update = 2 }
        private enMode _Mode = enMode.Add;
        private int _PersonID = -1;
        private clsLocalDrivingLicenseApplication _localDrivingLicenseApplication;

        private int _ApplicationID ;
        public frmAddEditLocalDrivingLicenseApplication(int ApplicationID)
        {
            InitializeComponent();
            _ApplicationID = ApplicationID;
            if (_ApplicationID == -1)
            {
                _Mode = enMode.Add;
            }
            else
            {
                _Mode = enMode.Update;
            }
        }
        
        private void _LoadLicenseClass()
        {
            DataTable dtlicenseCLass = clsLicenseClass.GetAllLicenseClasss().Table;
          
            foreach (DataRow drLicenseClass in dtlicenseCLass.Rows)
            {
                cbLicenseClass.Items.Add(drLicenseClass["ClassName"]);
            }

            cbLicenseClass.SelectedIndex = 0;

        }

        private void _GetApplicationFees()
        {
            lblApplicationFees.Text =  Convert.ToSingle(clsApplicationTypes.Find("New Local Driving License Service").ApplicationFees).ToString();
        }
        private void _LoadData()
        {
            _LoadLicenseClass();
           
            if (_Mode == enMode.Add)
            {
                lblTitleHeader.Text = "New Local Driving License Application";
                DateTime dateTime = DateTime.Now;
                lblApplicationDate.Text = dateTime.ToString("M/d/yyyy");
                lblCreatedBy.Text = frmMainScreen._CurrentUser != null ? frmMainScreen._CurrentUser.UserName : "not user set";
                _GetApplicationFees();
                _localDrivingLicenseApplication = new clsLocalDrivingLicenseApplication();
                return;
            }

            _localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.Find(_ApplicationID);

            if (_localDrivingLicenseApplication == null)
            {
                MessageBox.Show("this page will colse becuese no local Driving License Application found ", "Error Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            if (_Mode == enMode.Update)
            {
                lblTitleHeader.Text = "Update Local Driving License Application";
                ucFindPerson1.LoadData(_localDrivingLicenseApplication.ApplicantPersonID.ToString());
                lblDLApplicationID.Text = _localDrivingLicenseApplication.ApplicationID.ToString();
                lblApplicationDate.Text = _localDrivingLicenseApplication.ApplicationDate.ToString("M/d/yyyy");
                cbLicenseClass.SelectedItem = clsLicenseClass.Find(_localDrivingLicenseApplication.LicenseClassID).ClassName;
                lblApplicationFees.Text = clsApplicationTypes.Find(_localDrivingLicenseApplication.ApplicationTypeID).ApplicationFees.ToString();
                lblCreatedBy.Text = clsUser.Find(_localDrivingLicenseApplication.CreatedByUserID).UserName;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucFindPerson1_onPersonSelected(int obj)
        {
            _PersonID = obj;
        }

        private void frmAddLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_PersonID != -1)
            {
                tcApplicationInfo.SelectedTab = TPApplicationInfo;
                btnSave.Enabled = true;
            }
            else
            {
                MessageBox.Show("Selecte Person before click next.", "Selecte a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
            }
        }
    }
}
