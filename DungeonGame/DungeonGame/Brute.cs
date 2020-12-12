using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonGame
{
    public class Brute:Monster
    {
        public void Update()
        {
            ProbabilityGenerator = 30;
            Name = "Brute";
        }
    }
}
