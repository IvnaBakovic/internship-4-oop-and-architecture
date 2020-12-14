using DungeonGame.Data.Models;
using DungeonGame.Domain.ModelsServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonGame.Domain.Services
{
    public class GeneratingMonsters:Monster
    {

        public List<Monster> generatedMonstersList = new List<Monster>();

        public List<Monster> Generate(Goblin goblin, Witch witch, Brute brute, int probabilityGoblinGenerator,
            int probabilityWitchGenerator, int probabilityBruteGenerator)
        {
            Monster pickedMonster;
            for(var i = 0; i < 10; i++)
            {
                pickedMonster = pickingMonster(goblin, witch, brute, probabilityGoblinGenerator,
            probabilityWitchGenerator, probabilityBruteGenerator);
                generatedMonstersList.Add(pickedMonster);
            }
            return generatedMonstersList;

        }
        public Monster pickingMonster(Goblin goblin, Witch witch, Brute brute, int probabilityGoblinGenerator,
            int probabilityWitchGenerator, int probabilityBruteGenerator)
        {
            Random random = new Random();
            int generatedNumber = random.Next(1, 101);
            if (generatedNumber <= probabilityGoblinGenerator)
            {
                return goblin;
            }
            else if (generatedNumber <= probabilityGoblinGenerator + probabilityBruteGenerator)
            {
                return brute;
            }
            else
            {
                return witch;
            }

        }

    }
}
