namespace Abstraction_Interface_Polymorphism.Models;

internal class Cat : AnimalBase
{
    public bool HasClothes { get; set; }

    public override void MakeSound()
    {
        Console.WriteLine("Meow meow");
    }
}