using Bunifu.Framework;
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
using System.IO;
using DVLDSystem_WindowsForm_.Properties;

namespace DVLDSystem_WindowsForm_.User_Control
{
    public partial class ucDriverLicenseInfo : UserControl
    {
        
        private clsApplication _Application;
        private clsPerson _Person;
        private clsLicense _License;
        public ucDriverLicenseInfo()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        [Category("Misc Controls Properties")]
        public string ClassName
        {
            get { return lblClassName.Text; }
            set { lblClassName.Text = value; }
        }

        [Browsable(true)]
        [Category("Misc Controls Properties")]
        public string NamePerson
        {
            get { return lblNamePerson.Text; }
            set { lblNamePerson.Text = value; }
        }

        [Browsable(true)]
        [Category("Misc Controls Properties")]
        public string LicenseID
        {
            get { return lblLicenseID.Text; }
            set { lblLicenseID.Text = value; }
        }

        [Browsable(true)]
        [Category("Misc Controls Properties")]
        public string NationalNo
        {
            get { return lblNationalNo.Text; }
            set { lblNationalNo.Text = value; }
        }

        [Browsable(true)]
        [Category("Misc Controls Properties")]
        public string GenderPerson
        {
            get { return lblGenderPerson.Text; }
            set { lblGenderPerson.Text = value; }
        }

        [Browsable(true)]
        [Category("Misc Controls Properties")]
        public string IssueDate
        {
            get { return lblIssueDate.Text; }
            set { lblIssueDate.Text = value; }
        }

        [Browsable(true)]
        [Category("Misc Controls Properties")]
        public string IssueReason
        {
            get { return lblIssueReason.Text; }
            set { lblIssueReason.Text = value; }
        }

        [Browsable(true)]
        [Category("Misc Controls Properties")]
        public string Notes
        {
            get { return lblNote.Text; }
            set { lblNote.Text = value; }
        }

        [Browsable(true)]
        [Category("Misc Controls Properties")]
        public string IsActive
        {
            get { return lblIsActive.Text; }
            set { lblIsActive.Text = value; }
        }

        [Browsable(true)]
        [Category("Misc Controls Properties")]
        public string DateOfBirth
        {
            get { return lblDateOfBirth.Text; }
            set { lblDateOfBirth.Text = value; }
        }

        [Browsable(true)]
        [Category("Misc Controls Properties")]
        public string DriverID
        {
            get { return lblDriverID.Text; }
            set { lblDriverID.Text = value; }
        }

        [Browsable(true)]
        [Category("Misc Controls Properties")]
        public string ExpirationDate
        {
            get { return lblExpirationDate.Text; }
            set { lblExpirationDate.Text = value; }
        }

        [Browsable(true)]
        [Category("Misc Controls Properties")]
        public string IsDetained
        {
            get { return lblIsDetained.Text; }
            set { lblIsDetained.Text = value; }
        }

        [Browsable(true)]
        [Category("Misc Controls Properties")]
        public string ContainerDriverLicense
        {
            get { return gbDriverLicense.Text; }
            set { gbDriverLicense.Text = value; }
        }

        [Browsable(true)]
        [Category("Misc Controls Properties")]
        public Image ImagePerson
        {
            get { return pbImagePerson.Image; }
            set { pbImagePerson.Image = value; }
        }

        public string ImagePersonLocation
        {
            get { return pbImagePerson.ImageLocation; }
            set { pbImagePerson.ImageLocation = value; }
        }

        private string _GetIssueReasonString(int ReasonId)
        {
            switch (ReasonId)
            {
                case 1:
                    return "First Time";
                case 2:
                    return "Renew";
                case 3:
                    return "Replacement for Damaged";
                default:
                    return "Replacement for Lost";
            }
        }

        public bool LoadDriverLicenseInfo(int ApplicationID)
        {
           
            _Application = clsApplication.Find(ApplicationID);
            if (_Application == null)
            {
                this.ClassName = "[???]";
                this.NamePerson = "[???]";
                this.LicenseID = "[???]";
                this.NationalNo = "[???]";
                this.GenderPerson = "[???]";
                this.IssueDate = "[???]";
                this.IssueReason = "[???]";
                this.Notes = "[???]";
                this.IsActive = "[???]";
                this.DateOfBirth = "[???]";
                this.DriverID = "[???]";
                this.ExpirationDate = "[???]";
                this.IsDetained = "[???]"; ;
                this.ImagePerson = Resources.Male_512;
                return false;
            }
            _Person = clsPerson.Find(_Application.ApplicantPersonID);
            _License = clsLicense.FindByApplicationID(_Application.ApplicationID);

            if (_Person != null && _License != null)
            {
                this.ClassName = clsLicenseClass.Find(_License.LicenseClass).ClassName;
                this.NamePerson = _Person.FullName;
                this.LicenseID = _License.LicenseID.ToString();
                this.NationalNo = _Person.NationalNo;
                this.GenderPerson = _Person.Gender == 0 ? "Male" : "Female";
                this.IssueDate = _License.IssueDate.ToString("d/MMM/yyyy");
                this.IssueReason = _GetIssueReasonString(_License.IssueReason);
                this.Notes = string.IsNullOrWhiteSpace(_License.Notes) == true?"No Notes":_License.Notes;
                this.IsActive = _License.IsActive == true ? "Yes" : "No";
                this.DateOfBirth = _Person.DateOfBirth.ToString("d/M/yyyy");
                this.DriverID = _License.DriverID.ToString();
                this.ExpirationDate = _License.ExpirationDate.ToString("d/MMM/yyyy");
                // this.IsDetained = clsDetaineLicense.Find(_License.LicenseID).IsReleased == true ?"Yes":"NO";
                if (File.Exists(_Person.ImagePath))
                {
                   // this.ImagePerson = Image.FromFile(_Person.ImagePath);
                   this.ImagePersonLocation = _Person.ImagePath;
                }
                else
                {
                    this.ImagePerson = _Person.Gender == 0 ? Resources.person_man : Resources.person_woman;
                }
                return true;
            }
            return false;
        }
    }
}
