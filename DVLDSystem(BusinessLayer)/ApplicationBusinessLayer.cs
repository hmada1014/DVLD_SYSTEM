using DVLDSystem_DataAccessLayer_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDSystem_BusinessLayer_
{
    public class clsApplication
    {
        public enum enApplicationMode { Add = 0, Update = 1 }
        public enApplicationMode Mode = enApplicationMode.Add;

        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public byte ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }


        public clsApplication()

        {
            this.ApplicationID = -1;
            this.ApplicantPersonID = -1;
            this.ApplicationDate =DateTime.MinValue;
            this.ApplicationTypeID = -1;
            this.ApplicationStatus = 0;
            this.LastStatusDate = DateTime.MinValue;
            this.PaidFees = -1;
            this.CreatedByUserID = -1;


            this.Mode = enApplicationMode.Add;


        }

        private clsApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;


            this.Mode = enApplicationMode.Update;

        }
        public static clsApplication Find(int ApplicationID)
        {
            int  ApplicantPersonID = -1, ApplicationTypeID = -1, CreatedByUserID = -1;
            byte ApplicationStatus = 0;
            DateTime ApplicationDate = DateTime.MinValue, LastStatusDate = DateTime.MinValue;
            decimal PaidFees = -1;


            if (clsApplicationDataAccessLayer.GetApplicationInfoByApplicationID(ApplicationID, ref ApplicantPersonID, ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID))
            {
                return new clsApplication(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }
        public static bool IsApplicationExist(int ApplicationID)
        {
            return clsApplicationDataAccessLayer.IsApplicationExist(ApplicationID);
        }
        private bool _AddNewApplication()
        {
            this.ApplicationID = clsApplicationDataAccessLayer.AddNewApplication(this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID, this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);
            return (this.ApplicationID != -1);
        }
        private bool _UpdateApplication()
        {
            return clsApplicationDataAccessLayer.UpdateApplicationByApplicationID(this.ApplicationID, this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID, this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);
        }
        public static bool DeleteApplication(int ApplicationID)
        {
            return clsApplicationDataAccessLayer.DeleteApplicationByApplicationID(ApplicationID);
        }
        public static DataView GetAllApplications()
        {
            return clsApplicationDataAccessLayer.GetAllApplication();
        }
        public bool Save()
        {
            switch (this.Mode)
            {
                case enApplicationMode.Add:
                    if (_AddNewApplication())
                    {
                        this.Mode = enApplicationMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enApplicationMode.Update:
                    return _UpdateApplication();
            }
            return false;
        }
    }



}
