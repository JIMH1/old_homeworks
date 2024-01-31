using System;

namespace Exercise002
{
  public class Program
  {
    public static void Main(string[] args)
    {
      string userInput = Console.ReadLine();
      int first = Convert.ToInt32(userInput);
      string userInput2 = Console.ReadLine();
      int second = Convert.ToInt32(userInput2);
      int sum = first+second;

     double squareRoot = Math.Sqrt(sum);
     Console.WriteLine(squareRoot);

    }
  }
}
