using System;
using System.Collections.Generic;

namespace Exercise019
{
  public class Program
  {
    public static void Main(string[] args)
    {
      int[] numbers = { 5, 1, 3, 4, 2 };
      int sum = SumOfNumbersInArray(numbers);
      Console.WriteLine(sum);

    }

    public static int SumOfNumbersInArray(int[] numbers) 
    {
      
      int sum = 0;

      for (int i = 0; i < numbers.Length; i++)
      {
        sum = numbers[i] + sum;
      }
      
      return sum;
    }

  }
}
