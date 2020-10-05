using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            string firstName,lastName,emailId,phoneNumber,password;

             Console.WriteLine("Welcome to user Registration problem");

             Validation obj = new Validation();

            Console.WriteLine("Enter your first name: ");
            firstName = Console.ReadLine();

            while (!(obj.validateName(firstName)))
            {
                Console.WriteLine("Please enter valid first Name ");
                firstName = Console.ReadLine();

            }

            Console.WriteLine("Enter your Last name: ");
            lastName = Console.ReadLine();

            while (!(obj.validateName(lastName)))
            {
                Console.WriteLine("Please enter valid last Name ");
                lastName = Console.ReadLine();

            }

            Console.WriteLine("Enter your Email address: ");
            emailId = Console.ReadLine();

            while (!(obj.validateEmailId(emailId)))
            {
                Console.WriteLine("Please enter valid Email id ");
                emailId = Console.ReadLine();

            }



            Console.WriteLine("Enter your phone Number : ");
            phoneNumber = Console.ReadLine();

            while (!(obj.validatePhoneNumber(phoneNumber)))
            {
                Console.WriteLine("Please enter valid phone number");
                phoneNumber = Console.ReadLine();

            }

                Console.WriteLine("Enter your password : ");
                password = Console.ReadLine();

                while (!(obj.validatePassword(password)))
                {
                    Console.WriteLine("Please enter valid password");
                    password = Console.ReadLine();

                }
            


        }


    }
}
