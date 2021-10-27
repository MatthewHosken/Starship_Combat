using Starship_Combat.Models;
using System;

namespace Starship_Combat
{
    class Program
    {
        static void Main(string[] args)
        {
            var weapon_1 = new Weapon(6, 2);

            var ship_1 = new Starship(weapon_1, "S.S. New York", 100);

            var weapon_2 = new Weapon(8, 3);

            var ship_2 = new Starship(weapon_2, "S.S. Florida", 125);

            Console.WriteLine("Starship battle has begun.");
            Console.WriteLine("Ship_1 Name: " + ship_1.Name + " Ship_1 BaseHealth: " + ship_1.BaseHealth);
            Console.WriteLine("Ship_2 Name: " + ship_2.Name + " Ship_2 BaseHealth: " + ship_2.BaseHealth);

            Console.WriteLine("Ship_2 Attacks for " + ship_2.Attack(ship_1) + " damage!");

            Console.WriteLine("Ship_1 Name: " + ship_1.Name + " Ship_1 BaseHealth: " + ship_1.BaseHealth);
            Console.WriteLine("Ship_2 Name: " + ship_2.Name + " Ship_2 BaseHealth: " + ship_2.BaseHealth);
        }
    }

    public class Weapon : IWeapon
    {
        public Weapon(int _damage, int _burst)
        {
            this.Burst = 0;
            this.Damage = 0;
            this.Damage = _damage;
            this.Burst = _burst;
        }

        public int Burst { get; set; }
        public int Damage { get; set; }
    }
}
