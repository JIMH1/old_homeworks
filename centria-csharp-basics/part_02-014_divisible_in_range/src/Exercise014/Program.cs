﻿using System;

namespace Exercise014
{
  public class Program
  {
   public static void Main(String[] args)
    {
      // Call your method here:
      DivisibleByThreeInRange(3, 12);
      
    }

    // Write your method here:
    public static void DivisibleByThreeInRange(int beginning, int end)
   {
      while (beginning <= end)
      {
       if (beginning % 3 == 0)
       {
         Console.WriteLine(beginning);
       }
       beginning++;
      }
    }
  }
}
