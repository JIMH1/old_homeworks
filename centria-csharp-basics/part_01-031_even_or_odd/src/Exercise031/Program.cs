using System;

namespace Exercise031
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a number:");
      string userInput = Console.ReadLine();
      int first = Convert.ToInt32(userInput);
      if (first % 2 == 0)
      {
         Console.WriteLine("It is even.");
      }
      else
      {
        Console.WriteLine("It is odd.");
      }
    }
  }
}