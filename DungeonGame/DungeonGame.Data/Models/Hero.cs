using System;
using System.Collections.Generic;
using System.Text;
namespace DungeonGame.Data.Models
{
    public class Hero:Character
    {
        public Hero()
        {
            DataStore.Heros.Add(this);
        }

        public bool BeingAlive { get; set; } = true;

        public void isHeroAlive(int healthPoints)
        {
            if (healthPoints <= 0)
                BeingAlive = false;
        }
        public override string ToString()
        {
            return $"Hero: {base.ToString()}";
         
        }
    }
}
