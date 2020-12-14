using System;
using System.Collections.Generic;
using System.Text;
using DungeonGame.Data.Models;
using DungeonGame.Domain.ModelsServices;

namespace DungeonGame.Domain.Services
{
    public static class NewLevel
    {
        public static void LevelUp(Hero myHero, Monster myMonster, int level)
        {
            if (myHero is Warrior warrior1)
            {
                level++;
                warrior1.LevelUp(myMonster.Experience);
            }
            if (myHero is Mage mage1)
            {
                level++;
                mage1.LevelUp(myMonster.Experience);
            }
            if (myHero is Ranger ranger1)
            {
                level++;
                ranger1.LevelUp(myMonster.Experience);
            }

        }
           
    }
}
