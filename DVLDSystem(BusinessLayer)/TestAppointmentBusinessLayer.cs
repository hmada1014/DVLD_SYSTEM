using DVLDSystem_DataAccessLayer_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDSystem_BusinessLayer_
{
    public class clsTestAppointment
    {
        public enum enTestAppointmentMode { Add = 0, Update = 1 }
        public enTestAppointmentMode Mode = enTestAppointmentMode.Add;

        public int TestAppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }


        public clsTestAppointment()

        {
            this.TestAppointmentID = -1;
            this.TestTypeID = -1;
            this.LocalDrivingLicenseApplicationID = -1;
            this.AppointmentDate = DateTime.MinValue;
            this.PaidFees = -1;
            this.CreatedByUserID = -1;
            this.IsLocked = false;


            this.Mode = enTestAppointmentMode.Add;


        }

        private clsTestAppointment(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID, bool IsLocked)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;


            this.Mode = enTestAppointmentMode.Update;

        }
        public static clsTestAppointment Find(int TestAppointmentID)
        {
            int LicenseID = -1,TestTypeID = -1,LocalDrivingLicenseApplicationID = -1,CreatedByUserID = -1;

            DateTime AppointmentDate = DateTime.MinValue;
            decimal PaidFees = -1m;
            bool IsLocked = false;

            
            if (clsTestAppointmentDataAccessLayer.GetTestAppointmentInfoByTestAppointmentID(TestAppointmentID, ref TestTypeID, ref LocalDrivingLicenseApplicationID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked))
            {
                return new clsTestAppointment(TestAppointmentID,TestTypeID,LocalDrivingLicenseApplicationID,AppointmentDate,  PaidFees,  CreatedByUserID,  IsLocked);
            }
            else
            {
                return null;
            }
        }
        public static bool IsTestAppointmentExist(int TestAppointmentID)
        {
            return clsTestAppointmentDataAccessLayer.IsTestAppointmentExist(TestAppointmentID);
        }
        private bool _AddNewTestAppointment()
        {
            this.TestAppointmentID = clsTestAppointmentDataAccessLayer.AddNewTestAppointment(this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked);
            return (this.TestAppointmentID != -1);
        }
        private bool _UpdateTestAppointment()
        {
            return clsTestAppointmentDataAccessLayer.UpdateTestAppointmentByTestAppointmentID(this.TestAppointmentID, this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked);
        }
        public static bool DeleteTestAppointment(int TestAppointmentID)
        {
            return clsTestAppointmentDataAccessLayer.DeleteTestAppointmentByTestAppointmentID(TestAppointmentID);
        }
        public static DataView GetAllTestAppointments()
        {
            return clsTestAppointmentDataAccessLayer.GetAllTestAppointment();
        }
        public bool Save()
        {
            switch (this.Mode)
            {
                case enTestAppointmentMode.Add:
                    if (_AddNewTestAppointment())
                    {
                        this.Mode = enTestAppointmentMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enTestAppointmentMode.Update:
                    return _UpdateTestAppointment();
            }
            return false;
        }
    }



}
