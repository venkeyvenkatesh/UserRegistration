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
            string firstName, lastName, emailId, phoneNumber, password;

            Console.WriteLine("Welcome to user Registration problem");

            Validation obj = new Validation();
            while (true)
            {
                //getting firstName input from user
                Console.WriteLine("Enter your first name: ");
                firstName = Console.ReadLine();

                try
                {
                    //valdating the fisrtName
                    if (!(obj.validate(firstName, "(^[A-Z]{1}[a-z]{2,}$)")))
                    {
                        // Console.WriteLine("Please enter valid first Name ");
                        // firstName = Console.ReadLine();
                        throw new MyException("First name is not in required format....");

                    }
                    break;
                }

                catch (MyException me)
                {
                    Console.WriteLine(me.Message);

                }
            }


            while (true)
            {
                //getting lastName as input from user
                Console.WriteLine("Enter your Last name: ");
                lastName = Console.ReadLine();

                try
                {
                    //valdating the lastName
                    if (!(obj.validate(lastName, "(^[A-Z]{1}[a-z]{2,}$)")))
                    {

                        // Console.WriteLine("Please enter valid last Name ");
                        //lastName = Console.ReadLine();
                        throw new MyException("Last name is not in required format....");

                    }
                    break;
                }

                catch (MyException me)
                {
                    Console.WriteLine(me.Message);

                }

            }


            while (true)
            {
                //getting EmailAddress as input from user
                Console.WriteLine("Enter your Email address: ");
                emailId = Console.ReadLine();

                try
                {
                    //valdating the EmailAddress
                    if (!(obj.validate(emailId, "(^[a-zA-Z0-9]{1,}([+-_.][a-zA-Z0-9]{1,}){0,}@[a-zA-Z0-9]{1,}(\\.[a-zA-Z]{1,}){0,1}(\\.[a-zA-Z]{2,})$)")))
                    {
                        // Console.WriteLine("Please enter valid Email id ");
                        // emailId = Console.ReadLine();
                        throw new MyException("Email is not in required format....");

                    }
                    break;
                }
                catch (MyException me)
                {
                    Console.WriteLine(me.Message);

                }

            }


            while (true)
            {
                //getting phoneNumber as input from user
                Console.WriteLine("Enter your phone Number : ");
                phoneNumber = Console.ReadLine();
                try
                {
                    //valdating the phoneNumber
                    if (!(obj.validate(phoneNumber, "(^[+[1-9]{1,}[0-9\\-]{0,}[ ]{1}[1-9]{1}[0-9]{9}$)")))
                    {
                        // Console.WriteLine("Please enter valid phone number");
                        //  phoneNumber = Console.ReadLine();
                        throw new MyException("Phone number is not in required format....");


                    }
                    break;
                }
                catch (MyException me)
                {
                    Console.WriteLine(me.Message);

                }

            }


            while (true)
            {
                //getting password as input from user
                Console.WriteLine("Enter your password : ");
                password = Console.ReadLine();
                try
                {
                    //valdating the password
                    if (!(obj.validate(password, "(^(?=.{8,}$)((?=.*[A-Z])(?=.*[0-9])([a-zA-Z0-9]*[!@#$^&*()-+=]{1}[a-zA-Z0-9]*))$)")))
                    {
                        // Console.WriteLine("Please enter valid password");
                        // password = Console.ReadLine();
                        throw new MyException("Password is not in required format....");

                    }
                    break;
                }
                catch (MyException me)
                {
                    Console.WriteLine(me.Message);

                }

            }

            Console.WriteLine("\nRegistration successful\n");

            Console.WriteLine("First Name :" + firstName);
            Console.WriteLine("Last Name: " + lastName);
            Console.WriteLine("Email address :" + emailId);
            Console.WriteLine("phone number :" + phoneNumber);
            Console.WriteLine("passord :" + password);
        }


    }
}
