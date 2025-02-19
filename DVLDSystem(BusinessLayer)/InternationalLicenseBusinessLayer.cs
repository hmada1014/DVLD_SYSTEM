using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDSystem_DataAccessLayer_;

namespace DVLDSystem_BusinessLayer_
{
  
   public class clsInternationalLicense
   {
       public enum enInternationalLicenseMode { Add = 0, Update = 1 }
       public enInternationalLicenseMode Mode = enInternationalLicenseMode.Add;

       public int InternationalLicenseID { get; set; }
       public int ApplicationID { get; set; }
       public int DriverID { get; set; }
       public int IssuedUsingLocalLicenseID { get; set; }
       public DateTime IssueDate { get; set; }
       public DateTime ExpirationDate { get; set; }
       public bool IsActive { get; set; }
       public int CreatedByUserID { get; set; }


       public clsInternationalLicense()
       {
           this.InternationalLicenseID = -1;
           this.ApplicationID = -1;
           this.DriverID = -1;
           this.IssuedUsingLocalLicenseID = -1;
           this.IssueDate = DateTime.Now;
           this.ExpirationDate = DateTime.Now;
           this.IsActive = false;
           this.CreatedByUserID = -1;


           this.Mode = enInternationalLicenseMode.Add;


       }

       private clsInternationalLicense(int InternationalLicenseID, int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
       {
           this.InternationalLicenseID = InternationalLicenseID;
           this.ApplicationID = ApplicationID;
           this.DriverID = DriverID;
           this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
           this.IssueDate = IssueDate;
           this.ExpirationDate = ExpirationDate;
           this.IsActive = IsActive;
           this.CreatedByUserID = CreatedByUserID;


           this.Mode = enInternationalLicenseMode.Update;

       }
       public static clsInternationalLicense Find(int InternationalLicenseID)
        {
            int ApplicationID = -1, DriverID = -1, CreatedByUserID = -1 , IssuedUsingLocalLicenseID = -1;     
            DateTime IssueDate  = DateTime.Now,   ExpirationDate = DateTime.Now;
            bool IsActive = false;

           
           if (clsInternationalLicenseDataAccessLayer.GetInternationalLicenseInfoByID(InternationalLicenseID,ref ApplicationID,ref DriverID,ref IssuedUsingLocalLicenseID,ref IssueDate
                                                                                      ,ref ExpirationDate,ref IsActive,ref CreatedByUserID))
           {
                return new clsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
               
           }
           else
           {
               return null;
           }
       }
       public static bool IsInternationalLicenseExist(int InternationalLicenseID)
       {
            return clsInternationalLicenseDataAccessLayer.IsInternationalLicenseIDExist(InternationalLicenseID);
         
       }
       private bool _AddNewInternationalLicense()
       {
            this.InternationalLicenseID = clsInternationalLicenseDataAccessLayer.AddNewInternationalLicense(this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);
           return (this.InternationalLicenseID != -1);
       }
       private bool _UpdateInternationalLicense()
       {
          return  clsInternationalLicenseDataAccessLayer.UpdateInternationalLicenseByID(this.InternationalLicenseID, this.ApplicationID, this.DriverID
                                                                                  , this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);
       }
       public static bool DeleteInternationalLicense(int InternationalLicenseID)
       {
            return clsInternationalLicenseDataAccessLayer.DeleteInternationalLicenseByID(InternationalLicenseID);
          
       }
       public static DataView GetAllInternationalLicenses()
       {
           return clsInternationalLicenseDataAccessLayer.GetAllInternationalLicense();
       }
       public bool Save()
       {
           switch (this.Mode)
           {
               case enInternationalLicenseMode.Add:
                   if (_AddNewInternationalLicense())
                   {
                       this.Mode = enInternationalLicenseMode.Update;
                       return true;
                   }
                   else
                   {
                       return false;
                   }
               case enInternationalLicenseMode.Update:
                   return _UpdateInternationalLicense();
           }
           return false;
       }
   }

    
}
