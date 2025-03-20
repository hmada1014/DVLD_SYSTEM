using DVLDSystem_DataAccessLayer_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDSystem_BusinessLayer_
{
    public class clsUser
    {
        public enum enUserMode { Add = 0, Update = 1 }
        public enUserMode Mode = enUserMode.Add;

        public enum enPermission
        {
            All = -1,
            Application = 1,
            People = 2,
            Drivers = 4,
            Users = 8,
        }

        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public int Permission { get; set; }


        public clsUser()

        {
            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = string.Empty;
            this.Password = string.Empty;
            this.Permission = 0;
            this.IsActive = false;


            this.Mode = enUserMode.Add;


        }

        private clsUser(int UserID, int PersonID, string UserName, string Password,int Permission, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.Permission = Permission;
            this.IsActive = IsActive;


            this.Mode = enUserMode.Update;

        }
        public static clsUser Find(int UserID)
        {
            int PersonID = -1 , Permission = 0;
            string UserName = string.Empty, Password = string.Empty;
            bool IsActive = false;

            if (clsUserDataAccessLayer.GetUserInfoByUserID(UserID, ref PersonID, ref UserName, ref Password,ref Permission, ref IsActive))
            {
                return new clsUser(UserID, PersonID, UserName, Password, Permission,IsActive);
            }
            else
            {
                return null;
            }
        }

        public static clsUser Find(string UserName , string Password )
        {
            int PersonID = -1 , UserID =-1 ,Permission = 0;
            bool IsActive = false;

            if (clsUserDataAccessLayer.GetUserInfoByUserNameAndPassword(UserName,Password,ref UserID, ref PersonID, ref Permission,ref IsActive))
            {
                return new clsUser(UserID, PersonID, UserName, Password, Permission, IsActive);
            }
            else
            {
                return null;
            }
        }
        public static bool IsUserExist(int UserID)
        {
            return clsUserDataAccessLayer.IsUserExist(UserID);
        }
        public static bool IsUserExist(string UserName)
        {
            return clsUserDataAccessLayer.IsUserExist(UserName);
        }
        public static bool IsUserExist(string UserName , string Password)
        {
            return clsUserDataAccessLayer.IsUserExist(UserName,Password);
        }
        public static bool IsUserExist(string UserName, string UserID , string Password = "")
        {
            return clsUserDataAccessLayer.IsUserExist(UserName, UserID ,"");
        }
        private bool _AddNewUser()
        {
            if (!clsUser.IsUserExist(this.UserName))
            {
                this.UserID = clsUserDataAccessLayer.AddNewUser(this.PersonID, this.UserName, this.Password, this.Permission, this.IsActive);
            }
            return (this.UserID != -1);
        }
        private bool _UpdateUser()
        {
            clsUser _User = clsUser.Find(this.UserID);

            if (_User.UserName != this.UserName)
            {
                if (clsUser.IsUserExist(this.UserName))
                {
                    return false;
                }
            }
            return clsUserDataAccessLayer.UpdateUserByUserID(this.UserID, this.PersonID, this.UserName, this.Password, this.Permission,this.IsActive);
        }
        public static bool DeleteUser(int UserID)
        {
            return clsUserDataAccessLayer.DeleteUserByUserID(UserID);
        }

        public static DataView SearchUserByUserID(string UserID)
        {
            return clsUserDataAccessLayer.SearchUserByUserID(UserID);
        }

        public static DataView SearchUserByPersonID(string PersonID)
        {
            return clsUserDataAccessLayer.SearchUserByPersonID(PersonID);
        }
        public static DataView GetAllUsers()
        {
            return clsUserDataAccessLayer.GetAllUser();
        }
        public bool Save()
        {
            switch (this.Mode)
            {
                case enUserMode.Add:
                    if (_AddNewUser())
                    {
                        this.Mode = enUserMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enUserMode.Update:
                    return _UpdateUser();
            }
            return false;
        }
    }

}
