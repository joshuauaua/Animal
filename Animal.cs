namespace Animal;

public class Animal
{
    public string AnimalName = "Default name";
    public string Family = "Default family";
    public int Age = 0;
    public bool Carnivore = true;
    public bool CanFly = true;

    public Animal(string animalName, string family, int age, bool carnivore, bool canFly)
    {
        this.AnimalName = animalName;
        this.Family = family;
        this.Age = age;
        this.Carnivore = carnivore;
        this.CanFly = canFly;
    }

    public void Sleep()
    {
        Console.WriteLine("Time to sleep");
    }

    public void Eat()
    {
        Console.WriteLine("Time to eat");
    }

    public void Groom()
    {
        Console.WriteLine("Time to groom");
    }

    public virtual void makeSound()
    {
        Console.WriteLine("Animal makes a noise");
    }
}


public class Dog : Animal
{
    public string Colour = "Default colour";

    public Dog(string animalName, string family, int age, bool carnivore, bool canFly, string colour) :base( animalName,  family,  age,  carnivore,  canFly)
    {
        this.Colour = colour;
    }
        
        
    public override void makeSound()
    {
        Console.WriteLine("Dog makes a noise");
    }

    public void RollOver()
    {
        Console.WriteLine("Dog rolls over");
    }
}

public class Crocodile : Animal
{
    public int NumberOfTeeth = 0;

    public Crocodile(string animalName, string family, int age, bool carnivore, bool canFly, int numberOfTeeth) :base( animalName,  family,  age,  carnivore,  canFly)
    {
        this.NumberOfTeeth = numberOfTeeth;
    }
    
    public override void makeSound()
    {
        Console.WriteLine("Crocodile makes a noise");
    }

    public void Bite()
    {
        Console.WriteLine("Crocodile Bites");
    }
}

public class Bird : Animal
{
    public string FeatherColour = "Default colour";

    public Bird(string animalName, string family, int age, bool carnivore, bool canFly, string featherColour) :base( animalName,  family,  age,  carnivore,  canFly)
    {
        this.FeatherColour = featherColour;
    }

    public override void makeSound()
    {
        Console.WriteLine("Bird makes a noise");
    }
    public void Chirp()                           
    {                                            
        Console.WriteLine("Bird chirps");    
    }                                            
    
}


public class Rooster : Bird
{
    public string FarmName = "Default farm name";

    public Rooster(string animalName, string family, int age, bool carnivore, bool canFly, string featherColour,
        string farmName) : base(animalName, family, age, carnivore, canFly, featherColour)
    {
        this.FarmName = farmName;
    }

    public void Cockle()
    {
        Console.WriteLine("Cockledoodledooooo!");
    }
}

public class Eagle : Bird
{
    public string HuntingLevel = "Default hunting level";

    public Eagle(string animalName, string family, int age, bool carnivore, bool canFly, string featherColour,
        string huntingLevel)
        : base(animalName, family, age, carnivore, canFly, featherColour)
    {
        this.HuntingLevel = huntingLevel;
    }

    public void Swoop()
    {
        Console.WriteLine("The eagle swoops down");
    }

}