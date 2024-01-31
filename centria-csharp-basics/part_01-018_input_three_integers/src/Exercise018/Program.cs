using System;

namespace Exercise018
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
      Console.WriteLine("Give the third number!");
      string userInput3 = Console.ReadLine();
      int third = Convert.ToInt32(userInput3);
      int sum = first+second+third;
      Console.WriteLine("The sum is " + sum);
    }
  }
}
