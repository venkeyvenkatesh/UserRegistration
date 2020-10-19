using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Schema;

namespace UserRegistration
{
    public class Validation
    {

        /// <summary>
        /// Validates the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="pattern">The pattern.</param>
        /// <returns></returns>
        public bool validate(string name,string pattern)
        {
           
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

        


    }
}
