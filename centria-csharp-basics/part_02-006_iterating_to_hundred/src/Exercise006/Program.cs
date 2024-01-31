using System;

namespace Exercise006
{
  public class Program
  {
    public static void Main(string[] args)
    {
      string userInput = Console.ReadLine();
      int first = Convert.ToInt32(userInput);
      int end = 101;
      for (int i = first; i < end; i++)
{
  Console.WriteLine(i);
}
     

    }
  }
}
