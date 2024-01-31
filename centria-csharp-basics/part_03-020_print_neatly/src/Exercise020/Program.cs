using System;
using System.Collections.Generic;

namespace Exercise020
{
  public class Program
  {
    public static void Main(string[] args)
        {
            // You can test your method here
        }

        public static void PrintNeatly(int[] array)
        {
            for (int i = 0; i < array.Length; i++){

                if (i < array.Length - 1)
                {

                    Console.Write(array[i] + ", ");
                }
                else
                {
                    Console.Write(array[i]);
                }
                
            }
          Console.WriteLine();
        }
    }    
  }