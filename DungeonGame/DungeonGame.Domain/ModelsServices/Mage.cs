using DungeonGame.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonGame.Domain.ModelsServices
{
    public class Mage:Hero
    {
        public const int hpMage = 100;

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
        public void RessurectMaga()
        {
            if(!BeingAlive && _firstTimeDead)
            {
                Console.WriteLine("You died and we ressurected you!");
                BeingAlive = true;
                _firstTimeDead = false;
                this.Update();
            }
        }
    }
}
