using System;

namespace Exercise012
{
  public class Program
  {
    public static void Main(string[] args)
    {
      PrintFromNumberToOne(4);
    }

    //write your method here:

    public static void PrintFromNumberToOne(int number)
    {
      for (int i = number; i > 0; i--)
      {
        Console.WriteLine(i);
        if (i == 1)
        {
          break;
        }
      }
    }
  }
}  