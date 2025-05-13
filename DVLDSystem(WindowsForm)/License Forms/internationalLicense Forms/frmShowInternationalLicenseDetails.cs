using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDSystem_WindowsForm_.internationalLicense_Forms
{
    public partial class frmShowInternationalLicenseDetails : Form
    {
        private int _ApplicationID;
        public frmShowInternationalLicenseDetails(int ApplicationID)
        {
            InitializeComponent();
            _ApplicationID = ApplicationID;
        }

        private void frmShowInternationalLicenseDetails_Load(object sender, EventArgs e)
        {
            ucInternationalLicenseInfo1.LoadDriverLicenseInfo(_ApplicationID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
