using System;

namespace Exercise014
{
    public class Program
    {
       public static void Main(string[] args)
        {

        SimpleDate now = new SimpleDate(13, 2, 2015);
        SimpleDate afterOneWeek = now;
        afterOneWeek.Advance(7);

        Console.WriteLine("Now: " + now);
        Console.WriteLine("After one week: " + afterOneWeek);
        }

    }
}
