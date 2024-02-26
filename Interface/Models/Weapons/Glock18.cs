using Interface.Models.Weapons.Abstracts;

namespace Interface.Models.Weapons;

public class Glock18 : Weapon, IAutomaticWeapon, ISemiautomaticWeapon
{
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