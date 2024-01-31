using System;
using System.Collections.Generic;

namespace Exercise022
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.Write("Give a word: ");
      string userInput = Console.ReadLine();
      
      Console.WriteLine(userInput+userInput+userInput);

    }
  }
}
