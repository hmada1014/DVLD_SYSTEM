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

namespace DVLDSystem_WindowsForm_.User_Control
{
    public partial class ucDrivingLicenseApplicationInfo : UserControl
    {
        private clsLocalDrivingLicenseApplication _LDLApplication;
        public ucDrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }


        public void LoadDLApplicationInfo(int LDLApplicationID)
        {
            _LDLApplication = clsLocalDrivingLicenseApplication.Find(LDLApplicationID);

            if (_LDLApplication != null)
            {
                lblLDLApplicationID.Text = _LDLApplication.LocalDrivingLicenseApplicationID.ToString();
                lblLicenseClassName.Text =  clsLicenseClass.Find(_LDLApplication.LicenseClassID).ClassName;
                lblPassedTest.Text = $"{clsLocalDrivingLicenseApplication.GetPassedTestsByLDLApplicationID(LDLApplicationID)}/3";
                lklShowLicenseInfo.Enabled = true;
            }
            else
            {
                lblLDLApplicationID.Text = "????";
                lblLicenseClassName.Text = "????";
                lblPassedTest.Text = "0/3";
            }

        }
    }
}
