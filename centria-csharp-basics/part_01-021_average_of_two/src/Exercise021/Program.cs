﻿using System;

namespace Exercise021
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
    double average = (first + second) / 2.0;
    Console.WriteLine("The average is "+ average);
    }
  }
}
