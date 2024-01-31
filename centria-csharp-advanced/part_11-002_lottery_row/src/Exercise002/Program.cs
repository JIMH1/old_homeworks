using System;
using System.Collections.Generic;

namespace Exercise002
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LotteryRow row = new LotteryRow();
            List<int> lotteryNumbers = row.Numbers(); 
            Console.WriteLine("Lottery numbers:");
            foreach (int number in row.numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("");
        }
    }
}