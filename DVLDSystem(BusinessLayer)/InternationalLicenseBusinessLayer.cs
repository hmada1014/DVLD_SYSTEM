using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDSystem_BusinessLayer_
{
  
   public class clsInternationalLicenseBusinessLayer
   {
       public enum enInternationalLicenseMode { Add = 0, Update = 1 }
       public enInternationalLicenseMode Mode = enInternationalLicenseMode.Add;

       public int InternationalLicenseID { get; set; }
       public int ApplicationID { get; set; }
       public int DriverID { get; set; }
       public int IssuedUsingLocalLicenseID { get; set; }
       public DateTime IssueDate { get; set; }
       public DateTime ExpirationDate { get; set; }
       public byte IsActive { get; set; }
       public int CreatedByUserID { get; set; }


       public clsInternationalLicenseBusinessLayer()
       {
           this.InternationalLicenseID = -1;
           this.ApplicationID = -1;
           this.DriverID = -1;
           this.IssuedUsingLocalLicenseID = -1;
           this.IssueDate = DateTime.Now;
           this.ExpirationDate = DateTime.Now;
           this.IsActive = 0;
           this.CreatedByUserID = -1;


           this.Mode = enInternationalLicenseMode.Add;


       }

       private clsInternationalLicenseBusinessLayer(int InternationalLicenseID, int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, byte IsActive, int CreatedByUserID)
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
       public static bool Find(int InternationalLicenseID)
        {
            int ApplicationID = -1, DriverID = -1, CreatedByUserID = -1 , IssuedUsingLocalLicenseID = -1;     
            DateTime IssueDate  = DateTime.Now,   ExpirationDate = DateTime.Now;
            bool IsActive = true;

           /* Enter all Variables */
           if (cls)
           {
               /* return new clsInternationalLicense(Variables)*/
           }
           else
           {
               return null;
           }
       }
       public static bool IsInternationalLicenseExist(int InternationalLicenseID)
       {
           /* return from data access*/
       }
       private bool _AddNewInternationalLicense()
       {
           this.InternationalLicenseID = -1; /*Function from data access*/
           return (this.InternationalLicenseID != -1);
       }
       private bool _UpdateInternationalLicense()
       {
           /* return from data access function*/
       }
       public static bool DeleteInternationalLicense(int InternationalLicenseID)
       {
           /* return from data access function*/
       }
       public static DataView GetAllInternationalLicenses()
       {
           /* return from data access function*/
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
