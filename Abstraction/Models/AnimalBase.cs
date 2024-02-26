namespace Abstraction_Interface_Polymorphism.Models;

internal abstract class AnimalBase
{
    public byte Age { get; set; }
    public string Name { get; set; }

    public abstract void MakeSound();
}