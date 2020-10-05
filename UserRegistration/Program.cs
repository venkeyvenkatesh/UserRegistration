using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            //variables
            string firstName,lastName,emailId,phoneNumber,password;

             Console.WriteLine("Welcome to user Registration problem");

             Validation obj = new Validation();

            //getting firstName input from user
            Console.WriteLine("Enter your first name: ");
            firstName = Console.ReadLine();

            //valdating the fisrtName
            while (!(obj.validateName(firstName)))
            {
                Console.WriteLine("Please enter valid first Name ");
                firstName = Console.ReadLine();

            }


            //getting lastName as input from user
            Console.WriteLine("Enter your Last name: ");
            lastName = Console.ReadLine();

            //valdating the lastName
            while (!(obj.validateName(lastName)))
            {
                Console.WriteLine("Please enter valid last Name ");
                lastName = Console.ReadLine();

            }


            //getting EmailAddress as input from user
            Console.WriteLine("Enter your Email address: ");
            emailId = Console.ReadLine();

            //valdating the EmailAddress
            while (!(obj.validateEmailId(emailId)))
            {
                Console.WriteLine("Please enter valid Email id ");
                emailId = Console.ReadLine();

            }



            //getting phoneNumber as input from user
            Console.WriteLine("Enter your phone Number : ");
            phoneNumber = Console.ReadLine();

            //valdating the phoneNumber
            while (!(obj.validatePhoneNumber(phoneNumber)))
            {
                Console.WriteLine("Please enter valid phone number");
                phoneNumber = Console.ReadLine();

            }



            //getting password as input from user
            Console.WriteLine("Enter your password : ");
                password = Console.ReadLine();

            //valdating the password
            while (!(obj.validatePassword(password)))
                {
                    Console.WriteLine("Please enter valid password");
                    password = Console.ReadLine();

                }

            Console.WriteLine("Registration successful");

        }


    }
}
