using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonGame
{
    public class Witch:Monster
    {
        public void Update()
        {
            ProbabilityGenerator = 20;
            Name = "witch";
        }
    }
}
