using System;

namespace Exercise019
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give the first number!");
      string userInput = Console.ReadLine();
      int first = Convert.ToInt32(userInput);
      Console.WriteLine("Give the second number!");
      string userInput2 = Console.ReadLine();
      int second = Convert.ToInt32(userInput2);
      int sum = first+second;
      Console.WriteLine(first+" + "+ second+" = "+sum);
    }
  }
}
