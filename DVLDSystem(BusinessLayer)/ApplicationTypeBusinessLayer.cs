using DVLDSystem_DataAccessLayer_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDSystem_BusinessLayer_
{
    public class clsApplicationTypes
    {
        public enum enApplicationTypeMode { Add = 0, Update = 1 }
        public enApplicationTypeMode Mode = enApplicationTypeMode.Add;

        public int ApplicationTypeID { get; set; }
        public string ApplicationTypeTitle { get; set; }
        public decimal ApplicationFees { get; set; }


        public clsApplicationTypes()

        {
            this.ApplicationTypeID = -1;
            this.ApplicationTypeTitle = string.Empty;
            this.ApplicationFees = -1;

            this.Mode = enApplicationTypeMode.Add;
        }

        private clsApplicationTypes(int ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationFees)
        {
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeTitle = ApplicationTypeTitle;
            this.ApplicationFees = ApplicationFees;

            this.Mode = enApplicationTypeMode.Update;
        }
        public static clsApplicationTypes Find(int ApplicationTypeID)
        {
            decimal ApplicationFees = -1;
            string ApplicationTypeTitle = string.Empty;

            if (clsApplicationTypeDataAccessLayer.GetApplicationTypeIDInfoByApplicationTypeID(ApplicationTypeID, ref ApplicationTypeTitle, ref ApplicationFees))
            {
                return new clsApplicationTypes(ApplicationTypeID, ApplicationTypeTitle, ApplicationFees);
            }
            else
            {
                return null;
            }
        }
        public static bool IsApplicationTypeExist(int ApplicationTypeID)
        {
            return clsApplicationTypeDataAccessLayer.IsApplicationTypeIDExist(ApplicationTypeID);
        }
        private bool _AddNewApplicationType()
        {
            this.ApplicationTypeID = clsApplicationTypeDataAccessLayer.AddNewApplicationTypeID(this.ApplicationTypeTitle, this.ApplicationFees);
            return (this.ApplicationTypeID != -1);
        }
        private bool _UpdateApplicationType()
        {
            return clsApplicationTypeDataAccessLayer.UpdateApplicationTypeIDByApplicationTypeID(this.ApplicationTypeID, this.ApplicationTypeTitle, this.ApplicationFees);
        }
        public static bool DeleteApplicationType(int ApplicationTypeID)
        {
            return clsApplicationDataAccessLayer.DeleteApplicationByApplicationID(ApplicationTypeID);
        }
        public static DataView GetAllApplicationTypes()
        {
            return clsApplicationTypeDataAccessLayer.GetAllApplicationTypeID();
        }
        public bool Save()
        {
            switch (this.Mode)
            {
                case enApplicationTypeMode.Add:
                    if (_AddNewApplicationType())
                    {
                        this.Mode = enApplicationTypeMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enApplicationTypeMode.Update:
                    return _UpdateApplicationType();
            }
            return false;
        }
    }



}
