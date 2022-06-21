using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace DiceTask
{
    public class Die
    {
        public static int Sides {get;set;}
        public Die(int pSides)
        {
            Sides = pSides;
        }
        public Die()
        {
            Sides = 6;
        }
        public int Roll()
        {
            Random rnd = new Random();
            int diceRolls = rnd.Next(1, Sides + 1);
            return diceRolls;
        }
    }
}