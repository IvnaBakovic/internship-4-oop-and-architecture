using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonGame
{
    public class AngerAttack
    {
        public Warrior Warrior { get; set; }
        public Monster Monster { get; set; }

        public void AttackingAngrily(Warrior warrior, Monster monster)
        {
            warrior.HealthPoints -= (int)Math.Floor(warrior.HealthPoints * 0.15);
            monster.HealthPoints -= 2 * warrior.Damage;
        }
    }
}
