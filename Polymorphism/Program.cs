using Polymorphism.Models.Animals;
using Polymorphism.Models.Animals.Abstracts;

var animals = new Animal[] { new Dog(), new Cat() };

foreach (var animal in animals)
{
    animal.MakeSound();
}