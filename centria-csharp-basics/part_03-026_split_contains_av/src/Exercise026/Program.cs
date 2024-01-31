using System;

namespace Exercise026
{
    public class Program
    {
         public static void Main(string[] args)
        {
            while (true)
            {
                string asked = Console.ReadLine();

                if (asked == "")
                {
                    break;
                }
                string[] parts = asked.Split(" ");

                 for (int i = 0; i < parts.Length; i++)
                {
                    if (parts[i].Contains("av"))
                    {
                        Console.WriteLine(parts[i]);
            
            }

            }

          }    

        }

     } 
  }