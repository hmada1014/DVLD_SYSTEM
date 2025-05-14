using Bunifu.Framework;
using DVLDSystem_BusinessLayer_;
using DVLDSystem_WindowsForm_.Properties;
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

namespace DVLDSystem_WindowsForm_.User_Control
{
    public partial class ucInternationalLicenseInfo : UserControl
    {
        private clsApplication _Application;
        private clsPerson _Person;
        private clsInternationalLicense _internationalLicense;
        public ucInternationalLicenseInfo()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        [Category("Misc Controls Properties")]
        public string InternationalLicenseID
        {
            get { return lblInternationalLicenseID.Text; }
            set { lblInternationalLicenseID.Text = value; }
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
        public string ContainerDriverLicense
        {
            get { return gbDriverLicense.Text; }
            set { gbDriverLicense.Text = value; }
        }

        [Browsable(true)]
        [Category("Misc Controls Properties")]
        public string ApplicationID
        {
            get { return lblApplicationID.Text; }
            set { lblApplicationID.Text = value; }
        }


        [Browsable(true)]
        [Category("Misc Controls Properties")]
        public Image ImagePerson
        {
            get { return pbImagePerson.Image; }
            set { pbImagePerson.Image = value; }
        }


        public bool LoadDriverLicenseInfo(int ApplicationID)
        {

            _Application = clsApplication.Find(ApplicationID);

            if (_Application == null)
            {
                this.ApplicationID = "[???]";
                this.LicenseID = "[???]";
                this.InternationalLicenseID = "[???]";
                this.NamePerson = "[???]";
                this.LicenseID = "[???]";
                this.NationalNo = "[???]";
                this.GenderPerson = "[???]";
                this.IssueDate = "[???]";
                this.IsActive = "[???]";
                this.DateOfBirth = "[???]";
                this.DriverID = "[???]";
                this.ExpirationDate = "[???]";
                this.ImagePerson = Resources.Male_512;
                return false;
            }
            _Person = clsPerson.Find(_Application.ApplicantPersonID);
            _internationalLicense = clsInternationalLicense.Find(_Application.ApplicationID, "");
            if (_Person != null && _internationalLicense != null)
            {
                this.ApplicationID = _internationalLicense.ApplicationID.ToString();
                this.InternationalLicenseID = _internationalLicense.InternationalLicenseID.ToString();
                this.NamePerson = _Person.FullName;
                this.LicenseID = _internationalLicense.IssuedUsingLocalLicenseID.ToString();
                this.NationalNo = _Person.NationalNo;
                this.GenderPerson = _Person.Gender == 0 ? "Male" : "Female";
                this.IssueDate = _internationalLicense.IssueDate.ToString("d/MMM/yyyy");
                this.IsActive = _internationalLicense.IsActive== true ? "Yes" : "No";
                this.DateOfBirth = _Person.DateOfBirth.ToString("d/M/yyyy");
                this.DriverID = _internationalLicense.DriverID.ToString();
                this.ExpirationDate = _internationalLicense.ExpirationDate.ToString("d/MMM/yyyy");
                // this.IsDetained = clsDetaineLicense.Find(_License.LicenseID).IsReleased == true ?"Yes":"NO";
                if (File.Exists(_Person.ImagePath))
                {
                    this.ImagePerson = Image.FromFile(_Person.ImagePath);
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
