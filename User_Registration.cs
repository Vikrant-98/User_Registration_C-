using System;
using System.Text.RegularExpressions;


namespace User_Registration
{
    class User_Registration
    {
        public String nameRegex = @"^[A-Z]{1}[a-z]{2}[a-z]*$";
        public String mailRegex = @"^([a-zA-Z0-9]*[.]*[a-zA-Z0-9]*@[a-zA-Z0-9]*.{1}[a-zA-Z0-9]*[.]*[a-zA-Z0-9]*)$";
        public String mobileRegex = @"^([0-9]{2}[ ]{1}[0-9]{10})$";
        public String passwordRegex = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$";
        public int userRegistration = 0;
        static void Main(string[] args)
        {
            User_Registration obj = new User_Registration();
            obj.FirstName();
            obj.Mail();
            obj.Mobile();
            obj.Password();
            int input = 0;
            Console.WriteLine("Checking mail sample valid or not");
            //Mail checking as many time we want
            while (input == 0)                                                      
            {
                obj.Mail();
                Console.WriteLine("Do you Continue to check mail sample valid or not \n0) to Check or press any : ");
                input = int.Parse(Console.ReadLine());
            }
        }
        /// <summary>
        /// Firstname Validation
        /// Untill user not enter valid name it ask for first name and last name
        /// </summary>
        public void FirstName()
        {
            while (userRegistration < 1)                                            
            {
                Console.WriteLine("Enter your First Name : ");
                String firstName = Console.ReadLine();
                Regex reg = new Regex(nameRegex);
                MatchCollection matchedInput = reg.Matches(firstName);
                try
                {
                    if (matchedInput[0].Value == firstName)
                    {
                        Console.WriteLine("Vaild");
                        userRegistration++;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Not Valid");
                }
            }
            while (userRegistration < 2)                                            
            {
                Console.WriteLine("Enter your Last Name : ");
                String lastName = Console.ReadLine();
                Regex reg = new Regex(nameRegex);
                MatchCollection matchedInput = reg.Matches(lastName);
                try
                {
                    if (matchedInput[0].Value == lastName)
                    {
                        Console.WriteLine("Vaild");
                        userRegistration++;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Not Valid");
                }
            }
        }
        /// <summary>
        /// Mail Validation
        /// Untill user not enter valid Mail it ask for Mail
        /// </summary>
        public void Mail()
        {
            while (userRegistration < 3)                                             
            {
                userRegistration = 0;
                Console.WriteLine("Enter your Mail : ");
                String mail = Console.ReadLine();
                Regex reg = new Regex(mailRegex);
                MatchCollection matchedInput = reg.Matches(mail);
                try
                {
                    if (matchedInput[0].Value == mail)
                    {
                        Console.WriteLine("Vaild");
                        userRegistration = 3;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Not Valid");
                }
            }
        }
        /// <summary>
        /// Mobile Validation
        /// Untill user not enter valid Mobile number it ask for Mobile number
        /// </summary>
        public void Mobile()
        {
            while (userRegistration < 4)                                            
            {
                Console.WriteLine("Enter your Mobile number : ");
                String mobile = Console.ReadLine();
                Regex r = new Regex(mobileRegex);
                Match m = r.Match(mobile);
                try
                {
                    if (m.Success)
                    {
                        Console.WriteLine("Vaild");
                        userRegistration++;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Not Valid");
                }
            }
        }
        /// <summary>
        /// PassWord Validation
        /// Untill user not enter valid Password it ask for PassWord
        /// </summary>
        public void Password()                                                     
        {
            while (userRegistration < 5)
            {
                Console.WriteLine("Enter your Password : ");
                String password = Console.ReadLine();
                Regex reg = new Regex(passwordRegex);
                Match m = reg.Match(password);
                try
                {
                    if (m.Success)
                    {
                        Console.WriteLine("Vaild");
                        userRegistration++;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Not Valid");
                }
            }
        }
    }
}

