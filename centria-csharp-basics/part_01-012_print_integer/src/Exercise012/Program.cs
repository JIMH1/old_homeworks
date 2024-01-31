using System;

namespace Exercise012
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a number!");
      string userInput = Console.ReadLine();
      int intValue = Convert.ToInt32(userInput);
      Console.WriteLine("You gave " + intValue);
    }
  }
}
