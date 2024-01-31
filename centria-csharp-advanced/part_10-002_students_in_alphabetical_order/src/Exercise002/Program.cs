using System;
using System.Collections.Generic;

namespace Exercise002
{
    public class Program
    {
        public static void Main(string[] args)
    {
      Student first = new Student("jamo");
      Student second = new Student("jamo1");
      
      Console.WriteLine(first.CompareTo(second));
    }
  }
}