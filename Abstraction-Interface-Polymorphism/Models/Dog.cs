namespace Abstraction_Interface_Polymorphism.Models;

internal class Dog : AnimalBase
{
    public bool HasCollar;
    
    public override void MakeSound()
    {
        Console.WriteLine("Haw haw");
    }
}