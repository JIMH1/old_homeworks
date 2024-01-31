using System;

 

namespace Exercise012

{

    public class Multiplier

    {

        public int oper;

        public Multiplier(int number)

        {

            this.oper = number;

        }

 

        public int Multiply(int number)

        {

            return (this.oper = this.oper * number);

 

        }

    }

}