using System;
namespace Exercise021
{
  public class Program
  {
    public static void Main(string[] args)
    {
      int[] array = {5, 1, 3, 4, 2};
      PrintArrayInStars(array);
    }
    public static void PrintArrayInStars(int[] array)
    {
     for(int i = 0; i < array.Length; i++)
      {
          int index = 0;
          while(index < array[i])
          {
          Console.Write("*");
          index++;
        }
        Console.WriteLine("");
      }
    }
  }
}