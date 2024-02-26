using Interface.Models.Weapons;

var ak47 = new Ak47{MaximumCapacity = 30, BulletCount = 15, CountryName = "Russia"};

// ak47.Reload();

var deagle = new DesertEagle{MaximumCapacity = 7, BulletCount = 2, Material = "Steel" };

Console.WriteLine(deagle.Material);