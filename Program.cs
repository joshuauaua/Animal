namespace Animal;

class Program
{
    static void Main(string[] args)
    {
        Eagle eagle1 = new Eagle("Richie", "Accipitridae", 9, true, true, "B/W", "Very Good");
        eagle1.makeSound();

        Dog dog1 = new Dog("Osita", "Hound", 13, true, false, "Brown");
        dog1.makeSound();

        Crocodile crocodile1 = new Crocodile("Patricia", "Reptile", 47, true, false, 233);
        crocodile1.makeSound();

    }
}