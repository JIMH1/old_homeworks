using System;

namespace Exercise023
{
  public class Program
  {
    public static void Main(string[] args)
    {
       Console.Write("Give a string: ");
      string userInput = Console.ReadLine(); 

    if (userInput == "true")
    {
      Console.WriteLine("You got it right!");
    }

    else
    {
      Console.WriteLine("Try again!");
    }
    }
  }
}
