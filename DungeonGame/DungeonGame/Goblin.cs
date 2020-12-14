using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonGame
{
    public class Goblin:Monster
    {
        public void Update()
        {
            BeingAlive = true;
            HealthPoints = 65;
            Damage = 20;
            Experience = 60;
            ProbabilityGenerator = 50;
            Name = "Goblin";
        }
    }
}
