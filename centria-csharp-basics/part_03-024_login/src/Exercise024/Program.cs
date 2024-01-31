using System;

namespace Exercise024
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter username:");
            string userName = Console.ReadLine(); 
            Console.WriteLine("Enter password:");
            string userPasswrd = Console.ReadLine(); 

            if (userName == "alex" && userPasswrd == "sunshine")
            {
                Console.WriteLine("You have successfully logged in!");
            }
            else if (userName == "emma" && userPasswrd == "haskell")
            {
                Console.WriteLine("You have successfully logged in!");
            }
            else
            {
                Console.WriteLine("Incorrect username or password!");
            }
        }
    }
}