using System;

namespace Exercise006
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Product Banana = new Product("Banana", 1, 2);
      Banana.price = 1.1;
      Banana.quantity = 13;
      Banana.name = "Banana";
      Banana.PrintProduct();
    
    }
  }
}