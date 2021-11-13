using System;
using System.Collections.Generic;
using System.Text;

namespace HW_5___Analyzing_Monopoly
{
    class Dice
    {
        private Random rng;

        //Creates a new dice object with a random object initialized
        public Dice()
        {
            rng = new Random();
        }

        //Simulates a die roll and returns a random number between 1 and 6
        public int RollDie()
        {
            return rng.Next(1, 7);
        }

        //Simulates a dice roll the number of times inputted and returns the total
        public int RollDice(int amount)
        {
            int total = 0;
            for (int i = 0; i < amount; i++)
            {
                total += RollDie();
            }
            return total;
        }
    }
}
