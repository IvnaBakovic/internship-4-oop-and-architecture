using System;
using System.Collections.Generic;
using System.Text;
using DungeonGame.Data.Models;

namespace DungeonGame.Domain.Helpers
{
    public static class PrintResult
    {
        public static void PrintResultGame(Hero myHero)
        {
            if(myHero.BeingAlive)
                Console.WriteLine("You won!");
            else
                Console.WriteLine("You lost!");
        }
    }
}
