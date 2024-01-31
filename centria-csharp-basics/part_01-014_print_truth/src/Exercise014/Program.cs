using System;

namespace Exercise014
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give me the truth!");
      string truth = "True";
      bool booleanValue = System.Convert.ToBoolean(truth);
      Console.WriteLine(booleanValue);
    }
  }
}
