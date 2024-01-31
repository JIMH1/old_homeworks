using System;
using System.Collections.Generic;
namespace Exercise029
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
 
            int oldest = 0;
            string name = "";
            int age = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                string[] pieces = input.Split(",");


 
                if (oldest < Convert.ToInt32(pieces[1]))
                {
                    oldest = Convert.ToInt32(pieces[1]);
                    name = pieces[0];
 
                }
            }
            Console.WriteLine("Age of the oldest: " + oldest);
 
        }
    }
}