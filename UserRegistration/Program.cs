using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            string firstName,lastName,emailId;

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
    }
}
