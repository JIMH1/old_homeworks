using System;
namespace Exercise008
{
    public class Debt
    {
        public double balance {get; set;}
        public double interestRate {get; set;}

        public Debt(double initialBalance, double initialInterestRate) 
        {
            this.balance = initialBalance;
            this.interestRate = initialInterestRate;
        }

        public void PrintBalance() 
        {
            Console.WriteLine(this.balance);
        }

        public void WaitOneYear()
        {
            this.balance = this.balance * this.interestRate;
        }
    }
}    