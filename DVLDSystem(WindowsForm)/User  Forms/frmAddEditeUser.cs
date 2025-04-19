using DVLDSystem_BusinessLayer_;
using DVLDSystem_WindowsForm_.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVLDSystem_WindowsForm_.User
{
    public partial class frmAddEditeUser : Form
    {
        private enum enPermission { Application = 1 , People = 2,Drivers = 4 ,Users = 8}
        private enum enMode { Add = 1, Update = 2 }
        private enMode _Mode = enMode.Add;

        private int _ID;
        private int _PersonID = -1;
        private clsUser _CurrentUser;
        public frmAddEditeUser(int id)
        {
            InitializeComponent();


            _ID = id;

            if (_ID == -1)
            {
                _Mode = enMode.Add;
            }
            else
            {
                _Mode = enMode.Update;
            }
            this.AcceptButton = btnSave;
        }

        private void _LoadData()
        {
            if (_Mode == enMode.Add)
            {
                lblTitleHeader.Text = "Add New User";
                _CurrentUser  = new clsUser();
                return;
            }

            _CurrentUser = clsUser.Find(_ID);

            if (_CurrentUser == null)
            {
                MessageBox.Show("this page will colse becuese no User found ", "Error User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            if (_Mode == enMode.Update)
            {
                _FillUserForm();
            }
        }

        private void _FillUserForm()
        {
            lblTitleHeader.Text = "Update User";
            ucFindPerson1.LoadData(_CurrentUser.PersonID.ToString());
            ucFindPerson1.GBFilterMode = false;
            lblUserID.Text = _CurrentUser.UserID.ToString();
            txtUsername.Text = _CurrentUser.UserName;
            txtPassword.Text = _CurrentUser.Password;
            txtConfirmPassword.Text = _CurrentUser.Password;
            CkeckCbPermission(_CurrentUser.Permission);
            ToggleSwitchISActive.Checked = _CurrentUser.IsActive;
            btnSave.Enabled = true;
            btnNext.Enabled = false;
        }
        private void CkeckCbPermission(int Permission)
        {
            if (Permission == -1)
            {
                IsAllChecked(true);
                return;
            };

            cbApplication.Checked = (((int)enPermission.Application)&Permission) == 1;
            cbPeople.Checked = ((int)enPermission.People & Permission) == 2;
            cbDrivers.Checked = (((int)enPermission.Drivers) & Permission) == 4;
            cbUsers.Checked = (((int)enPermission.Users) & Permission) == 8;


        }
        private void frmAddEditeUser_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
        private bool IsAllChecked(bool all)
        {
            cbAllPermission.Checked = all;
            cbApplication.Checked = all;
            cbPeople.Checked = all;
            cbDrivers.Checked = all;
            cbUsers.Checked = all;
            return all;
        }
        private bool _ValidateForm()
        {
            bool isValid = true;

          
            if (clsUser.IsUserExist(txtUsername.Text.Trim().ToLower()))
            {
                if (!clsUser.IsUserExist(txtUsername.Text.Trim().ToLower(), _CurrentUser.UserID.ToString(), ""))
                {
                    ep.SetError(txtUsername, "User is already exists.");
                    isValid = false;
                }
            }
            else
            {
                ep.SetError(txtUsername, string.Empty);

            }

            if ((cbAllPermission.Checked || cbApplication.Checked || cbPeople.Checked || cbDrivers.Checked
                || cbUsers.Checked) == false)
            {
                isValid = false;
                ep.SetError(groupBox1, "Require to choose one.");
            }
            else
            {
                ep.SetError(groupBox1, string.Empty);
            }

            if ( (txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim()))
            {
                isValid = false;
                ep.SetError(txtConfirmPassword, "Confirm Password not match.");
            }
            else
            {
                ep.SetError(txtConfirmPassword, string.Empty);
            }

            return isValid;
        }
        private void txt_Validating(object sender, CancelEventArgs e)
        {
            TextBox text = sender as TextBox;

            if (string.IsNullOrWhiteSpace(text.Text))
            {
                e.Cancel = true;
                ep.SetError(text, text.Tag.ToString());
                return;
            }
            if (!clsUser.IsUserExist(txtUsername.Text.Trim(),_PersonID))
            {
                if (clsUser.IsUserExist(txtUsername.Text.Trim()))
                {
                    e.Cancel = true;
                    ep.SetError(text, "username is exist");
                }
                else
                {
                    ep.SetError(text, string.Empty);
                }
            }
            else
            {
                ep.SetError(text, string.Empty);
            }
        }
        private void cb_Validating(object sender, CancelEventArgs e)
        {
            
            if ((cbAllPermission.Checked || cbApplication.Checked || cbPeople.Checked || cbDrivers.Checked
                || cbUsers.Checked) == false)
            {
                e.Cancel = true;
                ep.SetError(groupBox1, "Require to choose one.");
            }
            else
            {
                ep.SetError(groupBox1, string.Empty);
            }
        }
        private int _GetUserPermission()
        {
            int Permission = 0;
            if (cbAllPermission.Checked)
                return -1;
            if (cbApplication.Checked)
                Permission += ((int)enPermission.Application);
            if (cbPeople.Checked)
                Permission += ((int)enPermission.People);
            if (cbDrivers.Checked)
                Permission += ((int)enPermission.Drivers);
            if (cbUsers.Checked)
                Permission += ((int)enPermission.Users);
            

            return Permission;
        }
        private void _FillUserObject()
        {
             
            _CurrentUser.PersonID   = _PersonID;
            _CurrentUser.UserName   = txtUsername.Text.Trim().ToLower();
            _CurrentUser.Password   = txtPassword.Text.Trim();
            _CurrentUser.IsActive   = ToggleSwitchISActive.Checked;
            _CurrentUser.Permission = _GetUserPermission();
        }
        private void _SaveUser()
        {

            if (_CurrentUser.Save())
            {
                MessageBox.Show("Data Saved successfully","Saved",MessageBoxButtons.OK,MessageBoxIcon.Information);

                _Mode = enMode.Update;
                lblTitleHeader.Text = $"Update User";
                lblUserID.Text = _CurrentUser.UserID.ToString();
            }
            else
            {
                MessageBox.Show("User Saved Failed.", "Failed Save",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!btnSave.Enabled)
            {
                return;
            }
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Please fill all required fields before saving.", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_ValidateForm())
            {
                _FillUserObject();
                _SaveUser();
            }
            else
            {
                MessageBox.Show("Please correct the validation errors before saving.", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void cbAllPermission_CheckedChanged(object sender, EventArgs e)
        {
            IsAllChecked(cbAllPermission.Checked);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_PersonID != -1)
            {
                
               if (!clsUser.IsPersonExist(_PersonID))
               {
                   tcUser.SelectedTab = TPLoginInfo;
                   btnSave.Enabled = true;
               }
               else
               {
                   MessageBox.Show("Selected Person already has a user, choose another one.", "Selecte another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   btnSave.Enabled = false;

               }                 
            }
            else
            {
                MessageBox.Show("Selecte Person before click next.", "Selecte a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
            }
        }
        private void ucFindPerson1_onPersonSelected(int obj)
        {
            _PersonID = obj;
        }
        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            TextBox text = sender as TextBox;

            if (string.IsNullOrWhiteSpace(text.Text))
            {
                e.Cancel = true;
                ep.SetError(text, text.Tag.ToString());
                return;
            }
            if(txtConfirmPassword == text && (txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim()))
            {
                
                ep.SetError(text, "Confirm Password not match.");
            }
            else
            {
                ep.SetError(text, string.Empty);
            }
        }
    }
}
