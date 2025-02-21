using DVLDSystem_DataAccessLayer_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDSystem_BusinessLayer_
{
    public class clsTestTypeData
    {
        public enum enTestTypeDataMode { Add = 0, Update = 1 }
        public enTestTypeDataMode Mode = enTestTypeDataMode.Add;

        public int TestTypeID { get; set; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public decimal TestTypeFees { get; set; }


        public clsTestTypeData()

        {
            this.TestTypeID = -1;
            this.TestTypeTitle = string.Empty;
            this.TestTypeDescription = string.Empty;
            this.TestTypeFees = -1;


            this.Mode = enTestTypeDataMode.Add;


        }

        private clsTestTypeData(int TestTypeID, string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees)
        {
            this.TestTypeID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeDescription = TestTypeDescription;
            this.TestTypeFees = TestTypeFees;


            this.Mode = enTestTypeDataMode.Update;

        }
        public static clsTestTypeData Find(int TestTypeID)
        {

            string TestTypeTitle = string.Empty, TestTypeDescription = string.Empty;
            decimal TestTypeFees = -1m;

            if (clsTestTypeDataAccessLayer.GetTestTypeInfoByTestTypeID(TestTypeID, ref TestTypeTitle, ref TestTypeDescription, ref TestTypeFees))
            {
                return new clsTestTypeData(TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees);
            }
            else
            {
                return null;
            }
        }
        public static bool IsTestTypeDataExist(int TestTypeID)
        {
            return clsTestTypeDataAccessLayer.IsTestTypeExist(TestTypeID);
        }
        private bool _AddNewTestTypeData()
        {
            this.TestTypeID = clsTestTypeDataAccessLayer.AddNewTestType(this.TestTypeTitle, this.TestTypeDescription, this.TestTypeFees);
            return (this.TestTypeID != -1);
        }
        private bool _UpdateTestTypeData()
        {
            return clsTestTypeDataAccessLayer.UpdateTestTypeByTestTypeID(this.TestTypeID, this.TestTypeTitle, this.TestTypeDescription, this.TestTypeFees);
        }
        public static bool DeleteTestTypeData(int TestTypeID)
        {
            return clsTestTypeDataAccessLayer.DeleteTestTypeByTestTypeID(TestTypeID);
        }
        public static DataView GetAllTestTypeDatas()
        {
            return clsTestTypeDataAccessLayer.GetAllTestType();
        }
        public bool Save()
        {
            switch (this.Mode)
            {
                case enTestTypeDataMode.Add:
                    if (_AddNewTestTypeData())
                    {
                        this.Mode = enTestTypeDataMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enTestTypeDataMode.Update:
                    return _UpdateTestTypeData();
            }
            return false;
        }
    }

}
