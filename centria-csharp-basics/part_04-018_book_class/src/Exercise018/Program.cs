namespace Exercise018
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Book> list = new List<Book>();
            while(true)
            {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            if (name == "")
            {
                break;
            }
            Console.Write("Pages: ");
            int pages = Convert.ToInt32(Console.ReadLine());
            Console.Write("Publication year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            list.Add(new Book(name, pages, year));  
            } 
            Console.WriteLine();
            Console.Write("What information will be printed? ");
            string answer = Console.ReadLine();
            foreach (Book item in list)
            {
            if (answer == "everything")
            {
                Console.WriteLine(item);
            }
            else if (answer == "title")
            {
                Console.WriteLine(item.name);
            }
            else
            {
                Console.Write("");
            }

            }
            // implement here the program that allows the user to enter 
            // book information and to examine them
        }
    }
}