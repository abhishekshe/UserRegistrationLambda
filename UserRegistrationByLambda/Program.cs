using System;

namespace UserRegistrationProblem
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            const string FIRST_NAME_CHECK = "a";
            const string LAST_NAME_CHECK = "b";
            const string EMAIL_CHECK = "c";
            const string MOBILE_NO_CHECK = "d";
            const string EXIT = "x";
            const string PASSWORD_CHECK = "e";
            Console.WriteLine("Welcome to User Registration Problem");
            bool flag = true;
            
            while (flag)
            {
                Console.WriteLine("\nPress A for validating first name \npress B for validating last name\npress C for validating email id\npress D for validating mobile no\npress E to validate Password\nPress X for exit");
                
                string checkType = Console.ReadLine();
                
                switch (checkType.ToLower())
                {
                    case FIRST_NAME_CHECK:
                        
                        UserDetailsEntry.FirstName();
                        break;
                    case LAST_NAME_CHECK:
                        UserDetailsEntry.LastName();
                        break;
                    case EMAIL_CHECK:
                        UserDetailsEntry.Email();
                        break;
                    case MOBILE_NO_CHECK:
                        UserDetailsEntry.MobileNo();
                        break;
                    case EXIT:
                        flag = false;
                        break;
                    case PASSWORD_CHECK:
                        UserDetailsEntry.Password();
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input");
                        break;

                }
            }

        }
    }
}
