using System;

namespace Exercise004
{
  public class Program
  {
    public static void Main(string[] args)
    {
      string userInput = Console.ReadLine();
      int first = Convert.ToInt32(userInput);
      string userInput2 = Console.ReadLine();
      int second = Convert.ToInt32(userInput2); 

      if (first > second)
      {
        Console.WriteLine(first + " is greater than "+ second + ".");
      }

      else if(first < second)
      {
        Console.WriteLine(first + " is less than " + second + ".");
      }    

      else
      {
        Console.WriteLine(first + " is equal to " + second+ ".");
      }
    }
  }
}
