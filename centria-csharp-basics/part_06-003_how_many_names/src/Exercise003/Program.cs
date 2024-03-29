﻿using System;

namespace Exercise003
{
    public class Program
    {
        public static void Main(string[] args)
    {
      Person ada = new Person("Ada Lovelace");
      Person jack = new Person("Jack The Ripper");
      Person mike = new Person("Mike The Incredible Magic Mouse");

      HowManyNames(ada);
      HowManyNames(jack);
      HowManyNames(mike);
    }

    // Do something here
  
    public static void HowManyNames(Person person)
    {
      Console.WriteLine(person + " has " + person.ToString().Split().Length + " names."); 
    }
  }
}