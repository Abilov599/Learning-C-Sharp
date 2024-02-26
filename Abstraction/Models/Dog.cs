namespace Abstraction.Models;

internal class Dog : AnimalBase
{
    public bool HasCollar { get; set; }
    
    public override void MakeSound()
    {
        Console.WriteLine("Haw haw");
    }
}