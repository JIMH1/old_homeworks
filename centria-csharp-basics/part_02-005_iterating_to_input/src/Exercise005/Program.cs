using System;

namespace Exercise005
{
  public class Program
  {
    public static void Main(string[] args)
    {
      string userInput = Console.ReadLine();
      int first = Convert.ToInt32(userInput);

    int number = 0;
    while (number <= first)
      {
        Console.WriteLine(number);
        number++;
      }
    }
  }
}
