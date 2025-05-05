using DVLDSystem_BusinessLayer_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDSystem_WindowsForm_.Driver_License_Forms
{
    public partial class frmShowDriverLicenseDetails : Form
    {
        private int _LDLApplicationID;
        public frmShowDriverLicenseDetails(int LDLApplicationID)
        {
            InitializeComponent();

            _LDLApplicationID = LDLApplicationID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmShowDriverLicenseDetails_Load(object sender, EventArgs e)
        {
            ucDriverLicenseInfo1.LoadDriverLicenseInfo(_LDLApplicationID);
        }
    }
}
