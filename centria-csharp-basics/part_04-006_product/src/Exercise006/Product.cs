using System;

namespace Exercise006
{
    public class Product
    {
        public double price { get; set; }
        public int quantity { get; set; }

        public string name { get; set; }
        public override string ToString()
        {
            return this.name + ": price " + this.price + ": " + this.quantity + " pcs";
        }
        
        public Product(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
 
        }

        public void PrintProduct()
        {
            Console.WriteLine(this.name + ": price " + this.price + ": " + this.quantity + " pcs");
        }
    }
}

