using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonGame.Data.Models
{
    public class Brute:Monster
    {
        public void Update()
        {
            BeingAlive = true;
            HealthPoints = 70;
            Damage = 20;
            Experience = 40;
            ProbabilityGenerator = 30;
            Name = "Brute";
        }
        public void AttackHard(Hero defender)
        {
            defender.HealthPoints -= (int)Math.Floor(defender.HealthPoints*0.30);
        }
    }
}
