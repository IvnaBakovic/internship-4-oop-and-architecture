using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonGame.Domain.Helpers
{
    public class FightingArena
    {
        public int Attack(int choiceAttackHero, int randomChoiceAttackMonster)
        {

            if(choiceAttackHero==0 && randomChoiceAttackMonster==1)
            {
                return 0;
            }
            else if(choiceAttackHero == 1 && randomChoiceAttackMonster == 0)
            {
                return 1;
            }
            else if (choiceAttackHero == 0 && randomChoiceAttackMonster == 2)
            {
                return 1;
            }
            else if (choiceAttackHero == 2 && randomChoiceAttackMonster == 0)
            {
                return 0;
            }
            else if (choiceAttackHero == 1 && randomChoiceAttackMonster == 2)
            {
                return 0;
            }
            else if (choiceAttackHero == 2 && randomChoiceAttackMonster == 1)
            {
                return 1;
            }
            return 2;
        }
    }
}
