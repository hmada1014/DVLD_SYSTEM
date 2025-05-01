using DVLDSystem_BusinessLayer_;
using DVLDSystem_WindowsForm_.People__Forms;
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
    public partial class ucApplicationBasicInfo : UserControl
    {
        private clsApplication _Application;
        public ucApplicationBasicInfo()
        {
            InitializeComponent();
        }



        private string _GetApplicationStatusName(int ApplicationStatus)
        {

            
            switch (ApplicationStatus)
            {
                case 1:
                    return "New";
                case 2:
                    return "Canceled";
                case 3:
                    return "Completed";
            }

            return "Empty";

        }

        public void LoadApplicationInfo(int ApplicationID)
        {
            _Application = clsApplication.Find(ApplicationID);

            if (_Application != null)
            {
                lblApplicationID.Text = _Application.ApplicationID.ToString();
                lblApplicationStatus.Text = _GetApplicationStatusName(_Application.ApplicationStatus);
                lblApplicationFees.Text = Convert.ToSingle( clsApplicationTypes.Find(_Application.ApplicationTypeID).ApplicationFees).ToString();
                lblApplicationType.Text = clsApplicationTypes.Find(_Application.ApplicationTypeID).ApplicationTypeTitle;
                lblApplicationPersonName.Text = clsPerson.Find(_Application.ApplicantPersonID).FullName;
                lblApplicationDate.Text = _Application.ApplicationDate.ToString("M/d/yyyy");
                lblApplicationLastStatusDate.Text =_Application.LastStatusDate.ToString("M/d/yyyy");
                lblApplicationCreatedBy.Text = clsUser.Find(_Application.CreatedByUserID).UserName;
                lklPersonInfo.Enabled = true;
            }
            else
            {
                lblApplicationID.Text = "????";
                 lblApplicationStatus.Text = "????";
                lblApplicationFees.Text = "????";
                lblApplicationType.Text = "????";
                lblApplicationPersonName.Text = "????";
                lblApplicationDate.Text = "????";
                lblApplicationLastStatusDate.Text = "????";
                lblApplicationCreatedBy.Text = "????";
                lklPersonInfo.Enabled = false;
            }

        }

        private void lklPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonDetails showPersonDetails = new frmShowPersonDetails(_Application.ApplicantPersonID);
            showPersonDetails.ShowDialog();
        }
    }
}
