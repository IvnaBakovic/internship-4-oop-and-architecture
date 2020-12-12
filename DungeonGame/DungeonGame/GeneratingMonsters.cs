using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonGame
{
    public class GeneratingMonsters:Monster
    {
        //public GeneratingMonsters()
        //{
        //    DataStore.GetMonsters = Generate(goblin, witch,brute,probabilityGoblinGenerator,probabilityWitchGenerator,probabilityBruteGenerator);
        //}
        public List<Monster> Generate(Goblin goblin, Witch witch, Brute brute, int probabilityGoblinGenerator,
            int probabilityWitchGenerator, int probabilityBruteGenerator)
        {
            int generatedNumber;
            List<Monster> generatedMonstersList = new List<Monster>();
            for(var i = 0; i < 10; i++)
            {
                Random random = new Random();
                generatedNumber = random.Next(1,101);
                if (generatedNumber <= probabilityGoblinGenerator)
                {
                    generatedMonstersList.Add(goblin);
                }
                else if(generatedNumber <= probabilityGoblinGenerator + probabilityBruteGenerator)
                {
                    generatedMonstersList.Add(brute);
                }
                else
                {
                    generatedMonstersList.Add(witch);
                }
            }
            return generatedMonstersList;

        }

    }
}
