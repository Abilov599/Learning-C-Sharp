using Interface.Models.Weapons.Abstracts;

namespace Interface.Models.Weapons;

// For example, let's assume that the Ak47 has only automatic mode ;)
public class Ak47 : Weapon, IAutomaticWeapon
{
    public string CountryName { get; set; }
    
    public void Reload()
    {
        Console.WriteLine(BulletCount = MaximumCapacity);
    }

    public void Fire()
    {
        if (BulletCount > 0)
        {
            BulletCount = 0;
        }
        else
        {
            Console.WriteLine("Reload your weapon");
        }
    }
}