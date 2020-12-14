using DungeonGame.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonGame.Domain.ModelsServices
{
    public class Ranger:Hero
    {
        int hpRanger = 150;
        int damage = 30;
        int criticalChance = 40;
        int stunChance = 50;
        public int CriticalChance { get; set; }
        public int StunChance { get; set; } 
        public void Update()
        {
            CriticalChance = criticalChance;
            StunChance = stunChance;
            HealthPoints = hpRanger;
            Damage = damage;
        }

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
            criticalChance = criticalChance + (int)Math.Ceiling(criticalChance * 0.20);
            CriticalChance = criticalChance;
            stunChance = stunChance + (int)Math.Ceiling(criticalChance * 0.30);
            StunChance = stunChance;
        }
    }
}
