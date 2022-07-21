using System;

namespace IfStatementsChallenge
{
    internal class Program
    {
        static string username;
        static string password;

        static void Main(string[] args)
        {
            Register();
            Login();
            Console.ReadLine();
        }
        public static void Register()
            {
                Console.WriteLine("Please enter a username for registration");
                username = Console.ReadLine();
                Console.WriteLine("Please enter a password for registration");
                password = Console.ReadLine();

                Console.WriteLine("Registration successful");
                Console.WriteLine("----------------------------------------------");
            }

        public static void Login()
            { 
                Console.WriteLine("Please enter username:");


            if (username == Console.ReadLine())
            {
                Console.WriteLine("Please enter password");

                if (password == Console.ReadLine())
                {
                    Console.WriteLine("Login successful");
                }


                else
                {
                    Console.WriteLine("Login failed, wrong password");
                }
            }
            else
            {
                Console.WriteLine("Login failed, wrong username");
            }
        }
    }
}
