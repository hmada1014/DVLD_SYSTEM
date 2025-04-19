using DVLDSystem_BusinessLayer_;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDSystem_WindowsForm_.User__Forms
{
    public partial class frmChangePasswordUser : Form
    {
        private int _UserID;
        private clsUser _CurrentUser;
        public frmChangePasswordUser(int userID)
        {
            InitializeComponent();
            _UserID = userID;

            _CurrentUser = clsUser.Find(_UserID);
            this.AcceptButton = btnSave;

        }

        private void frmChangePasswordUser_Load(object sender, EventArgs e)
        {
            if (_CurrentUser != null)
            {
                ucPersonCard1.LoadPersonInfo(clsPerson.Find(_CurrentUser.PersonID));
                ucUserCard1.LoadUserInfo(_CurrentUser.UserID);
            }
            else
            {
                ucPersonCard1.LoadPersonInfo(null);
                ucUserCard1.LoadUserInfo(-1);
            }
        }
        private void txt_Validating(object sender, CancelEventArgs e)
        {
            Guna2TextBox text = sender as Guna2TextBox;

            if (string.IsNullOrWhiteSpace(text.Text))
            {
                ep1.SetError(text, string.Empty);
                ep1.SetError(text, text.Tag.ToString());
            }
            else if ((text == txtCurrentPassword) && (txtCurrentPassword.Text.Trim() != _CurrentUser.Password))
            {
                ep1.SetError(text, string.Empty);
                ep1.SetError(txtCurrentPassword, "Current Password Is Wrong");
            }
            else if ((text == txtConfirmPassword) && (txtNewPassword.Text.Trim() != txtConfirmPassword.Text.Trim()))
            {
                ep1.SetError(text, string.Empty);
                ep1.SetError(txtConfirmPassword, "Password Is not match");
            }
            else
            {
                ep1.SetError(text, string.Empty);
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool _ValidateForm()
        {
            bool isValid = true;

            isValid &= (txtCurrentPassword.Text.Trim() == _CurrentUser.Password);
            isValid &= (txtNewPassword.Text.Trim() == txtConfirmPassword.Text.Trim());
            this.ValidateChildren();
            return isValid;
        }

        private void _FillUserObject()
        {
            _CurrentUser.Password = txtNewPassword.Text.Trim();
        }
        private void _SaveUser()
        {

            if (_CurrentUser.Save())
            {
                MessageBox.Show("Data Saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("User Saved Failed.", "Failed Save",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_ValidateForm())
            {
                MessageBox.Show("Please fill all required fields Correctly before saving.", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            _FillUserObject();
            _SaveUser();


        }
        private void txtCurrentPassword_Validated(object sender, EventArgs e)
        {

        }
    }
}
