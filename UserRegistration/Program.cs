using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            string firstName;

            Console.WriteLine("Welcome to user Registration problem");

            Console.WriteLine("Enter your first name: ");
            firstName = Console.ReadLine();

           while(!(validateFirstName(firstName)))
            {
                Console.WriteLine("Please enter valid first Name ");
                firstName = Console.ReadLine();

            }

            Console.WriteLine("You have entered valid first name ");
            
        }

        public static bool validateFirstName(string firstName)
        {
            string pattern = @"(^[A-Z]{1}[a-z]{2,}$)";

            Regex re = new Regex(pattern);
            if(re.IsMatch(firstName))
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
