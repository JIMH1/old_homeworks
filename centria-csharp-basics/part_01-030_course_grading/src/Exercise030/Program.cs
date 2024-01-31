using System;

namespace Exercise030
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give your percent [0 - 100]:");
      string userInput = Console.ReadLine();
      int first = Convert.ToInt32(userInput);

      if (first < 0)
        {
         Console.WriteLine("Impossible");
        }
      else if (first > 100)
        {
          Console.WriteLine ("Outstanding!");
        }
      else if (first >= 90)
        {
          Console.WriteLine ("Grade: 5");
        }

      else if (first >= 80)
        {
          Console.WriteLine ("Grade: 4");
        }

      else if (first >= 70)
        {
          Console.WriteLine ("Grade: 3");
        }

      else if (first >= 60)
        {
          Console.WriteLine ("Grade: 2");
        }

      else if (first >= 50)
        {
          Console.WriteLine ("Grade: 1");
        }

      else
        {
          Console.WriteLine ("Fail");
        }
    }
  }
}
