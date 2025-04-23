using DVLDSystem_DataAccessLayer_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDSystem_BusinessLayer_
{

    public class clsLocalDrivingLicenseApplication : clsApplication
    {

        private static clsApplication _Application;
        public enum enLocalDrivingLicenseApplicationMode { Add = 0, Update = 1 }
        public enLocalDrivingLicenseApplicationMode Mode = enLocalDrivingLicenseApplicationMode.Add;

        public int LocalDrivingLicenseApplicationID { get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }


        public clsLocalDrivingLicenseApplication():base()

        {
            this.LocalDrivingLicenseApplicationID = -1;
            this.ApplicationID = -1;
            this.LicenseClassID = -1;
            this.Mode = enLocalDrivingLicenseApplicationMode.Add;

            base.Mode = clsApplication.enApplicationMode.Add;

        }
        private clsLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID) :
                                             base(ApplicationID,ApplicantPersonID,ApplicationDate,ApplicationTypeID,ApplicationStatus,LastStatusDate ,PaidFees,CreatedByUserID)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.ApplicationID = ApplicationID;
            this.LicenseClassID = LicenseClassID;
            this.Mode = enLocalDrivingLicenseApplicationMode.Update;

            base.Mode = clsApplication.enApplicationMode.Update;



        }
        private bool _AddNewLocalDrivingLicenseApplication()
        {
            if (base.Save())
            {
                if (base.ApplicationID != -1)
                {
                    this.LocalDrivingLicenseApplicationID = clsLocalDrivingLicenseApplicationDataAccess.AddNewLocalDrivingLicenseApplication(base.ApplicationID, this.LicenseClassID);
                }
            }
            return (this.LocalDrivingLicenseApplicationID != -1);
        }
        private bool _UpdateLocalDrivingLicenseApplication()
        {
            if (base.Save())
            {
                return clsLocalDrivingLicenseApplicationDataAccess.UpdateLocalDrivingLicenseApplicationByID(this.LocalDrivingLicenseApplicationID, this.ApplicationID, this.LicenseClassID);
            }
            return false;
        }
        public override bool Save()
        {
            switch (this.Mode)
            {
                case enLocalDrivingLicenseApplicationMode.Add:
                    if (_AddNewLocalDrivingLicenseApplication())
                    {
                        this.Mode = enLocalDrivingLicenseApplicationMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enLocalDrivingLicenseApplicationMode.Update:
                    return _UpdateLocalDrivingLicenseApplication();
            }
            return false;
        }
        public static clsLocalDrivingLicenseApplication Find(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = -1, LicenseClassID = -1;

            if (clsLocalDrivingLicenseApplicationDataAccess.GetLocalDrivingLicenseApplicationInfoByID(LocalDrivingLicenseApplicationID, ref ApplicationID, ref LicenseClassID))
            {

                _Application = clsApplication.Find(ApplicationID);
                if (_Application != null)
                {
                    return new clsLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, ApplicationID, LicenseClassID,_Application.ApplicantPersonID,_Application.ApplicationDate,_Application.ApplicationTypeID,_Application.ApplicationStatus,_Application.LastStatusDate,_Application.PaidFees,_Application.CreatedByUserID);

                } 
            }
            
                return null;
            
        }
        public static bool IsLocalDrivingLicenseApplicationExist(int LocalDrivingLicenseApplicationID)
        {
            return clsLocalDrivingLicenseApplicationDataAccess.IsLocalDrivingLicenseApplicationExist(LocalDrivingLicenseApplicationID);
        }
        public static bool IsPersonHasSameLicenseClassExist(int ApplicantPersonID , int LicenseClassID )
        {
            return clsLocalDrivingLicenseApplicationDataAccess.IsPersonHasSameLicenseClassExistAndGetApplicationID (ApplicantPersonID , LicenseClassID);
        }
        public static int GetApplicationIDByApplicantPersonIDAndLicenseClassID(int ApplicantPersonID, int LicenseClassID)
        {
            return clsLocalDrivingLicenseApplicationDataAccess.GetApplicationIDByApplicantPersonIDAndLicenseClassID(ApplicantPersonID,LicenseClassID);
        }
        public static bool DeleteLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            return clsLocalDrivingLicenseApplicationDataAccess.DeleteLocalDrivingLicenseApplicationByID(LocalDrivingLicenseApplicationID);
        }
        public static DataView GetAllLocalDrivingLicenseApplications()
        {
            return clsLocalDrivingLicenseApplicationDataAccess.GetAllLocalDrivingLicenseApplication();
        }
    }
}
