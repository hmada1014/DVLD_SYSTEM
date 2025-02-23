using DVLDSystem_DataAccessLayer_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDSystem_BusinessLayer_
{
    public class clsDriver
    {
        public enum enDriverMode { Add = 0, Update = 1 }
        public enDriverMode Mode = enDriverMode.Add;

        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }


        public clsDriver()

        {
            this.DriverID = -1;
            this.PersonID = -1;
            this.CreatedByUserID = -1;
            this.CreatedDate = DateTime.MinValue;


            this.Mode = enDriverMode.Add;

        }

        private clsDriver(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;


            this.Mode = enDriverMode.Update;

        }
        public static clsDriver Find(int DriverID)
        {
            int PersonID = -1, CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.MinValue;

            if (clsDriverDataAccessLayer .GetDriverInfoByDriverID(DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate))
            {
                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            }
            else
            {
                return null;
            }
        }
        public static bool IsDriverExist(int DriverID)
        {
            return clsDriverDataAccessLayer.IsDriverExist(DriverID);
        }
        private bool _AddNewDriver()
        {
            this.DriverID = clsDriverDataAccessLayer.AddNewDriver(this.PersonID, this.CreatedByUserID, this.CreatedDate);
            return (this.DriverID != -1);
        }
        private bool _UpdateDriver()
        {
            return clsDriverDataAccessLayer.UpdateDriverByDriverID(this.DriverID, this.PersonID, this.CreatedByUserID, this.CreatedDate);
        }
        public static bool DeleteDriver(int DriverID)
        {
           return clsDriverDataAccessLayer.DeleteDriverByDriverID(DriverID);
        }
        public static DataView GetAllDrivers()
        {
            return clsDriverDataAccessLayer.GetAllDriver();
        }
        public bool Save()
        {
            switch (this.Mode)
            {
                case enDriverMode.Add:
                    if (_AddNewDriver())
                    {
                        this.Mode = enDriverMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enDriverMode.Update:
                    return _UpdateDriver();
            }
            return false;
        }
    }



}
