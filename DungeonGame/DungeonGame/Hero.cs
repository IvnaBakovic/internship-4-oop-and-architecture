using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonGame
{
    public class Hero:Character
    {
        public Hero()
        {
            DataStore.Heros.Add(this);
        }
        //public string Name { get; set; }
        //public int HealthPoints { get; set; }
        //public int Experience { get; set; } = 0;
        //public int Damage { get; set; }
        public bool BeingAlive { get; set; } = true;

        public void BeingAttackedByMonster(int damageMadeByMonster)
        {
            HealthPoints -= damageMadeByMonster;
        }

        public void isHeroAlive(int healthPoints)
        {
            if (healthPoints <= 0)
                BeingAlive = false;
        }
        public override string ToString()
        {
            return $"Hero: {base.ToString()}";
         
        }
    }
}
