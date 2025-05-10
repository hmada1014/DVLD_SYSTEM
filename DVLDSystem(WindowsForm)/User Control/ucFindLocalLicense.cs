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
    public partial class ucFindLocalLicense : UserControl
    {
        private clsLicense _License;



        // event for UserControl
        public event Action<clsLicense> onLicenseSelected;

        protected virtual void PersonSelected(clsLicense personId)
        {
            Action<clsLicense> handler = onLicenseSelected;
            if (handler != null)
            {
                handler(personId);
            }
        }


        public ucFindLocalLicense()
        {
            InitializeComponent();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtLicenseID.Text.Trim(), out int ID))
            {
                int ApplicationID = clsLicense.GetApplicationID(ID);
                if (ucDriverLicenseInfo1.LoadDriverLicenseInfo(ApplicationID))
                {

                    _License = clsLicense.Find(ID);
                    if (_License != null)
                    {
                        onLicenseSelected(_License);
                    }

                }
                else
                {
                    onLicenseSelected(null);
                }
            }
        }

        private void txtLicenseID_KeyPress(object sender, KeyPressEventArgs e)
       {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
