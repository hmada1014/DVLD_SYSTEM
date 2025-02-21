using DVLDSystem_DataAccessLayer_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDSystem_BusinessLayer_
{

    public class clsCountry
    {
        public enum enCountryMode { Add = 0, Update = 1 }
        public enCountryMode Mode = enCountryMode.Add;

        public int CountryID { get; set; }
        public string CountryName { get; set; }


        public clsCountry()

        {
            this.CountryID = -1;
            this.CountryName = "";

            this.Mode = enCountryMode.Add;
        }

        private clsCountry(int CountryID, string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;


            this.Mode = enCountryMode.Update;

        }
        public static clsCountry Find(int CountryID)
        {

            string CountryName = "";
            if (clsCountryDataAccessLayer.GetCountryInfoByCountryID(CountryID, ref CountryName))
            {
                return new clsCountry(CountryID, CountryName);
            }
            else
            {
                return null;
            }
        }
        public static bool IsCountryExist(int CountryID)
        {
            return clsCountryDataAccessLayer.IsCountryExist(CountryID);
        }
        private bool _AddNewCountry()
        {
            this.CountryID = clsCountryDataAccessLayer.AddNewCountry(this.CountryName);
            return (this.CountryID != -1);
        }
        private bool _UpdateCountry()
        {
            return clsCountryDataAccessLayer.UpdateCountryByCountryID(this.CountryID, this.CountryName);
        }
        public static bool DeleteCountry(int CountryID)
        {

            return clsCountryDataAccessLayer.DeleteCountryByCountryID(CountryID);

        }
        public static DataView GetAllCountries()
        {

            return clsCountryDataAccessLayer.GetAllCountries();
        }

        public static DataView SearchCountriesByCountryID(string CountryID)
        {
            return clsCountryDataAccessLayer.SearchCountryByCountryID(CountryID);
        }
        public bool Save()
        {
            switch (this.Mode)
            {
                case enCountryMode.Add:
                    if (_AddNewCountry())
                    {
                        this.Mode = enCountryMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enCountryMode.Update:
                    return _UpdateCountry();
            }
            return false;
        }
    }




}
