using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationProblem
{
    class UserDetailsEntry
    {
        
        public static void FirstName()
        {
            UserRegistration userRegistration = new UserRegistration();
            try
            {
                Console.WriteLine("Please enter the user first name for registration");
                string input = Console.ReadLine();

                if (input == "")
                {
                    throw new ArgumentException(string.Format("first name can not be empty"));

                }

                bool validationForUserName = userRegistration.FirstAndLastName(input);
                if (validationForUserName)
                {
                    
                    Console.WriteLine($"The user name- {input} is valid");
                }
                else
                {
                    Console.WriteLine("The name does not match specified condition");
                    Console.WriteLine("Please enter 1st alphabet as capital and min 3 alphabets");
                }
                Console.WriteLine("Do you want to check again, press y to check");
                string check = Console.ReadLine();
                if (check.ToLower() == "y")
                {
                    FirstName();
                }
            }
            catch (UserRegistrationCustomException ex)
            {
                Console.WriteLine(ex.Message);
                FirstName();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Message can not be empty\n" + ex.GetType().Name + "\n" + ex.Message);
                FirstName();

            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                FirstName();
            }
        }
    
        public static void LastName()
        {
            UserRegistration userRegistration = new UserRegistration();
         
            try
            {
                Console.WriteLine("Please enter the user last name for registration");
                string input = Console.ReadLine();
                if (input == "")
                {
                    throw new ArgumentException(string.Format("last name can not be empty"));

                }


                bool validationForUserName = userRegistration.FirstAndLastName(input);
                if (validationForUserName)
                {
                    Console.WriteLine($"The last name- {input} is valid");

                }
                else
                {
                    Console.WriteLine("The name does not match specified condition");
                    Console.WriteLine("Please enter 1st alphabet as capital and min 3 alphabets");
                    
                    Console.WriteLine("Do you want to check again, press y to check");
                    string check = Console.ReadLine();
                    if (check.ToLower() == "y")
                    {
                        LastName();
                    }
                }
            }
            catch (UserRegistrationCustomException ex)
            {
                Console.WriteLine(ex.Message);
                LastName();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Message can not be empty\n" + ex.GetType().Name + "\n" + ex.Message);
                LastName();

            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                LastName();
            }

        }
      
        public static void Email()
        {
            UserRegistration userRegistration = new UserRegistration();
            
            try
            {
                Console.WriteLine("Please enter the user Email for registration");
                string input = Console.ReadLine();
                if (input == "")
                {
                    throw new ArgumentException(string.Format("no email was entered"));

                }

                
                bool validationForUserName = userRegistration.Email(input);
                if (validationForUserName)
                {
                    Console.WriteLine($"The email- {input} is valid");
                }
                else
                {
                    Console.WriteLine("The name does not match specified condition");
                    Console.WriteLine("Please enter mail id in form of abc.xyz@mnop.com.in");
                }
                Console.WriteLine("Do you want to check again, press y to check");
                string check = Console.ReadLine();
                if (check.ToLower() == "y")
                {
                    Email();
                }
            }
            catch (UserRegistrationCustomException ex)
            {
                Console.WriteLine(ex.Message);
                Email();
            }
            
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Email();
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                Email();
            }
        }
        
        public static void MobileNo()
        {
            UserRegistration userRegistration = new UserRegistration();
            try
            {
                Console.WriteLine("Please enter the user mobile no for registration");
                string input = Console.ReadLine();
                if (input == "")
                {
                    throw new ArgumentException(string.Format("no mobileno was entered"));

                }
                bool validationForUserName = userRegistration.MobileNo(input);
                if (validationForUserName)
                {
                    Console.WriteLine($"The mobile no- {input} is valid");
                }
                else
                {
                    Console.WriteLine("The mobile no does not match specified condition");
                    Console.WriteLine("Please enter country code, followed by space and 10 digit mobile no");
                    

                }
                Console.WriteLine("Do you want to check again, press y to check");
                string check = Console.ReadLine();
                if (check.ToLower() == "y")
                {
                    MobileNo();
                }
            }
            catch (UserRegistrationCustomException ex)
            {
                Console.WriteLine(ex.Message);
                MobileNo();
            }
            
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                MobileNo();
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                MobileNo();
            }

        }
        
        public static void Password()
        {
            
            UserRegistration userRegistration = new UserRegistration();
            
            try
            {
                Console.WriteLine("Please enter the password for registration");
                string input = Console.ReadLine();
                if (input == "")
                {
                    throw new ArgumentException(string.Format("no password was entered"));

                }

                
                bool validationForUserName = userRegistration.Password(input);
                if (validationForUserName)
                {
                    Console.WriteLine($"The password- {input} is valid");
                   


                }
                else
                {
                    Console.WriteLine("The password does not match specified condition");
                    Console.WriteLine("Please enter country code, followed by space and 10 digit mobile no");
                    

                }
                Console.WriteLine("Do you want to check again, press y to check");
                string check = Console.ReadLine();
                if (check.ToLower() == "y")
                {
                    Password();
                }
            }
            catch (UserRegistrationCustomException ex)
            {
                Console.WriteLine(ex.Message);
                Password();
            }
            
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Password();
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                Password();
            }

        }

    }
}
