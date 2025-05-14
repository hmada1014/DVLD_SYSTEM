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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace DVLDSystem_WindowsForm_.User_Control
{
    public partial class ucApplicationNewLicenseInfo : UserControl
    {
        private clsLicenseClass _LicenseClass;
        public ucApplicationNewLicenseInfo()
        {
            InitializeComponent();
        }

        public string RenewLocalApplicationID
        {
           get { return lblRenewLocalApplicationID.Text; }
           set { lblRenewLocalApplicationID.Text = value; }
        }
        public string ApplicationDate
        {
            get { return lblApplicationDate.Text; }
            set { lblApplicationDate.Text = value; }
        }
        public string IssueDate
        {
            get { return lblIssueDate.Text; }
            set { lblIssueDate.Text = value; }
        }
        public string ApplicationFees
        {
            get { return lblApplicationFees.Text; }
            set { lblApplicationFees.Text = value; }
        }
        public string LicenseFees
        {
            get { return lblLicenseFees.Text; }
            set { lblLicenseFees.Text = value; }
        }
        public string Notes
        {
            get { return txtNote.Text; }
            set { txtNote.Text = value; }
        }
        public string RenewedLicenseID
        {
            get { return lblRenewedLicenseID.Text; }
            set { lblRenewedLicenseID.Text = value; }
        }
        public string OldLicenseID
        {
            get { return lblOldLicenseID.Text; }
            set { lblOldLicenseID.Text = value; }
        }
        public string ExpireDate
        {
            get { return lblExprationDate.Text; }
            set { lblExprationDate.Text = value; }
        }
        public string CreatedBy
        {
            get { return lblCreatedBy.Text; }
            set { lblCreatedBy.Text = value; }
        }
        public string TotalFees
        {
            get { return lblTotalFees.Text; }
            set { lblTotalFees.Text = value; }
        }

        public void LoadRenewApplicationInfo(clsLicense license)
        {
            if (license == null)
            {
                CreatedBy = frmMainScreen._CurrentUser.UserName;
                ApplicationDate = DateTime.Now.ToString("d/MMM/yyyy");
                IssueDate = DateTime.Now.ToString("d/MMM/yyyy");
                ApplicationFees =  Convert.ToSingle(clsApplicationTypes.Find(2).ApplicationFees).ToString();
                OldLicenseID = "[???]";
                LicenseFees = "[???]";
                TotalFees = "[???]";
                Notes = string.Empty;
                ExpireDate = "[???]";
            }
            else
            {
                _LicenseClass = clsLicenseClass.Find(license.LicenseClass);
                CreatedBy = frmMainScreen._CurrentUser.UserName;
                ApplicationDate = DateTime.Now.ToString("d/MMM/yyyy");
                IssueDate = DateTime.Now.ToString("d/MMM/yyyy");
                ApplicationFees = Convert.ToSingle(clsApplicationTypes.Find(2).ApplicationFees).ToString();
                if (_LicenseClass != null)
                {
                    OldLicenseID = license.LicenseID.ToString();
                    LicenseFees = Convert.ToSingle(_LicenseClass.ClassFees).ToString();
                    TotalFees = Convert.ToSingle(clsApplicationTypes.Find(2).ApplicationFees + _LicenseClass.ClassFees).ToString();
                    Notes = license.Notes;
                    ExpireDate = DateTime.Now.AddYears(_LicenseClass.DefaultValidityLength).ToString("d/MMM/yyyy"); 
                }
            }
        }
    }
}
