namespace Interface.Models.Weapons.Abstracts;

public abstract class Weapon
{
    public double Price { get; set; }
    public string Name { get; set; }
    public int MaximumCapacity { get; set; }
    public int BulletCount { get; set; }
}