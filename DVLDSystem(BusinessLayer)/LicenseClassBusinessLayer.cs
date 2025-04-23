using DVLDSystem_DataAccessLayer_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDSystem_BusinessLayer_
{
    public class clsLicenseClass
    {
        public enum enLicenseClassMode { Add = 0, Update = 1 }
        public enLicenseClassMode Mode = enLicenseClassMode.Add;

        public int LicenseClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public byte MinimumAllowedAge { get; set; }
        public byte DefaultValidityLength { get; set; }
        public decimal ClassFees { get; set; }


        public clsLicenseClass()

        {
            this.LicenseClassID = -1;
            this.ClassName = string.Empty;
            this.ClassDescription = string.Empty;
            this.MinimumAllowedAge =0 ;
            this.DefaultValidityLength = 0;
            this.ClassFees = -1;

            this.Mode = enLicenseClassMode.Add;
        }

        private clsLicenseClass(int LicenseClassID, string ClassName, string ClassDescription, byte MinimumAllowedAge, byte DefaultValidityLength, decimal ClassFees)
        {
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;


            this.Mode = enLicenseClassMode.Update;

        }
        public static clsLicenseClass Find(int LicenseClassID)
        {
            
            byte MinimumAllowedAge = 0, DefaultValidityLength = 0;
            decimal ClassFees = -1;
            string ClassName = string.Empty, ClassDescription = string.Empty;

            if (clsLicenseClassDataAccessLayer.GetLicenseClassInfoByLicenseClassID(LicenseClassID, ref ClassName, ref ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))
            {
                return new clsLicenseClass(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            }
            else
            {
                return null;
            }
        }

        public static clsLicenseClass Find(string ClassName)
        {
            int LicenseClassID = -1;
            byte MinimumAllowedAge = 0, DefaultValidityLength = 0;
            decimal ClassFees = -1;
            string ClassDescription = string.Empty;

            if (clsLicenseClassDataAccessLayer.GetLicenseClassInfoByLicenseClassName(ClassName, ref LicenseClassID, ref ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength,ref ClassFees))
            {
                return new clsLicenseClass(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            }
            else
            {
                return null;
            }
        }

        public static bool IsLicenseClassExist(int LicenseClassID)
        {
          return clsLicenseClassDataAccessLayer.IsLicenseClassExist(LicenseClassID);
        }
        private bool _AddNewLicenseClass()
        {
            this.LicenseClassID = clsLicenseClassDataAccessLayer.AddNewLicenseClass(this.ClassName, this.ClassDescription, this.MinimumAllowedAge, this.DefaultValidityLength, this.ClassFees);
            return (this.LicenseClassID != -1);
        }
        private bool _UpdateLicenseClass()
        {
            return clsLicenseClassDataAccessLayer.UpdateLicenseClassByLicenseClassID(this.LicenseClassID, this.ClassName, this.ClassDescription, this.MinimumAllowedAge, this.DefaultValidityLength, this.ClassFees);
        }
        public static bool DeleteLicenseClass(int LicenseClassID)
        {
            return clsLicenseClassDataAccessLayer.DeleteLicenseClassByLicenseClassID(LicenseClassID);
        }
        public static DataView GetAllLicenseClasss()
        {
            return clsLicenseClassDataAccessLayer.GetAllLicenseClass();
        }
        public bool Save()
        {
            switch (this.Mode)
            {
                case enLicenseClassMode.Add:
                    if (_AddNewLicenseClass())
                    {
                        this.Mode = enLicenseClassMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enLicenseClassMode.Update:
                    return _UpdateLicenseClass();
            }
            return false;
        }
    }



}
