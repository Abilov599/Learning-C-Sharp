using Polymorphism.Models.Animals.Abstracts;

namespace Polymorphism.Models.Animals;

internal class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks.");
    }
}