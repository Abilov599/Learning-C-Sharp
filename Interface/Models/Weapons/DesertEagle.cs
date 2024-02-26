using Interface.Models.Weapons.Abstracts;

namespace Interface.Models.Weapons;

public class DesertEagle : Weapon, ISemiautomaticWeapon
{
    public string Material { get; set; }

    public void Reload()
    {
        Console.WriteLine(BulletCount = MaximumCapacity);
    }

    public void Shoot()
    {
        if (BulletCount > 0)
        {
            BulletCount -= 1;
        }
        else
        {
            Console.WriteLine("Reload your weapon");
        }
    }
}