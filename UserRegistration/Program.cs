using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            string firstName,lastName,emailId,phoneNumber;

            Console.WriteLine("Welcome to user Registration problem");

            Console.WriteLine("Enter your first name: ");
            firstName = Console.ReadLine();

           while(!(validateName(firstName)))
            {
                Console.WriteLine("Please enter valid first Name ");
                firstName = Console.ReadLine();

            }

            Console.WriteLine("Enter your Last name: ");
            lastName = Console.ReadLine();

            while (!(validateName(lastName)))
            {
                Console.WriteLine("Please enter valid last Name ");
                lastName = Console.ReadLine();

            }

            Console.WriteLine("Enter your Email address: ");
            emailId = Console.ReadLine();

            while (!(validateEmailId(emailId)))
            {
                Console.WriteLine("Please enter valid Email id ");
               emailId = Console.ReadLine();

            }

          
        
                Console.WriteLine("Enter your phone Number : ");
                phoneNumber = Console.ReadLine();

                while (!(validatePhoneNumber(phoneNumber)))
                {
                    Console.WriteLine("Please enter valid phone number");
                    phoneNumber = Console.ReadLine();

                }
            


        }

        public static bool validateName(string name)
        {
            string pattern = @"(^[A-Z]{1}[a-z]{2,}$)";

            Regex re = new Regex(pattern);
            if(re.IsMatch(name))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool validateEmailId(string emailId)
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

        public static bool validatePhoneNumber(string phoneNumber)
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
