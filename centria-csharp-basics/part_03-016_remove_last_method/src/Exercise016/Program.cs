using System;
using System.Collections.Generic;

namespace Exercise016
{
  public class Program
  {
   public static void Main(string[] args)
        {
          
        List<string> strings = new List<string>();

        strings.Add("First");
        strings.Add("Second");
        strings.Add("Third");

        strings.ForEach(Console.WriteLine);
        RemoveLast(strings);
        RemoveLast(strings);

        strings.ForEach(Console.WriteLine);

        }
        public static void RemoveLast(List<string> strings)
        {
        
        int Last = strings.Count -1;
        strings.RemoveAt(Last);
        {
            
        }
            
        }

  }
}