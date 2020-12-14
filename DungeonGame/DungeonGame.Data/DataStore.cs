using DungeonGame.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonGame.Data
{
    public static class DataStore
    {
        public static List<Hero> Heros { get; } = new List<Hero>();
        public static List<Monster> Monsters { get; } = new List<Monster>();
    }
}
