using Polymorphism.Models.Animals.Abstracts;

namespace Polymorphism.Models.Animals;

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows.");
    }
}