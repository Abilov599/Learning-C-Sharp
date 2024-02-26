namespace Abstraction_Interface_Polymorphism.Models;

internal class Puppy : Dog 
{
    public override void MakeSound()
    {
        Console.WriteLine("Puppy: haw haw");
    }
}