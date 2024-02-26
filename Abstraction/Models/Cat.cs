namespace Abstraction.Models;

internal class Cat : AnimalBase
{
    public bool HasClothes { get; set; }

    public override void MakeSound()
    {
        Console.WriteLine("Meow meow");
    }
}