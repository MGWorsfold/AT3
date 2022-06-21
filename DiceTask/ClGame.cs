using System;
using System.Collections.Generic;
using System.Linq;

namespace DiceTask
{
    public class ClGame:Game
    {
        public string name {get;set;}
        public List<int> Results = new List<int>();

        public double GetAverage()
        {
            int total = GetTotal();
            double average = total / Results.Count;
            return average;
        }
        public int GetTotal()
        {
            int total = Results.Sum();
            return total;
        }
        public override int RollAllDice()
        {
            foreach(Die i in Dice)
            {
                Results.Add(i.Roll());
            }
            return 1;
        }
    }
}