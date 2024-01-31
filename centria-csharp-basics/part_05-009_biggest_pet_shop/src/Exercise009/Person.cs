namespace Exercise009
{
     public class Person
  {

    private string name;
    private Pet pet;

    public Person(string name, Pet pet)
    {
      this.name = name;
      this.pet = pet;
    }

    public Person(string name) : this(name, new Pet("Toothless", "dragon"))
    {
    }

    public Person() : this("Lilo", new Pet("Stitch", "blue alien"))
    {
    }

    public override string ToString()
    {
          return this.name + ", " + "has a friend called " + this.pet.name + " (" + this.pet.breed + ")";
      
    }

  }
}