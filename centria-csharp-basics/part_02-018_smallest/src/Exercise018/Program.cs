using System;

namespace Exercise018
{
  public class Program
  {
    public static void Main(string[] args)
    {
     Smallest (5,7);
    }
    //Write your method here:
    public static int Smallest(int number1, int number2)
    {
       if (number1 < number2)
        {
          return number1;  
        }
        else
        {
            return number2;
        }
    }
  }
}