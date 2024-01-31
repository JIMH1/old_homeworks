using System;

 

namespace Exercise010

{

    public class Gauge

    {

        public int value { get; set; } 

        public Gauge() 

        {

            this.value = 0;

        } 

        public void Increase()

        {

            if (this.value < 5)

            {

                this.value = this.value + 1;

            }

            

            //Does NOT grow the value BEYOND FIVE

        }  

        public void Decrease()

        {

            if (this.value > 0)

            {

                this.value = this.value - 1;

            }

            //Does NOT o to NEGATIVE NUMBERS

        }  

 

        public bool Full()

 

        {

            return this.value == 5;

        }

        

          

    }

}