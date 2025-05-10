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
    public partial class ucInternationalApplicationInfo : UserControl
    {
        public ucInternationalApplicationInfo()
        {
            InitializeComponent();
        }

        clsApplicationTypes _ApplicationTypes;

        public string InrenationalApplicationID
        {
            get { return lblInrenationalApplicationID.Text; }
            set { lblInrenationalApplicationID.Text = value; }
        }
        public string ApplicationDate
        {
            get { return lblApplicationDAte.Text; }
            set { lblApplicationDAte.Text = value; }
        }

        public string IssueDate
        {
            get { return lblIssueDate.Text; }
            set { lblIssueDate.Text = value; }
        }

        public string InternationalFees
        {
            get { return lblInternationalFees.Text; }
            set { lblInternationalFees.Text = value; }
        }

        public string InrenationalLicenseID
        {
            get { return lblInrenationalLicenseID.Text; }
            set { lblInrenationalLicenseID.Text = value; }
        }

        public string LocalLicenseID
        {
            get { return lblLocalLicenseID.Text; }
            set { lblLocalLicenseID.Text = value; }
        }

        public string ExpireDate
        {
            get { return lblExpireDate.Text; }
            set { lblExpireDate.Text = value; }
        }

        public string CreatedBy
        {
            get { return lblCreatedBy.Text; }
            set { lblCreatedBy.Text = value; }
        }

        public void LoadInternationalApplicationInfo()
        {
            _ApplicationTypes = clsApplicationTypes.Find(6);
            CreatedBy = frmMainScreen._CurrentUser.UserName;
            ApplicationDate = DateTime.Now.ToString("d/MMM/yyyy");
            IssueDate = DateTime.Now.ToString("d/MMM/yyyy");
            InternationalFees =Convert.ToSingle( _ApplicationTypes.ApplicationFees).ToString();
            ExpireDate = DateTime.Now.AddYears(1).ToString("d/MMM/yyyy");
        }

        private void gb_Enter(object sender, EventArgs e)
        {

        }
    }
}
