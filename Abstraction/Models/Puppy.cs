namespace Abstraction.Models;

internal class Puppy : Dog 
{
    public override void MakeSound()
    {
        Console.WriteLine("Puppy: haw haw");
    }
}