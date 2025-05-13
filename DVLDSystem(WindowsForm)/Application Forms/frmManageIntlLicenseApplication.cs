using DVLDSystem_BusinessLayer_;
using DVLDSystem_WindowsForm_.internationalLicenseID;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDSystem_WindowsForm_.international_License_Forms
{
    public partial class frmManageIntlLicenseApplication : Form
    {
        public frmManageIntlLicenseApplication()
        {
            InitializeComponent();
        }

        private string[] _FillComboBoxwhitString()
        {
            string[] strings = { "None", "intel ID" ,"Application ID"
                                , "Driver ID"};
            return strings;
        }
        private void frmManageIntlLicenseApplication_Load(object sender, EventArgs e)
        {
            ucTemplateDGVAndSearch1.RefreshDGV(clsInternationalLicense.GetAllInternationalLicenses());
            ucTemplateDGVAndSearch1.FillComboBox(_FillComboBoxwhitString());
        }

        private void btnAddLocalDrivingLicenseApplication_Click(object sender, EventArgs e)
        {
            frmNewInternationalLicense NewInternationalLicense = new frmNewInternationalLicense();
            NewInternationalLicense.ShowDialog();
        }
    }
}
