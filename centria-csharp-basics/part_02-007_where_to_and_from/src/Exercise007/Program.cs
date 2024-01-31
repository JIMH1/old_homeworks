using System;

 

namespace Exercise007

{

  public class Program

  {

    public static void Main(string[] args)

    {

      Console.WriteLine("Where to?");
      string userInput = Console.ReadLine();
      int first = Convert.ToInt32(userInput);
      Console.WriteLine("Where from?");
      string userInput2 = Console.ReadLine();
      int number = Convert.ToInt32(userInput2);
 

    while (number <= first)

      {

        Console.WriteLine(number);

        number++;

      }

    

    }

  }

}