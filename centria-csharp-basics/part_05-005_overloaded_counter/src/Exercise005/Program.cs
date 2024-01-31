using System;

namespace Exercise005
{
    class Program
  {
    public static void Main(string[] args)
    {
            Counter counter = new Counter(5);
      
      
      counter.Increase();
      counter.Increase(4);
      counter.Decrease(6);
      Console.WriteLine(counter);
    
    
    }
  }
}