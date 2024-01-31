using System;

namespace Exercise027
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a number:");
      string userInput = Console.ReadLine();
      int number = Convert.ToInt32(userInput);

      if (number > 0)
      {
        Console.WriteLine("It is positive");
      }
    
    Console.WriteLine("It is not positive");

    }
  }
}




