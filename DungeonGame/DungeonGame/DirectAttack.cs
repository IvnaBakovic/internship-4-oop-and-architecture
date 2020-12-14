using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonGame
{
    public class DirectAttack
    {
        public Character Attacker { get; set; }
        public Character Defender { get; set; }

        public void Attack(Character Attacker, Character Defender)
        {
            Defender.HealthPoints -= Attacker.Damage;
        }


    }
}
