using System;

namespace Exercise010
{
  public class Program
  {
    public static void Main(string[] args)
    {
       // ask the user for the number of times that the phrase will be printed
        Console.WriteLine("How many times?");
        string userInput = Console.ReadLine();
        int number = Convert.ToInt32(userInput);
        int countOnes = 0;
      // use the while command to call the method a suitable number of times
      while (true) 
      {
        if (countOnes < number)
        {
          PrintPhrase();
          countOnes = countOnes + 1;
        }

        if (countOnes == number)
        {
          break;
        }
       


        
       
        
      }
      
    }
    // Write your method here:
    public static void PrintPhrase() 
    {
      Console.WriteLine("In a hole in the ground there lived a method");
    }
  }
}