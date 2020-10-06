using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Validation
    {

        /// <summary>
        /// Validates the name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Validates the email identifier.
        /// </summary>
        /// <param name="emailId">The email identifier.</param>
        /// <returns></returns>
        public bool validateEmailId(string emailId)
        {
           

            string pattern = "(^[a-zA-Z0-9]{1,}([+-_.][a-zA-Z0-9]{1,}){0,}@[a-zA-Z0-9]{1,}(\\.[a-zA-Z]{1,}){0,1}(\\.[a-zA-Z]{2,})$)";
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

        /// <summary>
        /// Validates the phone number.
        /// </summary>
        /// <param name="phoneNumber">The phone number.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Validates the password.
        /// </summary>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public bool validatePassword(string password)
        {
            string pattern = @"(^(?=.{8,}$)((?=.*[A-Z])(?=.*[0-9])([a-zA-Z0-9]*[!@#$^&*()-+=]{1}[a-zA-Z0-9]*))$)";

            Regex re = new Regex(pattern);
            if (re.IsMatch(password))
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
