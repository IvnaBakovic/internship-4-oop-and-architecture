using DungeonGame.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonGame.Domain.ModelsServices
{
    public class Mage:Hero
    {
        int hpMage = 100;
        int damage = 30;

        public void Update()
        {
            HealthPoints = hpMage;
            Damage = 20;
            Experience = 0;
        }
        public int Mana { get; set; } = 50;

        private bool _firstTimeDead = true;
        public override string ToString()
        {
            return $"{base.ToString()} - {Mana}";
        }

        public void RenewalHealthPointsInExchangedForMana()
        {
            
                Mana -= (int)Math.Floor(Mana*0.5);
                HealthPoints = 60;     
        }
        public void RenewHpForExp()
        {
            Experience = (int)Math.Ceiling(Experience / 2.0);
            HealthPoints = hpMage;
        }
        public void MageAttack(Character mageAttacker, Character monster)
        {
         
                Attack(mageAttacker, monster);
                Mana -= (int)Math.Floor(Mana * 0.1);
                return;      
        }
        public void LevelUp(int wonExperiencePoints)
        {
            Experience = Experience - 100;
            hpMage = hpMage + (int)Math.Ceiling(wonExperiencePoints * 0.5);
            HealthPoints = hpMage;
            damage = damage + (int)Math.Ceiling(wonExperiencePoints * 0.5);
            Damage = damage;
        }
        public void RessurectMaga()
        {
            if(!BeingAlive && _firstTimeDead)
            {
                Console.WriteLine("You died first and now you ressurected!");
                BeingAlive = true;
                _firstTimeDead = false;
                this.Update();
            }
        }
    }
}
