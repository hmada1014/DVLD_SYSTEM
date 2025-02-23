using DVLDSystem_DataAccessLayer_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDSystem_BusinessLayer_
{

    public class clsLocalDrivingLicenseApplication
    {
        public enum enLocalDrivingLicenseApplicationMode { Add = 0, Update = 1 }
        public enLocalDrivingLicenseApplicationMode Mode = enLocalDrivingLicenseApplicationMode.Add;

        public int LocalDrivingLicenseApplicationID { get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }


        public clsLocalDrivingLicenseApplication()

        {
            this.LocalDrivingLicenseApplicationID = -1;
            this.ApplicationID = -1;
            this.LicenseClassID = -1;


            this.Mode = enLocalDrivingLicenseApplicationMode.Add;


        }

        private clsLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.ApplicationID = ApplicationID;
            this.LicenseClassID = LicenseClassID;


            this.Mode = enLocalDrivingLicenseApplicationMode.Update;

        }
        public static clsLocalDrivingLicenseApplication Find(int LocalDrivingLicenseApplicationID)
        {
            /* remove ref and add Minimum value any dataType accept number = -1 in one line:int LocalDrivingLicenseApplicationID , ref int ApplicationID , ref int LicenseClassID ,
             make it organize */
            if (/* call data access to get by ref --- [LocalDrivingLicenseApplicationID ,ref ApplicationID ,ref LicenseClassID]*/)
            {
                return new clsLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, ApplicationID, LicenseClassID);
            }
            else
            {
                return null;
            }
        }
        public static bool IsLocalDrivingLicenseApplicationExist(int LocalDrivingLicenseApplicationID)
        {
            return clsLocalDrivingLicenseApplicationDataAccess.IsLocalDrivingLicenseApplicationExist(LocalDrivingLicenseApplicationID);
        }
        private bool _AddNewLocalDrivingLicenseApplication()
        {
            this.LocalDrivingLicenseApplicationID = -1; /*Function from data access*/
            return (this.LocalDrivingLicenseApplicationID != -1);
        }
        private bool _UpdateLocalDrivingLicenseApplication()
        {
            return clsLocalDrivingLicenseApplicationDataAccess.UpdateLocalDrivingLicenseApplicationByID(this.LocalDrivingLicenseApplicationID, this.ApplicationID, this.LicenseClassID);
        }
        public static bool DeleteLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            return clsLocalDrivingLicenseApplicationDataAccess.DeleteLocalDrivingLicenseApplicationByLocalDrivingLicenseApplicationID(LocalDrivingLicenseApplicationID);
        }
        public static DataView GetAllLocalDrivingLicenseApplications()
        {
            /* return from data access function*/
        }
        public bool Save()
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
    }





}
