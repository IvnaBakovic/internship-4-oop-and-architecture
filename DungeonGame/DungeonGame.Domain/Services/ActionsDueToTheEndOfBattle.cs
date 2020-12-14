using DungeonGame.Data.Models;
using DungeonGame.Domain.ModelsServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonGame.Domain.Services
{
    public static class ActionsDueToTheEndOfBattle
    {
        public static void RewardingHero (Hero myHero, Monster myMonster)
        {
            if (myHero.HealthPoints < 0)
            {
                if (myHero is Mage mage)
                {
                    mage.RessurectMaga();
                }
            }
            if (myHero.HealthPoints>0)
            {
                myHero.HealthPoints += (int)Math.Ceiling(myHero.HealthPoints * 0.25);
                myHero.Experience += myMonster.Experience;
                Console.WriteLine("Do you want to give up half of your Experience to renew you HealthPoints? yes/no");
                string answer = Console.ReadLine();
                if (answer == "yes")
                {
                    if (myHero is Warrior warrior)
                    {
                        warrior.RenewHpForExp();
                    }
                    if (myHero is Mage mage)
                    {
                        mage.RenewHpForExp();

                    }
                    if (myHero is Ranger ranger)
                    {
                        ranger.RenewHpForExp();
                    }
                }
                else
                {
                    Console.WriteLine("Continue your game!");
                }
            }


        }
    }
}
