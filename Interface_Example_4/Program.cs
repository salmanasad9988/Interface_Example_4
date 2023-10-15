using System;

// Base interface for all animals
interface IAnimal
{
    void Eat();
    void Sleep();
}

// Interface for animals that can fly
interface IFlyableAnimal : IAnimal
{
    void Test()
    {
        Console.WriteLine("test successful");
    }
    void Fly();
}

// Interface for animals that can swim
interface ISwimmableAnimal : IAnimal
{
    void Swim();
}

// Class representing a bird that can fly
class Bird : IFlyableAnimal
{
    public void Eat()
    {
        Console.WriteLine("Bird is eating.");
    }

    public void Sleep()
    {
        Console.WriteLine("Bird is sleeping.");
    }

    public void Fly()
    {
        Console.WriteLine("Bird is flying.");
    }
}

// Class representing a fish that can swim
class Fish : ISwimmableAnimal
{
    public void Eat()
    {
        Console.WriteLine("Fish is eating.");
    }

    public void Sleep()
    {
        Console.WriteLine("Fish is sleeping.");
    }

    public void Swim()
    {
        Console.WriteLine("Fish is swimming.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Bird myBird = new Bird();
        Fish myFish = new Fish();

        Console.WriteLine("Bird Actions:");
        myBird.Eat();
        myBird.Fly();
        myBird.Sleep();
        Console.WriteLine("\n");
        Console.WriteLine("Fish Actions:");
        myFish.Eat();
        myFish.Swim();
        myFish.Sleep();

        Console.ReadKey();
    }
}
