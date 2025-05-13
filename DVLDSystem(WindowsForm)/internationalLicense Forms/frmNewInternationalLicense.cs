using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDSystem_BusinessLayer_;
using DVLDSystem_WindowsForm_.Driver_License_Forms;
using DVLDSystem_WindowsForm_.internationalLicense_Forms;

namespace DVLDSystem_WindowsForm_.internationalLicenseID
{
    public partial class frmNewInternationalLicense : Form
    {
        private clsLicense _License;
        private clsInternationalLicense _internationalLicense = new clsInternationalLicense();
        public frmNewInternationalLicense()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucFindLocalLicense1_onLicenseSelected(clsLicense obj)
        {
            _License = obj;
            if (_License != null)
            {
                if (!clsInternationalLicense.IsInternationalLicenseWithLicenseIDExist(_License.LicenseID))
                {
                    if (_License.LicenseClass == 3)
                    {
                        if ((_License.IsActive == false) || (_License.ExpirationDate < DateTime.Now))
                        {

                            MessageBox.Show("Your Local Driver License Is not Active or expired","Not allowed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            lklLicenseHistory.Enabled = true;
                            return;
                        }
                        else
                        {
                            lklLicenseHistory.Enabled = true;
                            btnIssue.Enabled = true;
                            ucInternationalApplicationInfo1.LocalLicenseID = _License.LicenseID.ToString();
                            return;
                        }  
                    }
                    else
                    {
                        MessageBox.Show("only available for Class 3 - Ordinary driving license.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ucInternationalApplicationInfo1.LocalLicenseID = "[???]";
                        btnIssue.Enabled = false;
                        lklLicenseHistory.Enabled = true;

                        return;
                    }
                }
                else
                {
                    MessageBox.Show($"Person already have an active international license with id = {clsInternationalLicense.GetInternationalLicenseID(_License.LicenseID)}","Not allowed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    lklLicenseHistory.Enabled = true;
                    return;

                }
            }
            else
                ucInternationalApplicationInfo1.LocalLicenseID = "[???]";
                btnIssue.Enabled = false;
                lklLicenseHistory.Enabled = false;

        }

        private void frmNewInternationalLicense_Load(object sender, EventArgs e)
        {
            ucInternationalApplicationInfo1.LoadInternationalApplicationInfo();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            int InternationalLicenseID = _internationalLicense.IssueInternationalLicense(_License,frmMainScreen._CurrentUser.UserID);

            if (InternationalLicenseID != -1)
            {
                MessageBox.Show($"Congratulations, you have international license \n ID = {InternationalLicenseID}", "Issue Succeeded", MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.ucInternationalApplicationInfo1.InrenationalLicenseID =InternationalLicenseID.ToString() ;
                this.ucInternationalApplicationInfo1.InrenationalApplicationID =_internationalLicense.ApplicationID.ToString();
                this.lklShowLicenseInfo.Enabled = true;
                this.ucFindLocalLicense1.Enabled = false;
                this.btnIssue.Enabled = false;
            }
            else
            {
                MessageBox.Show($"Sorry, your license is not issued.", "Issue failed", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void lklShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowInternationalLicenseDetails showInternationalLicenseDetails = new frmShowInternationalLicenseDetails(_internationalLicense.ApplicationID);
            showInternationalLicenseDetails.ShowDialog();
        }

        private void lklLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            frmLicenseHistory licenseHistory = new frmLicenseHistory(_License.DriverID);
            licenseHistory.ShowDialog();
            ucFindLocalLicense1.SearchForLicense();
            

        }
    }
}
