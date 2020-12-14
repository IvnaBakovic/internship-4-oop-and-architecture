using DungeonGame.Data.Models;
using DungeonGame.Domain.Helpers;
using DungeonGame.Domain.ModelsServices;
using DungeonGame.Domain.Services;
using System;
using System.Collections.Generic;

namespace DungeonGame.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Hero's name: ");
            string nameHero = Console.ReadLine();

            var warrior = new Warrior
            {

            };
            warrior.Update();

            var mage = new Mage
            {

            };
            mage.Update();

            var ranger = new Ranger
            {

            };
            ranger.Update();

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
            var character = new Character
            {

            };

            var RightToAttack = new FightingArena
            {

            };


            var chosenHero = ChoosingHero.chooseHero(warrior, mage, ranger);
            chosenHero.Name = nameHero;
            List<Monster> monsters = allMon.Generate(goblin, witch, brute, goblin.ProbabilityGenerator,
    witch.ProbabilityGenerator, brute.ProbabilityGenerator);


            int counter = 0;
            int level = 1;
            while (chosenHero.BeingAlive == true && monsters.Count != 0)
            {
                var newMonster = monsters[counter];
                while (chosenHero.BeingAlive == true && newMonster.BeingAlive == true)
                {
                    PrintStatusCharacter.PrintStatus(chosenHero, newMonster);
                    Console.WriteLine("\nLevel: " + level);
                    int heroAttack = Options.EnterHeroAttack();
                    int monsterAttack = Options.AttackRandomMonster();
                    if (RightToAttack.Attack(heroAttack, monsterAttack) == 1)
                    {
                        Console.WriteLine("\nMonster attacks!\n");
                        MonsterAttack.AttackByMonster(newMonster, chosenHero);
                        chosenHero.isHeroAlive(chosenHero.HealthPoints);
                    }
                    else if (RightToAttack.Attack(heroAttack, monsterAttack) == 0)
                    {
                        Console.WriteLine("\nYou attack!\n");
                        Options.DisplayOptions(character, chosenHero, newMonster);
                        newMonster.isMonsterAlive(newMonster.HealthPoints);
                    }
                    else
                    {
                        Console.WriteLine("\nIt is tie!\n");
                    }
                }
                ActionsDueToTheEndOfBattle.RewardingHero(chosenHero, newMonster);
                if (chosenHero.Experience > 100)
                {
                    Console.WriteLine("Now you are one level more, actually level: " + (level+1));
                    NewLevel.LevelUp(chosenHero, newMonster, level);
                }
                goblin.Update();
                brute.Update();
                witch.Update();
                monsters.RemoveAt(counter);
            }
            PrintResult.PrintResultGame(chosenHero);

         }
    }
}
