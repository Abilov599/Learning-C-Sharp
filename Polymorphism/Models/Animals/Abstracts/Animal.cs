namespace Polymorphism.Models.Animals.Abstracts;

internal class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}
