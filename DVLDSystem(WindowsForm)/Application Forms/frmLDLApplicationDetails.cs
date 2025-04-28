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

namespace DVLDSystem_WindowsForm_.Application_Forms
{
    public partial class frmLDLApplicationDetails : Form
    {
        private clsLocalDrivingLicenseApplication _LDLApplication;
        private int _LDLApplicationID;
        public frmLDLApplicationDetails(int LDLApplicationID)
        {
            InitializeComponent();
            if (LDLApplicationID > -1)
            {
                _LDLApplicationID = LDLApplicationID;   
            }
        }

        private void frmLDLApplicationDetails_Load(object sender, EventArgs e)
        {
            _LDLApplication = clsLocalDrivingLicenseApplication.Find(_LDLApplicationID);
            if (_LDLApplication != null)
            {
                ucDrivingLicenseApplicationInfo1.LoadDLApplicationInfo(_LDLApplication.LocalDrivingLicenseApplicationID); ;
                ucApplicationBasicInfo1.LoadApplicationInfo(_LDLApplication.ApplicationID);
            }
            else
            {
                MessageBox.Show("this form will close");
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
