using DVLDSystem_BusinessLayer_;
using DVLDSystem_WindowsForm_.Driver_License_Forms;
using DVLDSystem_WindowsForm_.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDSystem_WindowsForm_.RenewLicense_Forms
{
    public partial class frmRenewLicense : Form
    {

        private clsLicense _OldLicense;
        private clsLicense _RenewLicense;
        public frmRenewLicense()
        {
            InitializeComponent();
        }

        private void ucFindLocalLicense1_onLicenseSelected(DVLDSystem_BusinessLayer_.clsLicense obj)
        {
            _OldLicense = obj;
            if (_OldLicense != null)
            {
                if ((_OldLicense.ExpirationDate < DateTime.Now))
                {
                    if ((_OldLicense.IsActive == false))
                    {

                        MessageBox.Show("Your Local Driver License Is not Active", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lklLicenseHistory.Enabled = true;
                        lklShowNewLicenseInfo.Enabled = false;
                        btnRenew.Enabled = false;
                        return;
                    }
                    else
                    {
                        ucApplicationNewLicenseInfo1.LoadRenewApplicationInfo(_OldLicense);
                        lklLicenseHistory.Enabled = true;
                        lklShowNewLicenseInfo.Enabled = false;
                        btnRenew.Enabled = true;
                        return;
                    }
                }
                else
                {
                    MessageBox.Show($"Selected License is not yet expiared.it will expire on:\n{_OldLicense.ExpirationDate.ToString("dd/MMM/yyyy")}", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lklLicenseHistory.Enabled = true;
                    lklShowNewLicenseInfo.Enabled = false;
                    btnRenew.Enabled = false;

                    return;
                }
            }
            else
                ucApplicationNewLicenseInfo1.LoadRenewApplicationInfo(_OldLicense);
                btnRenew.Enabled = false;
                lklLicenseHistory.Enabled = false;
                lklShowNewLicenseInfo.Enabled = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRenewLicense_Load(object sender, EventArgs e)
        {
            ucApplicationNewLicenseInfo1.LoadRenewApplicationInfo(_OldLicense);
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Renew the License!","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                _RenewLicense = new clsLicense();
                int RenewLicenseID = _RenewLicense.IssueRenewLicense(_OldLicense, frmMainScreen._CurrentUser.UserID,ucApplicationNewLicenseInfo1.Notes);
                if (RenewLicenseID != -1)
                {
                    lklShowNewLicenseInfo.Enabled = true;
                    btnRenew.Enabled = false; ;
                    ucApplicationNewLicenseInfo1.RenewedLicenseID = _RenewLicense.LicenseID.ToString();
                    ucApplicationNewLicenseInfo1.RenewLocalApplicationID = _RenewLicense.ApplicationID.ToString();
                    MessageBox.Show($"Licensed Renewed Successfully with ID = {_RenewLicense.LicenseID}","License Issued",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Failed to renew license with ID = {_OldLicense.LicenseID}", "Failed issue license",MessageBoxButtons.OK , MessageBoxIcon.Error);
                }
            }
        }

        private void lklShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowDriverLicenseDetails showDriverLicenseDetails = new frmShowDriverLicenseDetails(_RenewLicense.ApplicationID);
            showDriverLicenseDetails.ShowDialog();
        }

        private void lklLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory licenseHistory = new frmLicenseHistory(_OldLicense.DriverID);
            licenseHistory.ShowDialog();
        }
    }
}
