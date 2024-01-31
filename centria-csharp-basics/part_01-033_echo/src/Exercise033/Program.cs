using System;

namespace Exercise033
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give the first string:");
      string userInput = Console.ReadLine(); 
      Console.WriteLine("Give the second string:");
      string userInput1 = Console.ReadLine(); 

      if (userInput == userInput1)
      {
        Console.WriteLine("Echo!");
      }
      else
      {
        Console.WriteLine("Nope!");
      }


    }
  }
}
