﻿using System;

namespace Exercise014
{
    public class Program
    {
       public static void Main(string[] args)
    {
      PaymentCard card = new PaymentCard(100);
      Console.WriteLine(card);

      card.AddMoney(49.99);
      Console.WriteLine(card);

      card.AddMoney(10000.0);
      Console.WriteLine(card);

      card.AddMoney(-10);
      Console.WriteLine(card);
    }
  }
}
