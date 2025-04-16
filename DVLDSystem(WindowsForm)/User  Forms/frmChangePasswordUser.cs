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

namespace DVLDSystem_WindowsForm_.User__Forms
{
    public partial class frmChangePasswordUser : Form
    {
        private int _UserID;
        private clsUser _CurrentUser ;
        public frmChangePasswordUser(int userID)
        {
            InitializeComponent();
            _UserID = userID;

            _CurrentUser = clsUser.Find(_UserID);

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

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtCurrentPassword.Text.Trim() != _CurrentUser.Password)
            {
                ep1.SetError(txtCurrentPassword, "Password Is Wrong");
                e.Cancel = true;

            }
            else
            {
                ep1.SetError(txtCurrentPassword, string.Empty);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Please fill all required fields before saving.", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
        }
    }
}
