using Polymorphism.Models.Animals;
using Polymorphism.Models.Animals.Abstracts;

var animals = new Animal[] { new Dog(), new Cat() };

foreach (var animal in animals)
{
    animal.MakeSound();
}

Tiger tiger = new Tiger();
Cat tigerCat = new Tiger();
IWildAnimal tigerWithInterface = new Tiger();