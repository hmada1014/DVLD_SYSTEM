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
    public partial class ucApplicationReplacmentInfo : UserControl
    {
        public ucApplicationReplacmentInfo()
        {
            InitializeComponent();
        }



        public string LicenseReplacmentApplicationID
        {
            get { return lblLicenseReplacmentApplicationID.Text; }            
            set { lblLicenseReplacmentApplicationID.Text = value; }
        }
        public string ApplicationDate
        {
            get { return lblApplicationDate.Text; }
            set { lblApplicationDate.Text = value; }
        }
        public string ApplicationFees
        {
            get { return lblApplicationFees.Text; }
            set { lblApplicationFees.Text = value; }
        }
        public string ReplacedLicenseID
        {
            get { return lblReplacedLicenseID.Text; }
            set { lblReplacedLicenseID.Text = value; }
        }
        public string OldLicenseID
        {
            get { return lblOldLicenseID.Text; }
            set { lblOldLicenseID.Text = value; }
        }
        public string CreatedBy
        {
            get { return lblCreatedBy.Text; }
            set { lblCreatedBy.Text = value; }
        }

        public void SetApplicatioFees(int ReplacementStatus)
        {
            ApplicationFees = Convert.ToSingle(clsApplicationTypes.Find(ReplacementStatus).ApplicationFees).ToString();
        }

        public void LoadApplicationReplacmentInfo(clsLicense license , int ReplacementStatus = 1)
        {
            if (license == null)
            {
                CreatedBy = frmMainScreen._CurrentUser.UserName;
                ApplicationDate = DateTime.Now.ToString("d/MMM/yyyy");
                ApplicationFees = Convert.ToSingle(clsApplicationTypes.Find(4).ApplicationFees).ToString();
                
            }
            else
            {
                CreatedBy = frmMainScreen._CurrentUser.UserName;
                ApplicationDate = DateTime.Now.ToString("d/MMM/yyyy");
                ApplicationFees = Convert.ToSingle(clsApplicationTypes.Find(ReplacementStatus).ApplicationFees).ToString();
                OldLicenseID = license.LicenseID.ToString();
            }
        }

    }
}
