using DVLDSystem_DataAccessLayer_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDSystem_BusinessLayer_
{
     public class clsPerson
    {
        public enum enPersonMode { Add = 0, Update = 1 }
        public enPersonMode Mode = enPersonMode.Add;

        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; }
        public DateTime DateOfBirth { get; set; }
        public byte Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }


        public clsPerson()

        {
            this.PersonID = -1;
            this.NationalNo ="";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Gender = 0;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.NationalityCountryID = -1;
            this.ImagePath = "";
            this.FullName = FirstName +" "+SecondName+" "+ThirdName+" "+LastName;


            this.Mode = enPersonMode.Add;


        }

        private clsPerson(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, byte Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;
            this.FullName = FirstName + " " + SecondName + " " + ThirdName + " " + LastName;

            this.Mode = enPersonMode.Update;

        }
        public static clsPerson Find(int PersonID)
        {
            string NationalNo = "",FirstName = "", SecondName = "",  ThirdName = "",  LastName ="",Address =  "",  Phone = "",  Email = "", ImagePath = "";
            byte Gender = 0;
            DateTime DateOfBirth = DateTime.Now;
            int NationalityCountryID = -1;


            if (clsPeopleDataAccessLayer.GetPersonInfoByID(PersonID,ref NationalNo,ref FirstName,ref SecondName,ref ThirdName,ref LastName,ref DateOfBirth,
                                                            ref Gender, ref Address,ref Phone,ref Email , ref NationalityCountryID,ref ImagePath))
            {
               
                return new clsPerson(PersonID,NationalNo,FirstName,SecondName,ThirdName,LastName,DateOfBirth,Gender,Address,Phone,Email,NationalityCountryID,ImagePath);
            }
            else
            {
                return null;
            }
        }

        public static clsPerson Find(string NationalNo)
        {
            string  FirstName = "", SecondName = "", ThirdName = "", LastName = "", Address = "", Phone = "", Email = "", ImagePath = "";
            byte Gender = 0;
            DateTime DateOfBirth = DateTime.Now;
            int PersonID = -1, NationalityCountryID = -1;


            if (clsPeopleDataAccessLayer.GetPersonInfoByNationalNo(NationalNo, ref PersonID, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth,
                                                            ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {

                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
            }
            else
            {
                return null;
            }
        }
        public static bool IsPersonExist(int PersonID)
        {
            return clsPeopleDataAccessLayer.IsPersonExist(PersonID);
        }
        public static bool IsPersonExist(string NationalNo)
        {
            return clsPeopleDataAccessLayer.IsPersonExist(NationalNo);
        }

        public static bool IsPersonExist(string NationalNo,string PersonID)
        {
            return clsPeopleDataAccessLayer.IsPersonExist(NationalNo,PersonID);
        }
        private bool _AddNewPerson()
        {
            this.PersonID = clsPeopleDataAccessLayer.AddNewPerson(this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gender, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);
            return (this.PersonID != -1);
        }
        private bool _UpdatePerson()
        {
            return clsPeopleDataAccessLayer.UpdatePerson(this.PersonID, this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gender, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);
        }
        public static bool DeletePerson(int PersonID)
        {
            return clsPeopleDataAccessLayer.DeletePersonByPersonID(PersonID);
        }
        public static DataView GetAllPersons()
        {
            /* return from data access function*/

            return clsPeopleDataAccessLayer.GetAllPerson();
        }
        public static DataView SearchPersonByPersonID(string PersonID)
        {
            return clsPeopleDataAccessLayer.SearchPersonByPersonID(PersonID);
        }

        public static DataView SearchPersonByNationalNo(string NationalNo)
        {
            return clsPeopleDataAccessLayer.SearchPersonByNationalNo(NationalNo);
        }
        public bool Save()
        {
            switch (this.Mode)
            {
                case enPersonMode.Add:
                    if (_AddNewPerson())
                    {
                        this.Mode = enPersonMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enPersonMode.Update:
                    return _UpdatePerson();
            }
            return false;
        }
    }

}
