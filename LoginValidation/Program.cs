using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //login: admin
            //password: pass1234

            // diclare variables
            //assign value - 
            string login = "admin";
            string password = "pass1234";

            string username, userpassword;
            Console.WriteLine("Enter your login:");
            login = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            password = Console.ReadLine();

            if (login == username && password == userpassword)
            {
                Console.WriteLine("Welcome!");
            }
            else
            {
                Console.WriteLine("Oops, something went wrong.");
            }
        }
    }
}
