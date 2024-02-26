namespace Abstraction_Interface_Polymorphism.Models;

internal abstract class AnimalBase
{
    public byte Age;
    public string Name;

    public abstract void MakeSound();
}