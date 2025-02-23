using DVLDSystem_DataAccessLayer_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace DVLDSystem_BusinessLayer_
{
    public class clsTest
    {
        public enum enTestMode { Add = 0, Update = 1 }
        public enTestMode Mode = enTestMode.Add;

        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }

        public clsTest()

        {
            this.TestID = -1;
            this.TestAppointmentID = -1;
            this.TestResult = false;
            this.Notes = string.Empty;
            this.CreatedByUserID = -1;

            this.Mode = enTestMode.Add;

        }
        private clsTest(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;

            this.Mode = enTestMode.Update;
        }
        public static clsTest Find(int TestID)
        {

            int TestAppointmentID = -1, CreatedByUserID = -1;
            bool TestResult = false;
            string Notes = string.Empty;

            if (clsTestDataAccessLayer.GetTestInfoByTestID(TestID, ref TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID))
            {
                return new clsTest(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }
        public static bool IsTestExist(int TestID)
        {
            return clsTestDataAccessLayer.IsTestExist(TestID);
        }
        private bool _AddNewTest()
        {
            this.TestID = clsTestDataAccessLayer.AddNewTest(this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);
            return (this.TestID != -1);
        }
        private bool _UpdateTest()
        {
            return clsTestDataAccessLayer.UpdateTestByTestID(this.TestID, this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);
        }
        public static bool DeleteTest(int TestID)
        {
            return clsTestDataAccessLayer.DeleteTestByTestID(TestID);
        }
        public static DataView GetAllTests()
        {
            return clsTestDataAccessLayer.GetAllTest();
        }
        public bool Save()
        {
            switch (this.Mode)
            {
                case enTestMode.Add:
                    if (_AddNewTest())
                    {
                        this.Mode = enTestMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enTestMode.Update:
                    return _UpdateTest();
            }
            return false;
        }
    }


}
