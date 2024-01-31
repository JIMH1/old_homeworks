using System;
using System.Collections.Generic;

namespace Exercise017
{
  public class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT CHANGE THE FOLLOWING CODE!
      int[] array = new int[5];
      array[0] = 1;
      array[1] = 3;
      array[2] = 5;
      array[3] = 7;
      array[4] = 9;

      int index = 0;
      while (index < array.Length)
      {
        Console.WriteLine(array[index]);
        index++;
      }
          // Implement here
      // asking for the two indices
      // and then swapping them
Console.WriteLine("Give two indices to swap:");  
int n = Convert.ToInt32(Console.ReadLine());  
int t = Convert.ToInt32(Console.ReadLine());  
int temp;  
if(n< array.Length && t< array.Length)  
{  
temp = array[n];  
array[n] = array[t];  
array[t] = temp;  
}  

      // DO NOT CHANGE THE FOLLOWING CODE!
      Console.WriteLine("");
      index = 0;
      while (index < array.Length)
      {
        Console.WriteLine(array[index]);
        index++;
      }
    }
  }
}
