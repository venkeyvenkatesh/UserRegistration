using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace UserRegistration
{
    class NewUser
    {

        //variables

        [StringLength(15, MinimumLength = 3, ErrorMessage = "{0} field is required")]
        [RegularExpression("(^[A-Z]{1}[a-z]{2,15}$)",ErrorMessage ="Invalid FirstName entered")]
        public string firstName
        {
            get;
            set;
        }

       
        [StringLength(15, MinimumLength = 3, ErrorMessage = "{0} field is required")]
        
        [RegularExpression("(^[A-Z]{1}[a-z]{2,15}$)", ErrorMessage = "Invalid LastName entered")]
      public string lastName 
        {
            get;
            set;
        }

        [StringLength(100, MinimumLength = 5, ErrorMessage = "{0} field is required")]
        [RegularExpression("(^[a-zA-Z0-9]{1,}([+-_.][a-zA-Z0-9]{1,}){0,}@[a-zA-Z0-9]{1,}(\\.[a-zA-Z]{1,}){0,1}(\\.[a-zA-Z]{2,})$)", ErrorMessage = "Invalid Emailid entered")]
        public string emailId
        {
            get;
            set;
        }

        [StringLength (20,MinimumLength =13,ErrorMessage ="{0} field is required")]
         
        [RegularExpression("(^[+[1-9]{1,}[0-9\\-]{0,}[ ]{1}[1-9]{1}[0-9]{9}$)", ErrorMessage = "Invalid PhoneNumber entered")]
        public string phoneNumber
        {
            get;
            set;
        }


        [StringLength(15,MinimumLength =8,ErrorMessage ="{0} field is required")]
        [RegularExpression("(^(?=.{8,15}$)((?=.*[A-Z])(?=.*[0-9])([a-zA-Z0-9]*[!@#$^&*()-+=]{1}[a-zA-Z0-9]*))$)", ErrorMessage = "Invalid Password entered")]

        public string password
        {
            get;
            set;
        }



        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void display()
        {
            Console.WriteLine("\nRegistration successful\n");

            Console.WriteLine("First Name :" + firstName);
            Console.WriteLine("Last Name: " + lastName);
            Console.WriteLine("Email address :" + emailId);
            Console.WriteLine("phone number :" + phoneNumber);
            Console.WriteLine("passord :" + password);
        }
    }
}
