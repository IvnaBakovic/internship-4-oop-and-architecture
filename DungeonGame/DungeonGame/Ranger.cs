using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonGame
{
    public class Ranger:Hero
    {
        public int CriticalChance { get; set; } = 0;
        public int StunChance { get; set; } = 0;

        public override string ToString()
        {
            return $"{base.ToString()} - {CriticalChance} - {StunChance}";
        }
    }
}
