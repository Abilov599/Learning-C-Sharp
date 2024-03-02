using Polymorphism.Models.Animals.Abstracts;

namespace Polymorphism.Models.Animals;

public class Tiger : Cat, IWildAnimal
{
    public void Kill()
    {
        Console.WriteLine("Kill");
    }
}