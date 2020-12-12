using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonGame
{
    public class Goblin:Monster
    {
        public void Update()
        {
            ProbabilityGenerator = 50;
            Name = "goblin";
        }
    }
}
