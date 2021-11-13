using System;

namespace HW_5___Analyzing_Monopoly
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice die1 = new Dice();
            double currentRoll;
            double total = 0;
            double average = 0;

            //Tests 100 dice rolls with the RollDie() method and prints the average
            for (int i = 0; i < 100; i++)
            {
                currentRoll = die1.RollDie();
                Console.Write(currentRoll + " ");
                total += currentRoll;
            }

            Console.WriteLine("");

            average = total / 100;
            Console.WriteLine("Average roll for a single die: {0}.", average);
            total = 0;

            //Tests 100 dice rolls with the RollDice() method and prints the average
            for (int i = 0; i < 100; i++)
            {
                currentRoll = die1.RollDice(1);
                Console.Write(currentRoll + " ");
                total += currentRoll;
            }
            average = total / 100;
            Console.WriteLine("");
            Console.WriteLine("Average roll for a single die: {0}.", average);

            //simulates 100,000 players going around the board 25 times each, analyzes the results, and prints them.
            Monopoly game1 = new Monopoly(100000, 25);
            double[] percentages = new double[40];
            percentages = game1.Analyze();
            game1.PrintResults(percentages);
        }
    }
}
