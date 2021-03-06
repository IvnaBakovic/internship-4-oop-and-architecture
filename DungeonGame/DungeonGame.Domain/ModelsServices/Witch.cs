﻿using DungeonGame.Data.Models;
using DungeonGame.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonGame.Domain.ModelsServices
{
    public class Witch:Monster
    {
        public void Update()
        {
            BeingAlive = true;
            HealthPoints = 50;
            Damage = 15;
            Experience = 60;
            ProbabilityGenerator = 10;
            Name = "Witch";
        }
        public void CreatingNewMonsters (GeneratingMonsters generatingMonsters, Goblin goblin, Witch witch, Brute brute, int probabilityGoblinGenerator,
            int probabilityWitchGenerator, int probabilityBruteGenerator)
        {
            if(!this.BeingAlive)
            {
                for (int i = 0; i < 2; i++)
                {
                    Monster pickedMonster = generatingMonsters.pickingMonster(goblin, witch, brute, probabilityGoblinGenerator,
                probabilityWitchGenerator, probabilityBruteGenerator);
                    generatingMonsters.generatedMonstersList.Add(pickedMonster);
                }
            }
        }
        public void JumbusAttack(Goblin goblin, Witch witch, Brute brute, Hero myHero)
        {
            //I don't know :(

        }
    }
}
