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
    }
}
