using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonGame
{
    public class Mage:Hero
    {
        public int Mana { get; set; } = 0;
        public override string ToString()
        {
            return $"{base.ToString()} - {Mana}";
        }
    }
}
