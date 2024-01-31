using System;
namespace Exercise008
{
  public class Program
  {
    
    public static void Main(string[] args)
    {
      
      // Write your code here:
      Console.WriteLine("Give numbers:");
      int sum = 0;
      int validnumbers = 0;
      int even = 0;
      int odd = 0;
      
      while (true) 
    {
        int number = Convert.ToInt32(Console.ReadLine());
        if (number == -1) 
      {
        break;
      }
       sum = sum + number;
       validnumbers++;
       if (number % 2 == 0)
      {
        even++;
      }
       else
      {
        odd++; 
      }
      
      
    }

    double average = (double)sum / validnumbers;
      Console.WriteLine("Thx! Bye!");
      Console.WriteLine("Sum: " + sum);
      Console.WriteLine("Numbers: " + validnumbers);
      Console.WriteLine("Average: " + average);
      Console.WriteLine("Even: " + even);
      Console.WriteLine("Odd: " + odd);
    }
  }
}