﻿using System;

namespace Exercise010
{
    class Program
  {
    public static void Main(string[] args)
    {
      
      Apartment manhattanStudioApt = new Apartment(1, 16, 5500);
      Apartment atlantaTwoBedroomApt = new Apartment(2, 38, 4200);
      Apartment bangorThreeBedroomApt = new Apartment(3, 78, 2500);
      
      Console.WriteLine(manhattanStudioApt.LargerThan(atlantaTwoBedroomApt));
      Console.WriteLine(bangorThreeBedroomApt.LargerThan(manhattanStudioApt));

      Console.WriteLine(manhattanStudioApt.PriceDifference(atlantaTwoBedroomApt));
      Console.WriteLine(bangorThreeBedroomApt.PriceDifference(manhattanStudioApt));

      Console.WriteLine(manhattanStudioApt.MoreExpensiveThan(atlantaTwoBedroomApt));
      Console.WriteLine(bangorThreeBedroomApt.MoreExpensiveThan(manhattanStudioApt));
    }

  }
}