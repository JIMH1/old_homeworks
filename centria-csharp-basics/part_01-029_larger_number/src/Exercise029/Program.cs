using System;

namespace Exercise029
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

      if (first > second)
      {
        Console.WriteLine("The larger number is " + first + "!");
      }
      else if (first < second)
      {
        Console.WriteLine ("The larger number is " + second + "!");
      }
      else
      {
        Console.WriteLine ("They are equal!");
      }
    }
  }
}
