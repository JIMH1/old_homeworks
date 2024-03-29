namespace Exercise002
{
    using System;
  public class Student : IComparable<Student>
  {

    public string name { get; }

    public Student(string name)
    {
      this.name = name;
    }


    public override string ToString()
    {
      return name;
    }

    public int CompareTo(Student another)
    {

      return this.name.CompareTo(another.name);
    }
  }
}