using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonGame
{
    public static class Options
    {
        public static void DisplayOptions(Character characters,Hero myHero, Monster myMonster)
        {
            Console.WriteLine("Choose number in menu for desired action!");
            int number;
            if(myHero is Warrior warrior)
            {
                Console.WriteLine("1. Regular Attack");
                Console.WriteLine("2. Anger Attack");
                string numberString = Console.ReadLine();
                number = ParsingStringToInt(numberString, 1, 2);
                switch(number)
                {
                    case 1:
                        characters.Attack(myHero, myMonster);
                        break;
                    case 2:
                        warrior.AttackingAngrily(warrior, myMonster);
                        break;

                }
            }
            if(myHero is Mage mage)
            {
                if (mage.Mana > 0)
                {
                    Console.WriteLine("1. Regular Attack");
                    Console.WriteLine("2. You can use 50% of your Mana to renew your HP!");
                    string numberString = Console.ReadLine();
                    number = ParsingStringToInt(numberString, 1, 2);
                    switch (number)
                    {
                        case 1:
                            mage.MageAttack(myHero, myMonster);
                            break;
                        case 2:
                            mage.RenewalHealthPointsInExchangedForMana();
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Your Mana was less than 0, so you cannot attack, but don't worry your Mana is back!");
                    mage.Mana = 60;
                }
                if(mage.BeingAlive==false)
                {
                    Console.WriteLine("You died first time, but you have just ressurected!");
                    mage.RessurectMaga();
                }
            }

            if(myHero is Ranger ranger)
            {
                if (ranger.CriticalChance > 100 || ranger.StunChance > 100)
                {
                    if (ranger.CriticalChance > 100)
                    {
                        Console.WriteLine("critical");
                    }
                    if (ranger.StunChance > 100)
                    {
                        Console.WriteLine("stun");
                    }
                }
                else
                {
                    Console.WriteLine("regular attack");
                    characters.Attack(myHero, myMonster);
                }

            }
        }
        public static int ParsingStringToInt(string numberString, int beginningOptions, int endOptions)
        {
            int number;
            bool isInteger = Int32.TryParse(numberString, out number);
            if (isInteger && number >= beginningOptions && number <= endOptions)
            {
                return number;
            }
            else
            {
                Console.WriteLine("Wrong input! Try again!");
                string numberSecondString = Console.ReadLine();
                return ParsingStringToInt(numberSecondString, beginningOptions, endOptions);
            }
        }
        public static int EnterHeroAttack()
        {
            Console.WriteLine("Enter your attack using below numbers: ");
            Console.WriteLine("0. Direct attack");
            Console.WriteLine("1. Attack from the side");
            Console.WriteLine("2. CounterAttack");
            string stringAttack = Console.ReadLine();
            return  ParsingStringToInt(stringAttack,0,2);
        }
        public static int AttackRandomMonster()
        {
            Random randomAttack = new Random();
            return randomAttack.Next(0, 3);
        }

    }
}
