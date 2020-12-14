using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonGame
{
    public class Ranger:Hero
    {
        public const int hpRanger = 100;
        public int CriticalChance { get; set; } = 40;
        public int StunChance { get; set; } = 0;

        public override string ToString()
        {
            return $"{base.ToString()} - {CriticalChance} - {StunChance}";
        }


        public void RenewHpForExp()
        {
            Experience = (int)Math.Ceiling(Experience / 2.0);
            HealthPoints = hpRanger;
        }

        public void CriticalAttack(Ranger ranger, Monster monster)
        {
            monster.HealthPoints -= ranger.Damage * 2;
        }
    }
}
