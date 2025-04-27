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
    public partial class frmManageLDLApplication : Form
    {
        public frmManageLDLApplication()
        {
            InitializeComponent();
        }


        private string[] _FillComboBoxwhitString()
        {
            string[] strings = { "None", "L.D.LAppID" ,"National No" 
                                , "Full Name", "Status" };
            return strings;
        }
        private void frmManageLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            ucTemplateDGVAndSearch1.RefreshDGV(clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications());
            ucTemplateDGVAndSearch1.FillComboBox(_FillComboBoxwhitString());
        }

        private void btnAddLocalDrivingLicenseApplication_Click(object sender, EventArgs e)
        {
            frmAddEditLDLApplication AddLDLAplication = new frmAddEditLDLApplication(-1);
            AddLDLAplication.ShowDialog();
        }
    }
}
