using System;

namespace IfStatementsChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a login name for registration");
            string loginNameRegistration = Console.ReadLine();
            Console.WriteLine("Please enter a password for registration");
            string passwordRegistration = Console.ReadLine();

            Console.WriteLine("Registration successfull. \n \n Please enter login:");
            string loginNameLogin = Console.ReadLine();
            Console.WriteLine("Please enter password:");
            string passwordLogin = Console.ReadLine();

            if (loginNameLogin.Equals(loginNameRegistration) && passwordLogin.Equals(passwordRegistration))
            {
                Console.WriteLine("Login successful");
            }

            else if (loginNameLogin == "" || passwordLogin == "")
                {
                    Console.WriteLine("Please enter both your login and password");
                }

            else if (!loginNameLogin.Equals(loginNameRegistration))
            {
                Console.WriteLine("Login name is incorrect");
            }

            else if (!passwordLogin.Equals(passwordRegistration))
            {
                Console.WriteLine("Password is incorrect");
            }

            Console.ReadLine();



        }
    }
}
