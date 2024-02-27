namespace Polymorphism.Models.Animals.Abstracts;

public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}
