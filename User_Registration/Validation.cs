using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User_Registration
{
    public class Validation
    {
        public static string NAME_REGX = "^[A-Z]{1}[a-z]{2,}$";
        public static string Mail_ID = "^[a-zA-Z]+[.+_]{1}[a-zA-Z]+[@]{1}[a-z]+[.][a-z]{2,3}([.][a-z]{2,3}){0,1}$";
        public static string MOBILENUMBER = "^(91){1}[ ]{1}[6-9]{1}[0-9]{9}$";
        public static string Password = "^[0-9a-zA-Z]{8,}$";
        public string ValidateFirstName(string firstName)
        {
            Regex reg = new Regex(NAME_REGX);
            if (reg.IsMatch(firstName))
            {
                return "valid";
            }
            else
            {
                return "Invalid";
            }

        }
        public string ValidateLastName(string lastName)
        {
            Regex reg = new Regex(NAME_REGX);
            if (reg.IsMatch(lastName))
            {
                return "valid";
            }
            else
            {
                return "Invalid";
            }

        }
        public string ValidateMailID(string mail)
        {
            Regex reg = new Regex(Mail_ID);
            if (reg.IsMatch(mail))
            {
                return "valid";
            }
            else
            {
                return "Invalid";
            }

        }
        public string ValidateMobile(string Mobile)
        {
            if (Regex.IsMatch((string)Mobile, MOBILENUMBER))
            {
                return "valid";
            }
            else
            {
                return "Invalid";
            }
        }
        public string ValidatePass(string Pass)
        {
            if (Regex.IsMatch(Pass, Password))
            {
                return "valid";
            }
            else
            {
                return "Invalid";
            }
        }

    }
}
