using System;

namespace Exercise013
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a number!");
      string userInput = Console.ReadLine();
      double intValue = Convert.ToDouble(userInput);
      Console.WriteLine("You gave " + intValue);
    }
  }
}
