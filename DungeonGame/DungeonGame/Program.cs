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

            };
            goblin.Update();
            var witch = new Witch
            {

            };
            witch.Update();
            var brute = new Brute
            {

            };
            brute.Update();

            var allMon = new GeneratingMonsters
            {

            };
            var chosenHero = warrior;
            List<Monster> monsters = allMon.Generate(goblin, witch, brute, goblin.ProbabilityGenerator,
    witch.ProbabilityGenerator, brute.ProbabilityGenerator);
            //foreach(var monster in monsters)
            //{
            //    Console.WriteLine(monster.Name);
            //}
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
                    Console.WriteLine("Enter your attack: ");
                    int attack = int.Parse(Console.ReadLine());
                    Random random2 = new Random();
                    int number = random2.Next(0, 3);
                    if (RightToAttack.Attack(attack, number) == 1)
                    {
                        Console.WriteLine("Napada čudovište");
                        chosenHero.BeingAttackedByMonster(newMonster.Damage);
                        chosenHero.isHeroAlive(chosenHero.HealthPoints);
                        Console.WriteLine(chosenHero);
                    }
                    else if (RightToAttack.Attack(attack, number) == 0)
                    {
                        Console.WriteLine("Napada heroj");
                        newMonster.BeingAttackedByHero(chosenHero.Damage);
                        newMonster.isMonsterAlive(newMonster.HealthPoints);
                        Console.WriteLine(newMonster);
                    }
                    else
                    {
                        Console.WriteLine("It is tie!");
                    }
                    Console.WriteLine("monster je " + newMonster.BeingAlive + " a heroj je " + chosenHero.BeingAlive);
                }
                monsters.RemoveAt(counter);
            }


            Console.WriteLine(warrior);
            Console.WriteLine("Do you want enter your Health Points (y/n):");
            string answer = Console.ReadLine();
            if(answer=="y" || answer=="Y")
            {
                Console.WriteLine("Enter your Health points: ");
                int healthPoints = int.Parse(Console.ReadLine());
                warrior.HealthPoints = healthPoints;
            }
            else
            {
                Console.WriteLine("Your Health Points will be assigned to you.");
            }
            foreach (var p1 in DataStore.Heros)
            {
                Console.WriteLine(p1);
            }
            Random random = new Random();
            Console.WriteLine(DataStore.Heros.Count);
            int listNumber = random.Next(DataStore.Heros.Count);
            Console.WriteLine(listNumber);


        }
    }
}
