using System;

namespace Exercise037
{
  public class Program
  {
    public static void Main(string[] args)
    {
      int countOnes = 0;
      while (true) 
      {
        Console.WriteLine("Give a number:");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number == 0) 
        {
         break;
        }
        else
        {
          countOnes = countOnes + 1;
        }
      }
      Console.WriteLine("Total amount of numbers: " + countOnes);
    }
  }
}