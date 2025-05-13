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

namespace DVLDSystem_WindowsForm_.Driver_License_Forms
{
    public partial class frmLicenseHistory : Form
    {
        private clsDriver _Driver;
        private int _DriverID;
        public frmLicenseHistory(int DriverID)
        {
            InitializeComponent();
            _DriverID = DriverID;
        }

        private void frmLicenseHistory_Load(object sender, EventArgs e)
        {
            _Driver = clsDriver.Find(_DriverID);

            if (_Driver == null)
            {
                MessageBox.Show("License History Not found,\n this Window will close.");
                this.Close();
                return;
            }

            ucFindPerson1.SearchForPersonByPersonID(_Driver.PersonID.ToString());
            ucFindPerson1.GBFilterMode = false;
            ucFindPerson1.txtSearch = _Driver.PersonID.ToString();

            ucTemplateDGV1_Local.RefreshDGV(clsLicense.GetAllLocalLicenseByDriverID(_Driver.DriverID));
            ucTemplateDGV1_international.RefreshDGV(clsInternationalLicense.GetAllInternationalLicensesByDriverID(_Driver.DriverID));
        }
    }
}
