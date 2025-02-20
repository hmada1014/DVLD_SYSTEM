using DVLDSystem_DataAccessLayer_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDSystem_BusinessLayer_
{
    public class clsLicense
    {
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


        public clsLicense()

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


        }

        private clsLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
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

        }
        public static clsLicense Find(int LicenseID)
        {
            int ApplicationID = -1, DriverID = -1, LicenseClass = -1, CreatedByUserID = -1;
            DateTime IssueDate = DateTime.MinValue, ExpirationDate = DateTime.MinValue;
            string Notes = string.Empty;
            decimal PaidFees = -1;
            bool IsActive = false;
            byte IssueReason = 0;


            if (clsLicenseDataAccessLayer.GetLicenseInfoByLicenseID( LicenseID, ref  ApplicationID, ref  DriverID, ref  LicenseClass, ref  IssueDate, ref  ExpirationDate, ref  Notes, ref  PaidFees, ref  IsActive, ref  IssueReason, ref  CreatedByUserID))
            {
                return new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }
        public static bool IsLicenseExist(int LicenseID)
        {
            return clsLicenseDataAccessLayer.IsLicenseExist(LicenseID);
        }
        private bool _AddNewLicense()
        {
            this.LicenseID = clsLicenseDataAccessLayer.AddNewLicense( this.ApplicationID, this.DriverID, this.LicenseClass, this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, this.IssueReason, this.CreatedByUserID);
            return (this.LicenseID != -1);
        }
        private bool _UpdateLicense()
        {
            return clsLicenseDataAccessLayer.UpdateLicenseByLicenseID(this.LicenseID, this.ApplicationID, this.DriverID, this.LicenseClass, this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, this.IssueReason, this.CreatedByUserID);
        }
        public static bool DeleteLicense(int LicenseID)
        {
            return clsLicenseDataAccessLayer.DeleteLicenseByLicenseID(LicenseID);
        }
        public static DataView GetAllLicenses()
        {
           return clsLicenseDataAccessLayer.GetAllLicense();
        }
        public bool Save()
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
