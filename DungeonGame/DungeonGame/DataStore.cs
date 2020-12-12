using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonGame
{
    public static class DataStore
    {
        public static List<Hero> Heros { get; } = new List<Hero>();
        public static List<Monster> Monsters { get; } = new List<Monster>();
        //public static List<Monster> GetMonsters { get; set; } = new List<Monster>(); 
    }
}
