﻿using System;
using System.Collections.Generic;

namespace Exercise001
{
  public class Program
  {
    public static void Main(string[] args)
    { 
      List<string> list = new List<string>();
      
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }

        list.Add(input);
      }

        Console.WriteLine(list[0]);
      }
  }
}
