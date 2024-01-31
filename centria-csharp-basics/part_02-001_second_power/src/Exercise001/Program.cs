using System;
namespace Exercise001
{
  public class Program
  {
    public static void Main(string[] args)
    {
      string userInput = Console.ReadLine();
      int first = Convert.ToInt32(userInput);
      int sum = first*first;

      Console.WriteLine(sum);
    }
  }
}
