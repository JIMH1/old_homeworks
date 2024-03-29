namespace Exercise018
{
    using System;
    public class Book
    {
        public string name { get; set; }
        public int pages { get; set; }
        public int year { get; set; }
        public Book(string name, int pages, int year)
        {       
        this.name = name;
        this.pages = pages;
        this.year = year;
        }
        public override string ToString()
        {
            return this.name + ", " + this.pages + " pages" + ", " + this.year;
        }
    }
}