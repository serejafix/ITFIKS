using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Check
{
    public class Checks
    {
        public static bool FIOCheck(string FIO)
        {
            return FIO.All(char.IsLetter);
        }
        public static bool AgeCheck(string age)
        {          
            return age.All(char.IsDigit);
        }
        public static bool PhoneNumberCheck(string number)
        {
            string reg = @"^\+[0-9]{3}\s\((\d+)\)-\d{3}-\d{2}-\d{2}";
            if (Regex.IsMatch(number, reg))
            {
                return true;
            }
            return false;
        }
        public static bool EmailCheck(string email)
        {
            string reg = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            if (Regex.IsMatch(email, reg))
            {
                return true;
            }
            return false;
        }   
    }
}
