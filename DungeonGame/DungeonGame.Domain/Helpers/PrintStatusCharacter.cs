using DungeonGame.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonGame.Domain.Helpers
{
    public static class PrintStatusCharacter
    {
        public static void PrintStatus(Hero myHero, Monster myMonster)
        {

            Console.WriteLine("\n" + myHero.ToString());
            Console.WriteLine(myMonster.ToString() + "\n");
        }
    }
}
