var shark = new Shark("kenny", 32, "bored");
var cat = new Cat("baks", 10, "retired");
var dog = new Dog("dog", 2, "fish", "Shi-fu");
Console.WriteLine(dog.Introduce());
Console.WriteLine(cat.Introduce());
Console.WriteLine(shark.Introduce());
Console.WriteLine(dog.GreetMaster());

public class Animal
{
    public int Age;
    public int Legs;
    public string Name;
    public string Species;
    public string Status;
  
    public Animal(string name, int age, int legs, string species, string status)
    {
        this.Name = name;
        this.Age = age;
        this.Legs = legs;
        this.Species = species;
        this.Status = status;
    }
  
    public virtual string Introduce()
    {
        return $"Hello, my name is {this.Name} and I am {this.Age} years old.";
    }
}

public class Shark : Animal
{
    public Shark(string name, int age, string status) : base(name, age, 0, "shark", status)
    {
        Name = name;
        Age = age;
        Status = status;
    }
  
    public override string Introduce()
    {
        return $"Hello, my name is {this.Name} and I am {this.Age} years old.";
    }
}

public class Cat : Animal
{
    // Do the same here as you did for Shark - define your constructor function and any other methods you need
  
    public Cat(string name, int age, string status) : base(name, age, 4, "cat", status)
    {
        Name = name;
        Age = age;
        Status = status;
    }
  
    public override string Introduce()
    {
        return $"Hello, my name is {this.Name} and I am {this.Age} years old.  Meow meow!";
    }
}

public class Dog : Animal
{
    string Master;
    // On your own now - you can do it :D
    public Dog(string name, int age, string status, string master) : base(name, age, 4, "dog", status)
    {
        Name = name;
        Age = age;
        Status = status;
        Master = master;
    }
    
    public override string Introduce()
    {
        return $"Hello, my name is {this.Name} and I am {this.Age} years old.";
    }
    
    public string GreetMaster()
    {
        return $"Hello {this.Master}";
    }
}