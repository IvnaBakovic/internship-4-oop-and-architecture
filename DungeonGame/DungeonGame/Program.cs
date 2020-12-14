using System;
using System.Collections.Generic;

namespace DungeonGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Hero's name: ");
            string nameHero = Console.ReadLine();

            var warrior = new Warrior
            {
                Name = nameHero,
                //HealthPoints = 100,
                //Damage = 10,
            };

            Console.WriteLine(warrior);
            warrior.Update();

            var mage = new Mage
            {
                Name = nameHero,
                HealthPoints = 65,
                Damage = 20,
            };

            var ranger = new Ranger
            {
                Name = nameHero,
                HealthPoints = 50,
                Damage = 30
            };

            var goblin = new Goblin
            {
                BeingAlive = true,
                HealthPoints = 20,
                Damage = 20,
                Experience=60,
            };
            goblin.Update();
            var witch = new Witch
            {
                BeingAlive = true,
                HealthPoints = 20,
                Damage = 20,
                Experience = 60,

            };
            witch.Update();
            var brute = new Brute
            {
                BeingAlive = true,
                HealthPoints = 20,
                Damage = 20,
                Experience = 60,
            };
            brute.Update();

            var allMon = new GeneratingMonsters
            {

            };
            var directAttack = new DirectAttack
            { 
            };
            var character = new Character
            {

            };
            
            var chosenHero = ChoosingHero.chooseHero(warrior,mage,ranger);
            List<Monster> monsters = allMon.Generate(goblin, witch, brute, goblin.ProbabilityGenerator,
    witch.ProbabilityGenerator, brute.ProbabilityGenerator);


            for (int i = 0; i < monsters.Count; i++)
            {
                Console.WriteLine(i + " " + monsters[i].Name);
            }
            Console.WriteLine(monsters[2].Name);

            var RightToAttack = new FightingArena
            {

            };
            int counter = 0;
            while (chosenHero.BeingAlive==true && monsters.Count!=0)
            {
                Console.WriteLine("ovdje si");
                var newMonster = monsters[counter];
                while (chosenHero.BeingAlive == true && newMonster.BeingAlive==true)
                {
                    PrintStatusCharacter.PrintStatus(chosenHero,newMonster);
                    int heroAttack = Options.EnterHeroAttack();
                    int monsterAttack = Options.AttackRandomMonster();
                    if (RightToAttack.Attack(heroAttack, monsterAttack) == 1)
                    {
                        Console.WriteLine("Monster attacks!");
                        directAttack.Attack(newMonster,chosenHero);
                        chosenHero.isHeroAlive(chosenHero.HealthPoints);
                        Console.WriteLine(chosenHero);
                    }
                    else if (RightToAttack.Attack(heroAttack, monsterAttack) == 0)
                    {
                        Console.WriteLine("You attack");
                        Options.DisplayOptions(character,chosenHero,newMonster);
                        newMonster.isMonsterAlive(newMonster.HealthPoints);
                        Console.WriteLine(newMonster);
                    }
                    else
                    {
                        Console.WriteLine("It is tie!");
                    }
                }
                ActionsDueToTheEndOfBattle.RewardingHero(chosenHero,newMonster);
                if(chosenHero.Experience>100)
                {
                    if(chosenHero is Warrior warrior1)
                    {
                        warrior1.LevelUp(newMonster.Experience);
                    }
                }
                goblin.Update();
                brute.Update();
                witch.Update();
                monsters.RemoveAt(counter);
            }


            //Console.WriteLine(warrior);
            //Console.WriteLine("Do you want enter your Health Points (y/n):");
            //string answer = Console.ReadLine();
            //if(answer=="y" || answer=="Y")
            //{
            //    Console.WriteLine("Enter your Health points: ");
            //    int healthPoints = int.Parse(Console.ReadLine());
            //    warrior.HealthPoints = healthPoints;
            //}
            //else
            //{
            //    Console.WriteLine("Your Health Points will be assigned to you.");
            //}
            //foreach (var p1 in DataStore.Heros)
            //{
            //    Console.WriteLine(p1);
            //}
            //Random random = new Random();
            //Console.WriteLine(DataStore.Heros.Count);
            //int listNumber = random.Next(DataStore.Heros.Count);
            //Console.WriteLine(listNumber);


        }
    }
}
