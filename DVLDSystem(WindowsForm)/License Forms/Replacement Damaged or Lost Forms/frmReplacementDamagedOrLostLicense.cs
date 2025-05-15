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

namespace DVLDSystem_WindowsForm_.License_Forms.Replacement_Damaged_or_Lost_Forms
{
    public partial class frmReplacementDamagedOrLostLicense : Form
    {
        private clsLicense _OldLicense;
        private clsLicense _ReplacementLicense;

        private enum enReplacementStatus { Lost = 3 ,Damaged = 4 }
        enReplacementStatus ReplacMode = enReplacementStatus.Damaged;

        public frmReplacementDamagedOrLostLicense()
        {
            InitializeComponent();
        }

        private void rbtnReplacementStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDamagedLicense.Checked)
            {
                ucApplicationReplacmentInfo1.SetApplicatioFees((int)enReplacementStatus.Damaged);
                ReplacMode = enReplacementStatus.Damaged;
            }
            else
            {
                ucApplicationReplacmentInfo1.SetApplicatioFees((int)enReplacementStatus.Lost);
                ReplacMode = enReplacementStatus.Lost;
            }
        }

        private void frmReplacementDamagedOrLostLicense_Load(object sender, EventArgs e)
        {
            rbtnReplacementStatus_CheckedChanged(null,null);
            ucApplicationReplacmentInfo1.LoadApplicationReplacmentInfo(_OldLicense);
        }

        private void ucFindLocalLicense1_onLicenseSelected(clsLicense obj)
        {
            _OldLicense = obj;
            if (_OldLicense != null)
            {
                if ((_OldLicense.ExpirationDate > DateTime.Now))
                {
                    if ((_OldLicense.IsActive == false))
                    {
                        ucApplicationReplacmentInfo1.LoadApplicationReplacmentInfo(_OldLicense, (int)ReplacMode);
                        ucApplicationReplacmentInfo1.ReplacedLicenseID = "[???]";
                        ucApplicationReplacmentInfo1.LicenseReplacmentApplicationID = "[???]";
                        btnIssueReplacement.Enabled = false;
                        lklLicenseHistory.Enabled = true;
                        lklShowNewLicenseInfo.Enabled = false;

                        MessageBox.Show("Your Local Driver License Is not Active, choose an active license.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }
                    else
                    {
                        ucApplicationReplacmentInfo1.LoadApplicationReplacmentInfo(_OldLicense,(int)ReplacMode);
                        lklLicenseHistory.Enabled = true;
                        btnIssueReplacement.Enabled = true;
                        lklShowNewLicenseInfo.Enabled = false;
                        return;
                    }
                }
                else
                {
                    ucApplicationReplacmentInfo1.LoadApplicationReplacmentInfo(_OldLicense, (int)ReplacMode);
                    ucApplicationReplacmentInfo1.ReplacedLicenseID = "[???]";
                    ucApplicationReplacmentInfo1.LicenseReplacmentApplicationID = "[???]";
                    lklLicenseHistory.Enabled = true;
                    btnIssueReplacement.Enabled = false;
                    lklShowNewLicenseInfo.Enabled = false;

                    MessageBox.Show($"Selected License is  expiared.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
            }
            else
            btnIssueReplacement.Enabled = false;
            lklLicenseHistory.Enabled = false;
            btnIssueReplacement.Enabled = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssueReplacement_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to issue a Replacement for the license?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _ReplacementLicense = new clsLicense();

                int ReplacedLicenseID = _ReplacementLicense.IssueReplacementLicense(_OldLicense, frmMainScreen._CurrentUser.UserID ,(int)ReplacMode);
                if (ReplacedLicenseID != -1)
                {
                    btnIssueReplacement.Enabled = false;
                    lklShowNewLicenseInfo.Enabled = true;
                    ucApplicationReplacmentInfo1.LicenseReplacmentApplicationID = _ReplacementLicense.ApplicationID.ToString();
                    ucApplicationReplacmentInfo1.ReplacedLicenseID = _ReplacementLicense.LicenseID.ToString();
                    MessageBox.Show($"Licensed Replaced Successfully with ID : {_ReplacementLicense.LicenseID}","License Issued",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Licensed Replaced Failed.","License Issued",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    ucApplicationReplacmentInfo1.ReplacedLicenseID = "[???]";
                    ucApplicationReplacmentInfo1.LicenseReplacmentApplicationID = "[???]";
                    lklShowNewLicenseInfo.Enabled = false;

                }

            }
        }

        private void lklShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowDriverLicenseDetails showDriverLicenseDetails = new frmShowDriverLicenseDetails(_ReplacementLicense.ApplicationID);
            showDriverLicenseDetails.ShowDialog();
        }

        private void lklLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory licenseHistory = new frmLicenseHistory(_OldLicense.DriverID);
            licenseHistory.ShowDialog();
        }
    }
}
