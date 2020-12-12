using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonGame
{
    public class Warrior:Hero
    {
        public bool AngerAttack { get; set; } = false;

        public int h { get; set; } = 150;

        public void Update()
        {
            HealthPoints = 100;
            Damage = 15;
        }

        public void isMonsterAlive(int healthPoints)
        {
            if (healthPoints <= 0)
                BeingAlive = false;
        }

        public override string ToString()
        {
            return $"{base.ToString()} - {AngerAttack}";
        }
    }
}
