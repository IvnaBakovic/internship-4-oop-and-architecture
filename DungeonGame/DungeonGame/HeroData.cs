using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonGame
{
    public class HeroData
    {
        public static void Update(Hero hero)
        {
            if(hero is Warrior)
            {
                hero.HealthPoints = 120;
                hero.Damage = 10;
            }
            if(hero is Mage)
            {
                hero.HealthPoints = 65;
                hero.Damage = 40;
            }
            if(hero is Mage)
            {
                hero.HealthPoints = 90;
                hero.Damage = 30;
            }
        }
   
            //if (person is Professional)
            //{
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //}
            //if (person is Student student)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    //pattern matching
            //    switch (student.University)
            //    {
            //        case UniversityType.Kopilica:
            //            Console.ForegroundColor = ConsoleColor.Yellow;
            //            break;
            //        case UniversityType.Ekonomija:
            //            Console.ForegroundColor = ConsoleColor.Yellow;
            //            break;
            //        case UniversityType.Filozofski:
            //            Console.ForegroundColor = ConsoleColor.DarkGreen;
            //            break;
            //        case UniversityType.Pomorski:
            //            Console.ForegroundColor = ConsoleColor.Blue;
            //            break;
            //        case UniversityType.PMF:
            //            Console.ForegroundColor = ConsoleColor.DarkGray;
            //            break;
            //    }
            //}
 



    }
}
