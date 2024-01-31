using System;
namespace Exercise031
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string name = "";
            int wordCount = 0;
            int sum = 0;
            int age = 0;
            while (true)
            {
                string input = Console.ReadLine();
                     if (input == (""))
                     {
                         break;
                     }
                string[] longOld = input.Split(","); 
                for (int i = 0; i < input.Length; i++)
                {
                    if (wordCount < longOld[0].Length)
                    {
                        wordCount = longOld[0].Length;
                        name = longOld[0];
                    }
                     sum = 2021 - Convert.ToInt32(longOld[1]);
 if (age < sum)
 {
 age = sum;
 }
                }
            }
            Console.WriteLine("Longest name: " + name);
            Console.WriteLine("Highest age: " + age);
        }
    }
}