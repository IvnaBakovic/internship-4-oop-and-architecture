using DungeonGame.Data.Models;
using DungeonGame.Domain.ModelsServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonGame.Domain.Services
{
    public static class MonsterAttack
    {
        public static void AttackByMonster(Monster myMonster, Hero myHero)
        {
            if(myMonster is Goblin goblin)
            {
                myMonster.Attack(myMonster, myHero);
                return;
            }
            if(myMonster is Brute brute)
            {
                Random rand = new Random();
                int number = rand.Next(0, 2);
                if(number==0)
                {
                    myMonster.Attack(myMonster, myHero);
                    return;
                }
                Console.WriteLine("Brute attacked you hard. Brute took you 30% of your HealthPoints!");
                brute.AttackHard(myHero);
                return;
            }
            if(myMonster is Witch witch)
            {
                myMonster.Attack(myMonster, myHero);
            }
        }
    }
}
