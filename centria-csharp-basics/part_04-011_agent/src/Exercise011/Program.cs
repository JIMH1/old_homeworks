using System;

namespace Exercise011
{
    public class Program
    {
        public static void Main(string[] args)
    {
      Agent bond = new Agent("James", "Bond");
      Console.WriteLine(bond);

      Agent bourne = new Agent("Jason", "Bourne");
      Console.WriteLine(bourne);
    }
  }
}
