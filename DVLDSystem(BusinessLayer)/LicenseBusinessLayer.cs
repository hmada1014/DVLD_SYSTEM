using DVLDSystem_DataAccessLayer_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace DVLDSystem_BusinessLayer_
{
    public class clsLicense : clsApplication
    {
        private static clsApplication _Application;
        private clsLicense _License;
        private clsLicenseClass _LicenseClass;
        private clsDriver _Driver;
        private enum enApplicationType
        {
            FirstTime = 1,
            Renew = 2,
            ReplacementforLost = 3,
            ReplacementDamaged = 4
        }
        private enum enApplicationStatus
        {
            New = 1,
            Completed = 3
        }
        public enum enLicenseMode { Add = 0, Update = 1 }
        public enLicenseMode Mode = enLicenseMode.Add;

        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClass { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public byte IssueReason { get; set; }
        public int CreatedByUserID { get; set; }


        public clsLicense() : base()

        {
            this.LicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.LicenseClass = -1;
            this.IssueDate = DateTime.MinValue;
            this.ExpirationDate = DateTime.MinValue;
            this.Notes = string.Empty;
            this.PaidFees = -1;
            this.IsActive = false;
            this.IssueReason = 0;
            this.CreatedByUserID = -1;


            this.Mode = enLicenseMode.Add;
            base.Mode = clsApplication.enApplicationMode.Add;


        }

        private clsLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate, decimal ApplicationPaidFees) :
                      base(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, ApplicationPaidFees, CreatedByUserID)
        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClass = LicenseClass;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;


            this.Mode = enLicenseMode.Update;
            base.Mode = clsApplication.enApplicationMode.Update;
        }
        public static clsLicense Find(int LicenseID)
        {
            int ApplicationID = -1, DriverID = -1, LicenseClass = -1, CreatedByUserID = -1;
            DateTime IssueDate = DateTime.MinValue, ExpirationDate = DateTime.MinValue;
            string Notes = string.Empty;
            decimal PaidFees = -1;
            bool IsActive = false;
            byte IssueReason = 0;


            if (clsLicenseDataAccessLayer.GetLicenseInfoByLicenseID(LicenseID, ref ApplicationID, ref DriverID, ref LicenseClass, ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))
            {
                _Application = clsApplication.Find(ApplicationID);
                if (_Application != null)
                {

                    return new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClass,
                                          IssueDate, ExpirationDate, Notes, PaidFees, IsActive,
                                           IssueReason, CreatedByUserID, _Application.ApplicantPersonID,
                                           _Application.ApplicationDate, _Application.ApplicationTypeID,
                                           _Application.ApplicationStatus, _Application.LastStatusDate,
                                           _Application.PaidFees);


                }
            }

            return null;
        }

        public static clsLicense FindByApplicationID(int ApplicationID)
        {
            int LicenseID = -1, DriverID = -1, LicenseClass = -1, CreatedByUserID = -1;
            DateTime IssueDate = DateTime.MinValue, ExpirationDate = DateTime.MinValue;
            string Notes = string.Empty;
            decimal PaidFees = -1;
            bool IsActive = false;
            byte IssueReason = 0;


            if (clsLicenseDataAccessLayer.GetLicenseInfoByApplicationID(ApplicationID, ref LicenseID, ref DriverID, ref LicenseClass, ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))
            {
                _Application = clsApplication.Find(ApplicationID);
                if (_Application != null)
                {
                    return new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClass,
                                          IssueDate, ExpirationDate, Notes, PaidFees, IsActive,
                                           IssueReason, CreatedByUserID, _Application.ApplicantPersonID,
                                           _Application.ApplicationDate, _Application.ApplicationTypeID,
                                           _Application.ApplicationStatus, _Application.LastStatusDate,
                                           _Application.PaidFees);
                }
            }
            return null;
        }

        public static int GetLocalDrivingLicenseIDByLicenseID(int LicensID)
        {
            return clsLicenseDataAccessLayer.GetLocalDrivingLicenseIDByLicenseID(LicensID);
        }

        public static int GetApplicationID(int LicenseID)
        {
            return clsLicenseDataAccessLayer.GetApplicationIDByLicenseID(LicenseID);
        }
        public static bool IsLicenseExist(int LicenseID)
        {
            return clsLicenseDataAccessLayer.IsLicenseExist(LicenseID);
        }
        private bool _AddNewLicense()
        {
            if (base.Save())
            {
                if (base.ApplicationID != -1)
                {
                    this.LicenseID = clsLicenseDataAccessLayer.AddNewLicense(base.ApplicationID, this.DriverID, this.LicenseClass, this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, this.IssueReason, this.CreatedByUserID);
                }
            }
            return (this.LicenseID != -1);
        }
        private bool _UpdateLicense()
        {
            if (base.Save())
            {
                return clsLicenseDataAccessLayer.UpdateLicenseByLicenseID(this.LicenseID, this.ApplicationID, this.DriverID, this.LicenseClass, this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, this.IssueReason, this.CreatedByUserID);
            }
            return false;
        }

        private bool _SaveDriverFirstTime(clsLocalDrivingLicenseApplication LDLApplication, int UserID)
        {
            if (LDLApplication != null)
            {
                _Driver = new clsDriver();
                _Driver.CreatedDate = DateTime.Now;
                _Driver.CreatedByUserID = UserID;
                _Driver.PersonID = LDLApplication.ApplicantPersonID;
                return _Driver.Save();
            }
            return false;
        }
        private bool _SaveLicenseFirstTime(clsLocalDrivingLicenseApplication LDLApplication, int UserID, string txtNotes)
        {
            if (LDLApplication != null)
            {
                base.Mode = enApplicationMode.Update;

                base.ApplicationID = LDLApplication.ApplicationID;
                base.ApplicantPersonID = LDLApplication.ApplicantPersonID;
                base.ApplicationDate = LDLApplication.ApplicationDate;
                base.ApplicationTypeID = LDLApplication.ApplicationTypeID;
                base.ApplicationStatus = (int)enApplicationStatus.Completed;
                base.LastStatusDate = DateTime.Now;
                base.PaidFees = LDLApplication.PaidFees;
                base.CreatedByUserID = LDLApplication.CreatedByUserID;




                this.DriverID = _Driver.DriverID;
                this.LicenseClass = LDLApplication.LicenseClassID;
                this.IssueDate = DateTime.Now;
                this.ExpirationDate = this.IssueDate.AddYears(clsLicenseClass.Find(LDLApplication.LicenseClassID).DefaultValidityLength);
                this.Notes = txtNotes;
                this.PaidFees = clsLicenseClass.Find(LDLApplication.LicenseClassID).ClassFees;
                this.IsActive = true;
                this.IssueReason = (byte)enApplicationType.FirstTime;
                this.CreatedByUserID = UserID;

                return this.Save();
            }
            return false;
        }
        public int IssueFirstTimeLicense(clsLocalDrivingLicenseApplication LDLApplication, int UserID, string txtNotes)
        {
            _Driver = new clsDriver();
            _Driver.DriverID = clsDriver.GetDriverIDByPersonID(LDLApplication.ApplicantPersonID);
            if (_Driver.DriverID == -1)
            {
                if (LDLApplication != null)
                {
                    if (_SaveDriverFirstTime(LDLApplication, UserID))
                    {
                        if (_SaveLicenseFirstTime(LDLApplication, UserID, txtNotes))
                        {
                            return this.LicenseID;
                        }
                    }
                }
            }
            else
            {

                if (_SaveLicenseFirstTime(LDLApplication, UserID, txtNotes))
                {
                    return this.LicenseID;
                }
            }
            return -1;

        }


        private bool _SaveApplicationRenew(clsLicense OldLicense, int UserID)
        {
            if (OldLicense != null)
            {
                base.ApplicantPersonID = OldLicense.ApplicantPersonID;
                base.ApplicationDate = DateTime.Now;
                base.ApplicationTypeID = (int)enApplicationType.Renew;
                base.ApplicationStatus = (int)enApplicationStatus.Completed;
                base.LastStatusDate = DateTime.Now;
                base.PaidFees = clsApplicationTypes.Find((int)enApplicationType.Renew).ApplicationFees;
                base.CreatedByUserID = UserID;
                return base.Save();
            }
            return false;
        }
        private bool _SaveLicenseForRenew(clsLicense OldLicense, int UserID, int ApplicationID , string Notes)
        {
            _LicenseClass = clsLicenseClass.Find(OldLicense.LicenseClass);
            if (OldLicense != null && _LicenseClass != null)
            {

                this.ApplicationID = ApplicationID;
                this.DriverID = OldLicense.DriverID;
                this.LicenseClass = OldLicense.LicenseClass;
                this.IssueDate = DateTime.Now;
                this.ExpirationDate = DateTime.Now.AddYears(_LicenseClass.DefaultValidityLength);
                this.Notes = Notes;
                this.PaidFees = _LicenseClass.ClassFees;
                this.IsActive = true;
                this.IssueReason = (byte)enApplicationType.Renew;
                this.CreatedByUserID = UserID;
                base.CreatedByUserID = UserID;

                return this.Save();
            }

            return false;
        }
        private bool _SaveOldLicenseForRenew(clsLicense OldLicense)
        {
            OldLicense.IsActive = false;
            return OldLicense.Save();
        }
        public int IssueRenewLicense(clsLicense OldLicense, int UserID , string Note)
        {
            if (OldLicense == null)
                return -1;
            if ((DateTime.Now < OldLicense.ExpirationDate) || OldLicense.IsActive == false|| clsDetaineLicense.IsLicenseDetained(OldLicense.LicenseID))
            {
                return -1;
            }
            else
            {
                if (_SaveApplicationRenew(OldLicense, UserID))
                {
                    if (_SaveLicenseForRenew(OldLicense, UserID, base.ApplicationID,Note))
                    {
                        if (_SaveOldLicenseForRenew(OldLicense))
                        {
                            return this.LicenseID;
                        }
                    }
                }
            }


            return -1;

        }


        private enApplicationType _GetApplicationType(int ReplacementStatus)
        {
            return (ReplacementStatus == 3) ? enApplicationType.ReplacementforLost: enApplicationType.ReplacementDamaged;
        }
        private bool _SaveApplicationReplacement(clsLicense OldLicense, int UserID, enApplicationType AppType)
        {
            if (OldLicense != null)
            {
                base.ApplicantPersonID = OldLicense.ApplicantPersonID;
                base.ApplicationDate = DateTime.Now;
                base.ApplicationTypeID = (int)AppType;
                base.ApplicationStatus = (int)enApplicationStatus.Completed;
                base.LastStatusDate = DateTime.Now;
                base.PaidFees = clsApplicationTypes.Find((int)AppType).ApplicationFees;
                base.CreatedByUserID = UserID;
                return base.Save();
            }
            return false;
        }
        private bool _SaveLicenseForReplacement(clsLicense OldLicense, int UserID, int ApplicationID, enApplicationType AppType)
        {
            _LicenseClass = clsLicenseClass.Find(OldLicense.LicenseClass);
            if (OldLicense != null && _LicenseClass != null)
            {

                this.ApplicationID = ApplicationID;
                this.DriverID = OldLicense.DriverID;
                this.LicenseClass = OldLicense.LicenseClass;
                this.IssueDate = DateTime.Now;
                this.ExpirationDate = DateTime.Now.AddYears(_LicenseClass.DefaultValidityLength);
                this.Notes = OldLicense.Notes;
                this.PaidFees = _LicenseClass.ClassFees;
                this.IsActive = true;
                this.IssueReason = (byte)AppType;
                this.CreatedByUserID = UserID;
                base.CreatedByUserID = UserID;

                return this.Save();
            }

            return false;
        }
        private bool _SaveOldLicenseForReplacement(clsLicense OldLicense)
        {
            OldLicense.IsActive = false;
            return OldLicense.Save();
        }
        public int IssueReplacementLicense(clsLicense OldLicense, int UserID, int ReplacementStatus)
        {
            if (OldLicense == null)
                return -1;
            if (!(OldLicense.ExpirationDate > DateTime.Now) || OldLicense.IsActive == false || clsDetaineLicense.IsLicenseDetained(OldLicense.LicenseID))
            {
                return -1;
            }
            else
            {
                if (_SaveApplicationReplacement(OldLicense,UserID,_GetApplicationType(ReplacementStatus)))
                {
                    if (_SaveLicenseForReplacement(OldLicense, UserID,base.ApplicationID ,_GetApplicationType(ReplacementStatus)))
                    {
                        if (_SaveOldLicenseForReplacement(OldLicense))
                        {
                            return this.LicenseID;
                        }
                    }
                }

            }


            return -1;
        }
        public static bool DeleteLicense(int LicenseID)
        {
            return clsLicenseDataAccessLayer.DeleteLicenseByLicenseID(LicenseID);
        }

        public static DataView GetAllLocalLicenseByDriverID(int DriverId)
        {
            return clsLicenseDataAccessLayer.GetAllLocalLicenseByDriverID(DriverId);
        }

        public static DataView GetAllLicenses()
        {
            return clsLicenseDataAccessLayer.GetAllLicense();
        }
        public override bool Save()
        {
            switch (this.Mode)
            {
                case enLicenseMode.Add:
                    if (_AddNewLicense())
                    {
                        this.Mode = enLicenseMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enLicenseMode.Update:
                    return _UpdateLicense();
            }
            return false;
        }
    }


}
