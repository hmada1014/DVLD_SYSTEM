using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DVLDSystem_DataAccessLayer_;

namespace DVLDSystem_BusinessLayer_
{

    public class clsInternationalLicense : clsApplication
    {
        private static clsApplication _Application;
        public enum enInternationalLicenseMode { Add = 0, Update = 1 }
        public enInternationalLicenseMode Mode = enInternationalLicenseMode.Add;

        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public new int CreatedByUserID { get; set; }


        public clsInternationalLicense() : base()
        {
            this.InternationalLicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.IssuedUsingLocalLicenseID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.IsActive = false;
            this.CreatedByUserID = -1;
            this.Mode = enInternationalLicenseMode.Add;

            base.Mode = clsApplication.enApplicationMode.Add;


        }

        private clsInternationalLicense(int InternationalLicenseID, int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees) :
                                       base(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID)
        {
            this.InternationalLicenseID = InternationalLicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;


            this.Mode = enInternationalLicenseMode.Update;
            base.Mode = clsApplication.enApplicationMode.Update;

        }
        public static new clsInternationalLicense Find(int InternationalLicenseID)
        {
            int ApplicationID = -1, DriverID = -1, CreatedByUserID = -1, IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
            bool IsActive = false;


            if (clsInternationalLicenseDataAccessLayer.GetInternationalLicenseInfoByID(InternationalLicenseID, ref ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate
                                                                                       , ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {
                _Application = clsApplication.Find(ApplicationID);
                if (_Application != null)
                {
                    return new clsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID,
                                                        IssueDate, ExpirationDate, IsActive, CreatedByUserID,
                                                       _Application.ApplicantPersonID, _Application.ApplicationDate,
                                                       _Application.ApplicationTypeID, _Application.ApplicationStatus,
                                                        _Application.LastStatusDate, _Application.PaidFees);

                }
            }

            return null;

        }

        public static  clsInternationalLicense Find(int ApplicationID , string n="")
        {
            int InternationalLicenseID = -1, DriverID = -1, CreatedByUserID = -1, IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
            bool IsActive = false;


            if (clsInternationalLicenseDataAccessLayer.GetInternationalLicenseInfoByApplicationID(ApplicationID,ref InternationalLicenseID,ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate
                                                                                       , ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {
                _Application = clsApplication.Find(ApplicationID);
                if (_Application != null)
                {
                    return new clsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID,
                                                        IssueDate, ExpirationDate, IsActive, CreatedByUserID,
                                                       _Application.ApplicantPersonID, _Application.ApplicationDate,
                                                       _Application.ApplicationTypeID, _Application.ApplicationStatus,
                                                        _Application.LastStatusDate, _Application.PaidFees);

                }
            }

            return null;

        }
        public static bool IsInternationalLicenseExist(int InternationalLicenseID)
        {
            return clsInternationalLicenseDataAccessLayer.IsInternationalLicenseIDExist(InternationalLicenseID);

        }

        public int IssueInternationalLicense(clsLicense License ,int UserID)
        {
            if (License == null)
            {return -1; }
            else if (clsDetaineLicense.IsLicenseDetained(License.LicenseID))
            {return -1;}
            if (License.LicenseClass == 3)
            {
                clsApplicationTypes _ApplicationType = clsApplicationTypes.Find(6);
                if (_ApplicationType == null) { return -1; }
                this.IssuedUsingLocalLicenseID = License.LicenseID;
                this.DriverID = License.DriverID;
                this.IssueDate = DateTime.Now;
                this.ExpirationDate = DateTime.Now.AddYears(1);
                this.IsActive = true;
                base.CreatedByUserID = UserID;
                this.CreatedByUserID = UserID;
                int Id = this.GetApplicationPersonIDByApplicationID(License.ApplicationID);
                if (Id != -1)
                    this.ApplicantPersonID = Id;
                else
                    return -1;

                this.ApplicationDate = DateTime.Now;
                // 3 mean complated
                this.ApplicationStatus = 3;
                // 6 new New International License
                this.ApplicationTypeID = _ApplicationType.ApplicationTypeID;
                this.LastStatusDate = DateTime.Now;
                this.PaidFees = _ApplicationType.ApplicationFees;
                if (this.Save())
                {
                    this.ApplicationID = base.ApplicationID;
                    return this.InternationalLicenseID;
                }
            }

            return -1;


        }

        public static bool IsInternationalLicenseWithLicenseIDExist (int LicenseID, bool IsActive = true)
        {
            return clsInternationalLicenseDataAccessLayer.IsInternationalLicenseWithLicenseIDExist(LicenseID ,IsActive);
        }
        private bool _AddNewInternationalLicense()
        {
            if (base.Save())
            {
                if (base.ApplicationID != -1)
                {
                    this.InternationalLicenseID = clsInternationalLicenseDataAccessLayer.AddNewInternationalLicense(base.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);

                }
            }
            return (this.InternationalLicenseID != -1);


        }
        private bool _UpdateInternationalLicense()
        {
            if (base.Save())
            {
                return clsInternationalLicenseDataAccessLayer.UpdateInternationalLicenseByID(this.InternationalLicenseID, this.ApplicationID, this.DriverID
                                                                                            , this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);
            }
            return false;
        }
        public static int GetApplicationIDByInternationalID(int internationalID)
        {
            return clsInternationalLicenseDataAccessLayer.GetApplicationIDByInternationalID(internationalID);
        }
        public static int GetInternationalLicenseID(int LicenseID)
        {
            return clsInternationalLicenseDataAccessLayer.GetInternationalLicenseIDByLicenseID(LicenseID);
        }
        public static bool DeleteInternationalLicense(int InternationalLicenseID)
        {
            int ApplicationID = GetApplicationIDByInternationalID(InternationalLicenseID);

            if (clsInternationalLicenseDataAccessLayer.DeleteInternationalLicenseByID(InternationalLicenseID))
            {
                return clsApplication.DeleteApplication(ApplicationID);
            }

            return false;
        }
        public static DataView GetAllInternationalLicenses()
        {
            return clsInternationalLicenseDataAccessLayer.GetAllInternationalLicense();
        }
        public static DataView GetAllInternationalLicensesByDriverID(int DriverID)
        {
            return clsInternationalLicenseDataAccessLayer.GetAllInternationalLicenseByDriverID(DriverID);
        }
        public static DataView SearchInternationalLicenseByInternationalLicenseID(string InternationalLicenseID)
        {
            return clsInternationalLicenseDataAccessLayer.SearchInternationalLicenseByInternationalLicenseID(InternationalLicenseID);
        }
        public static DataView SearchInternationalLicenseByDriverID(string DriverID)
        {
            return clsInternationalLicenseDataAccessLayer.SearchInternationalLicenseByDriverID(DriverID);
        }
        public static DataView SearchInternationalLicenseByApplicationID(string ApplicationID)
        {
            return clsInternationalLicenseDataAccessLayer.SearchInternationalLicenseByApplicationID(ApplicationID);

        }
        public override bool Save()
        {
            switch (this.Mode)
            {
                case enInternationalLicenseMode.Add:
                    if (_AddNewInternationalLicense())
                    {
                        this.Mode = enInternationalLicenseMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enInternationalLicenseMode.Update:
                    return _UpdateInternationalLicense();
            }
            return false;
        }
    }


}
