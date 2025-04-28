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
    public partial class frmAddEditLDLApplication : Form
    {
        private enum enModeApplicationStatus { New =1 ,canceled = 2 ,completed = 3}
        private enum enMode { Add = 1, Update = 2 }
        private enMode _Mode = enMode.Add;
        private int _PersonID = -1;
        private clsLocalDrivingLicenseApplication _localDrivingLicenseApplication;

        private int _LDLApplicationID ;
        public frmAddEditLDLApplication(int ApplicationID)
        {
            InitializeComponent();
            _LDLApplicationID = ApplicationID;
            if (_LDLApplicationID == -1)
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

        private void _LoadAddNewLocalDrivingLicenseApplication()
        {
            lblTitleHeader.Text = "New Local Driving License Application";
            DateTime dateTime = DateTime.Now;
            lblApplicationDate.Text = dateTime.ToString("M/d/yyyy");
            lblCreatedBy.Text = frmMainScreen._CurrentUser != null ? frmMainScreen._CurrentUser.UserName : "not user set";
            _GetApplicationFees();
            _localDrivingLicenseApplication = new clsLocalDrivingLicenseApplication();
        }
        private void _LoadUpdateLocalDrivingLicenseApplication()
        {
            lblTitleHeader.Text = "Update Local Driving License Application";
            ucFindPerson1.LoadData(_localDrivingLicenseApplication.ApplicantPersonID.ToString());
            lblDLApplicationID.Text = _localDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lblApplicationDate.Text = _localDrivingLicenseApplication.ApplicationDate.ToString("M/d/yyyy");
            cbLicenseClass.SelectedItem = clsLicenseClass.Find(_localDrivingLicenseApplication.LicenseClassID).ClassName;
            lblApplicationFees.Text = Convert.ToSingle(clsApplicationTypes.Find(_localDrivingLicenseApplication.ApplicationTypeID).ApplicationFees).ToString();
            lblCreatedBy.Text = clsUser.Find(_localDrivingLicenseApplication.CreatedByUserID).UserName;
            btnSave.Enabled = true;
            ucFindPerson1.Enabled = false;
        }
        private void _LoadData()
        {
            _LoadLicenseClass();
           
            if (_Mode == enMode.Add)
            {
                _LoadAddNewLocalDrivingLicenseApplication();
                return;
            }

            _localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.Find(_LDLApplicationID);

            if (_localDrivingLicenseApplication == null)
            {
                MessageBox.Show("this page will colse becuese no local Driving License Application found ", "Error Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            if (_Mode == enMode.Update)
            {
                _LoadUpdateLocalDrivingLicenseApplication();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucFindPerson1_onPersonSelected(int obj)
        {
            _PersonID = obj;
            if (_PersonID == -1)
            {
                btnSave.Enabled = false;
            }
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

        private void _FillobjectLocalDrivingLicenseApplication()
        {
            if (_Mode == enMode.Add)
            {
                _localDrivingLicenseApplication.ApplicantPersonID = _PersonID;
                _localDrivingLicenseApplication.ApplicationDate = DateTime.Now;
                _localDrivingLicenseApplication.LicenseClassID = clsLicenseClass.Find(cbLicenseClass.Text).LicenseClassID;
                _localDrivingLicenseApplication.PaidFees = Convert.ToDecimal(lblApplicationFees.Text);
                _localDrivingLicenseApplication.CreatedByUserID = frmMainScreen._CurrentUser.UserID;
                _localDrivingLicenseApplication.ApplicationStatus = Convert.ToByte(enModeApplicationStatus.New);
                _localDrivingLicenseApplication.LastStatusDate = DateTime.Now;
                _localDrivingLicenseApplication.ApplicationTypeID = clsApplicationTypes.Find("New Local Driving License Service").ApplicationTypeID; 
            }
            else if (_Mode == enMode.Update) 
            {
                
                _localDrivingLicenseApplication.LicenseClassID = clsLicenseClass.Find(cbLicenseClass.Text).LicenseClassID;
            }
        }

        private void _SaveLocalDrivingLicenseApplication()
        {
            if (_localDrivingLicenseApplication.Save())
            {
                lblDLApplicationID.Text = _localDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
                MessageBox.Show("Data Saved Successfuly.","Saved",MessageBoxButtons.OK,MessageBoxIcon.Information);
                lblTitleHeader.Text = "Update Local Driving License Application";
                _Mode = enMode.Update;
                ucFindPerson1.Enabled = false;

            }
            else
            {
                MessageBox.Show("local Driving License Application Saved Failed.", "Failed Save",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (!clsLocalDrivingLicenseApplication.IsPersonHasSameLicenseClassExist(_PersonID,clsLicenseClass.Find(cbLicenseClass.Text).LicenseClassID))
            {
                if (_PersonID != -1)
                {
                    _FillobjectLocalDrivingLicenseApplication();
                    _SaveLocalDrivingLicenseApplication();
                }
                else
                {
                    MessageBox.Show("Please Select a Person before Saving", "Failed Save",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
            else
            {
                MessageBox.Show($"Choose another License class, the selected Person Already" +
                    $"\n have an active application for the selected class with id = " +
                    $"{clsLocalDrivingLicenseApplication.GetApplicationIDByApplicantPersonIDAndLicenseClassID(_PersonID,clsLicenseClass.Find(cbLicenseClass.Text).LicenseClassID)}", 
                    "Failed Save",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


    }
}
