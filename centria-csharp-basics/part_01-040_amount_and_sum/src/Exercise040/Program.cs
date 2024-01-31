using System;

namespace Exercise040
{
  public class Program
  {
    public static void Main(string[] args)
    {
     int sum = 0;
     int countOnes = 0;
      while (true) 
      {
        Console.WriteLine("Give a number:");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number == 0) 
        {
         break;
        }

         if  (number < 0)
          {
        sum = sum + 1;
          }
    {
 
        countOnes = countOnes + 1;

        }
      }
      Console.WriteLine("Total sum of numbers: " + sum);
      Console.WriteLine("Total amount of numbers: " + countOnes);
    }
  }
}