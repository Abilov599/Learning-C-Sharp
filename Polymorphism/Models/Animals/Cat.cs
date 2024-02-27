using Polymorphism.Models.Animals.Abstracts;

namespace Polymorphism.Models.Animals;

internal class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows.");
    }
}