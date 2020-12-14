using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonGame
{
    public class Warrior:Hero
    {
        int hPWarrior = 200;
        int damage = 30;
        public bool AngerAttack { get; set; } = false;


        public int h { get; set; } = 150;

        public void Update()
        {
            HealthPoints = hPWarrior;
            Damage = damage;
        }
        public void AttackingAngrily(Warrior warrior, Monster monster)
        {
            warrior.HealthPoints -= (int)Math.Floor(warrior.HealthPoints * 0.15);
            monster.HealthPoints -= 2 * warrior.Damage;
        }
        public void LevelUp(int wonExperiencePoints)
        {
            Experience = Experience - 100;
            hPWarrior = hPWarrior + (int)Math.Ceiling(wonExperiencePoints * 0.5);
            HealthPoints = hPWarrior;
            damage = damage + (int)Math.Ceiling(wonExperiencePoints * 0.5);
            Damage = damage;
        }

        public void RenewHpForExp()
        {
            Experience = (int)Math.Ceiling(Experience / 2.0);
            HealthPoints = hPWarrior;
        }

        public void isMonsterAlive(int healthPoints)
        {
            if (healthPoints <= 0)
                BeingAlive = false;
        }

        public override string ToString()
        {
            return $"{base.ToString()}";
        }
    }
}
