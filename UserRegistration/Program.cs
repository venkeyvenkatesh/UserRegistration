using System;
using System.Reflection;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        public string firstName
        {
            get;
            set;
        }
        public string lastName
        {
            get;
            set;
        }
        public string emailId
        {
            get;
            set;
        }
        public string phoneNumber
        {
            get;
            set;
        }
        public string password
        {
            get;
            set;
        }


        static Program obj = new Program();

        /// <summary>
        /// Validates the fields.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="pattern">The pattern.</param>
        /// <exception cref="MyException">Invalid " + field.Name + " Entered</exception>
        static Action<string, string> validateFields = (propertyName,pattern) =>
           {
               Type type = Type.GetType("UserRegistration.Program");
               PropertyInfo field = type.GetProperty(propertyName);
               while (true)
               {
                   try
                   {
                       Console.WriteLine("Enter your " + propertyName);
                       string value = Console.ReadLine();
                       field.SetValue(obj, value);

                       bool isValid = Validation.validate(value, pattern);
                    //valdating the fisrtName
                    if (!isValid)
                       {


                           throw new MyException("Invalid " + field.Name + " Entered");


                       }
                       break;
                   }
                   catch (MyException me)
                   {
                       Console.WriteLine(me.Message);
                   }

               }
           };
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
           


            Console.WriteLine("Welcome to user Registration problem");


            validateFields("firstName", "(^[A-Z]{1}[a-z]{2,}$)");
            validateFields("lastName", "(^[A-Z]{1}[a-z]{2,}$)");
            validateFields("emailId", "(^[a-zA-Z0-9]{1,}([+-_.][a-zA-Z0-9]{1,}){0,}@[a-zA-Z0-9]{1,}(\\.[a-zA-Z]{1,}){0,1}(\\.[a-zA-Z]{2,})$)");
            validateFields("phoneNumber", "(^[+[1-9]{1,}[0-9\\-]{0,}[ ]{1}[1-9]{1}[0-9]{9}$)");
            validateFields("password", "(^(?=.{8,}$)((?=.*[A-Z])(?=.*[0-9])([a-zA-Z0-9]*[!@#$^&*()-+=]{1}[a-zA-Z0-9]*))$)");
            

            Console.WriteLine("\nRegistration successful\n");

            Console.WriteLine("First Name :" + obj.firstName);
            Console.WriteLine("Last Name: " + obj.lastName);
            Console.WriteLine("Email address :" + obj.emailId);
            Console.WriteLine("phone number :" + obj.phoneNumber);
            Console.WriteLine("passord :" + obj.password);
        }


    }
}
