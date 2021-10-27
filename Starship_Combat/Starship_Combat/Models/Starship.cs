using System;
using System.Collections.Generic;
using System.Text;
namespace Starship_Combat.Models
{
    public class Starship
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BaseHealth { get; set; }
        
        public IWeapon Weapon { get; set; }

        public Starship(IWeapon weapon, string name, int baseHealth)
        {
            this.Name = name;
            this.Weapon = weapon;
            this.BaseHealth = baseHealth;
        }

        public int Attack(Starship targetShip)
        {
            targetShip.BaseHealth = targetShip.BaseHealth - this.Weapon.Damage * this.Weapon.Burst;
            return this.Weapon.Damage * this.Weapon.Burst;
        }
    }
}
