using DVLDSystem_DataAccessLayer_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DVLDSystem_BusinessLayer_
{
    public class clsDetaineLicense
    {
        public enum enDetainMode { Add = 0, Update = 1 }
        public enDetainMode Mode = enDetainMode.Add;

        public int DetainID { get; set; }
        public int LicenseID { get; set; }
        public DateTime DetainDate { get; set; }
        public decimal FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ReleasedByUserID { get; set; }
        public int ReleaseApplicationID { get; set; }


        public clsDetaineLicense()

        {
            this.DetainID = -1;
            this.LicenseID = -1;
            this.DetainDate = DateTime.Now;
            this.FineFees = -1;
            this.CreatedByUserID = -1;
            this.IsReleased = false;
            this.ReleaseDate = DateTime.Now;
            this.ReleasedByUserID = -1;
            this.ReleaseApplicationID = -1;


            this.Mode = enDetainMode.Add;


        }

        private clsDetaineLicense(int DetainID, int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;


            this.Mode = enDetainMode.Update;

        }
        public static clsDetaineLicense Find(int DetainID)
        {
            int LicenseID = -1, CreatedByUserID = -1, ReleasedByUserID = -1, ReleaseApplicationID = -1;
            DateTime DetainDate = DateTime.Today, ReleaseDate = DateTime.Today;
            decimal FineFees = -1;
            bool IsReleased = false;

            if (clsDetaineLicenseDataAccessLayer.GetDetainInfoByDetainID(DetainID, ref LicenseID, ref DetainDate, ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
            {
                return new clsDetaineLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            }
            else
            {
                return null;
            }
        }
        public static bool IsDetainExist(int DetainID)
        {
            return clsDetaineLicenseDataAccessLayer.IsDetainExist(DetainID);
        }
        private bool _AddNewDetain()
        {
            this.DetainID = clsDetaineLicenseDataAccessLayer.AddNewDetain(this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID, this.IsReleased, this.ReleaseDate, this.ReleasedByUserID, this.ReleaseApplicationID);
            return (this.DetainID != -1);
        }
        private bool _UpdateDetain()
        {
            return clsDetaineLicenseDataAccessLayer.UpdateDetainByDetainID(this.DetainID, this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID, this.IsReleased, this.ReleaseDate, this.ReleasedByUserID, this.ReleaseApplicationID);
        }
        public static bool DeleteDetain(int DetainID)
        {
            return clsDetaineLicenseDataAccessLayer.DeleteDetainByDetainID(DetainID);
        }
        public static DataView GetAllDetains()
        {
            return clsDetaineLicenseDataAccessLayer.GetAllDetain();
        }
        public bool Save()
        {
            switch (this.Mode)
            {
                case enDetainMode.Add:
                    if (_AddNewDetain())
                    {
                        this.Mode = enDetainMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enDetainMode.Update:
                    return _UpdateDetain();
            }
            return false;
        }
    }


}
