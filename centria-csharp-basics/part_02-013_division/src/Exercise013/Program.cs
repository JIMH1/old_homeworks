using System;

namespace Exercise013
{
  public class Program
  {
    public static void Main(string[] args)
    {

      Division(6,5);
    }
        //Write your method here
    public static void Division(int numerator, int denominator) 
    {
     
        double result = (double)numerator/(double)denominator;
        Console.WriteLine(result);
    }
  }
}
