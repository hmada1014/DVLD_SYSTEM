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
    public partial class frmShowUserDetails : Form
    {
        private int _UserID;
        private clsUser _CurrentUser;
        public frmShowUserDetails(int UserID)
        {
            InitializeComponent();
            this._UserID = UserID;
        }

        private void frmShowUserDetails_Load(object sender, EventArgs e)
        {
            _CurrentUser = clsUser.Find(_UserID);
            if (_CurrentUser != null)
            {
                ucPersonCard1.LoadPersonInfo(clsPerson.Find(_CurrentUser.PersonID));
                ucUserCard1.LoadUserInfo(_CurrentUser.UserID);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
