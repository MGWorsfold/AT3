using System;
using System.Collections.Generic;

namespace DiceTask
{
    public abstract class Game
    {
        public static List<Die> Dice = new List<Die>();

        public abstract int RollAllDice();
        public static void AddDie(int sides)
        {
            Dice.Add(new Die(sides));
        }
    }
}