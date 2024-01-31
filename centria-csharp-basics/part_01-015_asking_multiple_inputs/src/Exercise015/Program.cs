using System;

namespace Exercise015
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a string:");
      string message = Console.ReadLine();
      Console.WriteLine("Give an integer:");
      string userInput = Console.ReadLine();
      int intValue = Convert.ToInt32(userInput);
      Console.WriteLine("Give a double:");
      userInput = Console.ReadLine();
      double doubleValue = Convert.ToDouble(userInput);
      Console.WriteLine("Give a boolean:");
      string truth = "True";
      bool booleanValue = System.Convert.ToBoolean(truth);
      Console.WriteLine("Your string: " +message);
      Console.WriteLine("Your integer: " + intValue);
      Console.WriteLine("Your double: " + doubleValue);
      Console.WriteLine("Your boolean: " + booleanValue);


    }
  }
}      
