using DungeonGame.Data.Models;
using DungeonGame.Domain.ModelsServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonGame.Domain.Helpers
{
    public static class ChoosingHero
    {
        public static Hero chooseHero(Warrior warrior, Mage mage, Ranger ranger)
        {
            Console.WriteLine("Choose your hero by number input: ");
            Console.WriteLine("1. Warrior");
            Console.WriteLine("2. Mage");
            Console.WriteLine("3. Ranger");
            string numberString = Console.ReadLine();
            int numberHero = Options.ParsingStringToInt(numberString, 1, 3);
            switch(numberHero)
            {
                case 1:
                    return warrior;
                case 2:
                    return mage;
                case 3:
                    return ranger;
            }
            return warrior;
        }
    }
}
