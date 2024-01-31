using System;

namespace Exercise003
{
  public class Program
  {
    public static void Main(string[] args)
    {
      //Write your code here
      string userInput = Console.ReadLine();
      int first = Convert.ToInt32(userInput);

      if (first < 0)
      {
        int sum = first * -1;
        Console.WriteLine(sum);
      }

      else
      {
        Console.WriteLine(first);
      }

    }
  }
}
