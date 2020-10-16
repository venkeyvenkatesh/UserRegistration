using System;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

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


            NewUser userObject = new NewUser();

            ValidationContext context = new ValidationContext(userObject, null, null);
            List<ValidationResult> result = new List<ValidationResult>();
            
            bool isValid;
          
            Console.WriteLine("Welcome to user Registration problem");

            
            while (true)
            {
                //getting firstName as input from user
                Console.WriteLine("Enter your first name: ");
                userObject.firstName = Console.ReadLine();
                isValid = Validator.TryValidateObject(userObject, context, result,true);
                //valdating the fisrtName
                if (!isValid)
                {

                    
                    Console.WriteLine(result[result.Count-1].ErrorMessage);
                  
                }
                else
                {
                    break;
                }
            }

            while (true)
            {
                //getting LastName as  input from user
                Console.WriteLine("Enter your Last name: ");
                userObject.lastName = Console.ReadLine();

                //valdating the LastName
                isValid = Validator.TryValidateObject(userObject, context, result,true);
                
                if (!isValid)
                {
                    
                    Console.WriteLine(result[result.Count-1].ErrorMessage);
                   
                }
                else
                {
                    break;
                }
            }


            while (true)
            {
                //getting emailAddress as  input from user
                Console.WriteLine("Enter your Email Address ");
                userObject.emailId = Console.ReadLine();

                //valdating the EmailId
                isValid = Validator.TryValidateObject(userObject, context, result,true);
               
                if (!isValid)
                {
                    
                    Console.WriteLine(result[result.Count-1].ErrorMessage);
             
                }
                else
                {
                    break;
                }
            }





            while (true)
            {
                //getting phoneNumber as input from user
                Console.WriteLine("Enter your phone number ");
                userObject.phoneNumber = Console.ReadLine();

                //valdating the Phone Number
                isValid = Validator.TryValidateObject(userObject, context, result,true);
                
                if (!isValid)
                {
                   
                    Console.WriteLine(result[result.Count-1].ErrorMessage);


                }
                else
                {
                    break;
                }
            }



            while (true)
            {
                //getting password as input from user
                Console.WriteLine("Enter your password");
                userObject.password = Console.ReadLine();

                //valdating the password
                isValid = Validator.TryValidateObject(userObject, context, result,true);
                
                if (!isValid)
                {
                    Console.WriteLine(result[result.Count-1].ErrorMessage);
              

                }
                else
                {
                    break;
                }
            }



            userObject.display();
        }
    }
}  



    

