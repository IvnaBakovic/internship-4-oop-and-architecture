using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonGame
{
    public class Character
    {
        public string Name { get; set; }
        public int HealthPoints { get; set; }
        public int Experience { get; set; } = 0;
        public int Damage { get; set; }

        public override string ToString()
        {
            return $"{"HP: "+ HealthPoints + " EXP: " + Experience + " DAMAGE: " + Damage }";
        }
        public void Attack(Character Attacker, Character Defender)
        {
            Defender.HealthPoints -= Attacker.Damage;
        }
    }
}
