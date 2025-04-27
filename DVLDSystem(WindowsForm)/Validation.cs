using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DVLDSystem_WindowsForm_
{
    public class clsValidation
    {

        static public bool IsValidEmail(string email, string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$")
        {
            return Regex.IsMatch(email, pattern);
        }
        static public bool IsValidPhoneNumber(string phone , string pattern = @"^\+?[0-9]{7,15}$")
        {
             // Allows optional '+' and 7-15 digits
            return Regex.IsMatch(phone, pattern);
        }
        static public bool IsValidName(string text , string pattern = @"^[A-Za-z\s\-]{1,20}$")
        {
            return Regex.IsMatch(text, pattern);
        }
        static public bool IsValidLettersAndNumbers(string text, string pattern = @"^[A-Za-z0-9]+$")
        {
            return Regex.IsMatch(text,pattern);
        }
         
        static public bool CustomValid(string text , string pattern)
        {
            bool n = Regex.IsMatch(text, pattern);

           return Regex.IsMatch(text,pattern);
        }
    }
}
