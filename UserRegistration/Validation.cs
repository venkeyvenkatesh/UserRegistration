using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Validation
    {

        public bool validateName(string name)
        {
            string pattern = @"(^[A-Z]{1}[a-z]{2,}$)";

            Regex re = new Regex(pattern);
            if (re.IsMatch(name))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool validateEmailId(string emailId)
        {
            string pattern = "^[\\w-\\+]+(\\.[\\w]+)*@[\\w-]+(\\.[\\w]+)*(\\.[a-z]{2,})$";

            Regex re = new Regex(pattern);
            if (re.IsMatch(emailId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool validatePhoneNumber(string phoneNumber)
        {
            string pattern = @"(^[1-9]{1,}[0-9\\-]{0,}[ ]{1}[1-9]{1}[0-9]{9}$)";

            Regex re = new Regex(pattern);
            if (re.IsMatch(phoneNumber))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
