using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonGame.Data.Models
{
    public class Goblin:Monster
    {
        public void Update()
        {
            BeingAlive = true;
            HealthPoints = 50;
            Damage = 10;
            Experience = 20;
            ProbabilityGenerator = 60;
            Name = "Goblin";
        }
    }
}
