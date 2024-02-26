using Interface.Models.Weapons.Abstracts;

namespace Interface.Models.Weapons;

public class Knife : Weapon, IMeleeWeapon
{
    public void Hit()
    {
        Console.WriteLine("Hit!");
    }
}