using DungeonGame.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonGame.Domain.ModelsServices
{
    public class Ranger:Hero
    {
        int hpRanger = 100;
        int damage = 40;
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
        public void LevelUp(int wonExperiencePoints)
        {
            Experience = Experience - 100;
            hpRanger = hpRanger + (int)Math.Ceiling(wonExperiencePoints * 0.5);
            HealthPoints = hpRanger;
            damage = damage + (int)Math.Ceiling(wonExperiencePoints * 0.5);
            Damage = damage;
        }
    }
}
