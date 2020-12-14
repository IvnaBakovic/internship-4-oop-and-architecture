using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonGame
{
    public class Monster:Character
    {
        public Monster()
        {
            DataStore.Monsters.Add(this);
        }
        //public string Name { get; set; }
        public int ProbabilityGenerator { get; set; }
        //public int HealthPoints { get; set; } = 30;
        //public int Experience { get; set; } = 0;
        //public int Damage { get; set; } = 50;

        public bool BeingAlive { get; set; } = true;

        public void isMonsterAlive(int healthPoints)
        {
            if (healthPoints <= 0)
                BeingAlive = false;
        }
        public void BeingAttackedByHero(int damageMadeByHero)
        {
            HealthPoints -= damageMadeByHero;
        }
        
        public override string ToString()
        {
            return $"Monster: {base.ToString()}";
        }

    }
}
