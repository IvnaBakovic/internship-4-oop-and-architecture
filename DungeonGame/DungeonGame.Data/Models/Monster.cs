using System;
using System.Collections.Generic;
using System.Text;
namespace DungeonGame.Data.Models
{
    public class Monster:Character
    {
        public Monster()
        {
            DataStore.Monsters.Add(this);
        }
        public int ProbabilityGenerator { get; set; }

        public bool BeingAlive { get; set; } = true;

        public void isMonsterAlive(int healthPoints)
        {
            if (healthPoints <= 0)
                BeingAlive = false;
        }
        
        public override string ToString()
        {
            return $"Monster: {base.ToString()}";
        }

    }
}
