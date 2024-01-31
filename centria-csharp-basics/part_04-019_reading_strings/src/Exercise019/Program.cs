namespace Exercise019
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {   
            int counter = 0; 
            while(true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
               counter = counter +1;
                
                
            }
        Console.WriteLine(counter);
        }
    }
}