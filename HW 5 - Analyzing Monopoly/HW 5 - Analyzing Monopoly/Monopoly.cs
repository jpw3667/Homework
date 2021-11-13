using System;
using System.Collections.Generic;
using System.Text;

namespace HW_5___Analyzing_Monopoly
{
    class Monopoly
    {
        private Dice die;
        private string[] spaceNames = new string[40] { "Go", "Mediterranean Avenue", "Community Chest (1)", "Baltic Avenue", "Income Tax", "Reading Railroad", "Oriental Avenue", "Chance (1)", "Vermont Avenue",
            "Connecticut Avenue", "Jail", "St. Charles Place", "Electric Company", "States Avenue", "Virginia Avenue", "Pennsylvania Railroad", "St. James Place", "Community Chest (2)", "Tennesse Avenue", "Ney York Avenue", 
            "Free Parking", "Kentucky Avenue", "Chance (2)", "Indiana Avenue", "Illinois Avenue", "B&O Railroad", "Atlantic Avenue", "Ventnor Avenue", "Water Works", "Marvin Gardens", "Go To Jail", "Pacific Avenue",
            "North Carolina Avenue", "Community Chest (3)", "Pennsylvania Avenue", "Short Line Railroad", "Chance (3)", "Park Place", "Luxury Tax", "Boardwalk"};
        private int players;
        private int timesAroundBoard;

        //Creates a new monopoly board with the number of players and the number of times that each player has to go around to board
        public Monopoly(int Players, int TimesAroundBoard)
        {
            players = Players;
            timesAroundBoard = TimesAroundBoard;
            die = new Dice();
        }

        //Simulates what spaces each player would land on for every turn and stores that value into an array of values for each space. 
        //Calculates what percentage of turns each space is landed on and returns that in an array of doubles
        public double[] Analyze()
        {
            int[] visits = new int[40];
            double totalVisits = 0;
            

            for (int i = 0; i < players; i++)
            {
                int position = 0;
                int timesAround = 0;
                while (timesAround < timesAroundBoard)
                {
                    position += die.RollDice(2);
                    
                    if (position > 39)
                    {
                        position = position - 40;
                        visits[position]++;
                        timesAround++;

                    }
                    else if (position == 30)
                    {
                        position = 10;
                        visits[30]++;
                        timesAround++;
                    }
                    else
                    {
                        visits[position]++;
                    }
                    totalVisits++;

                }
            }

            double[] percentages = new double[40];

            for (int i = 0; i < visits.Length; i++)
            {
                percentages[i] = visits[i] / totalVisits * 100;
            }

            return percentages;


        }

        //Prints the percentage that each space was landed on next to the name of said space
        public void PrintResults(double[] visitPercentages)
        {
            Console.WriteLine("Study results:");
            Console.WriteLine("");

            for (int i = 0; i < spaceNames.Length; i++)
            {
                Console.WriteLine("{0} : {1:F2}", spaceNames[i], visitPercentages[i]);
            }

        }

    }
}
