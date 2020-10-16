using System;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Reflection;

namespace UserRegistration
{
    class Program
    {
       static NewUser userObject = new NewUser();

       static  ValidationContext context = new ValidationContext(userObject, null, null);
      static  List<ValidationResult> result = new List<ValidationResult>();

       static bool isValid;



        public static void validate(string name)
        {


            Type type = Type.GetType("UserRegistration.NewUser");

            PropertyInfo property = type.GetProperty(name);


            while (true)
            {
        
                Console.WriteLine("Enter your "+name);
                string value = Console.ReadLine();
                property.SetValue(userObject , value );
             
                isValid = Validator.TryValidateObject(userObject, context, result, true);
                //valdating the fisrtName
                if (!isValid)
                {


                    Console.WriteLine(result[result.Count - 1].ErrorMessage);
                  

                }
                else
                {
                    break;
                }
            }


        }

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            

          
            Console.WriteLine("Welcome to user Registration problem");
        
            validate("firstName");
            validate("lastName");
            validate("emailId");
            validate("phoneNumber"); 
            validate("password");

           



            userObject.display();
        }
    }
}  



    

