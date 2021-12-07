using System;
using System.IO;
using System.Collections.Generic;

/*
 * Program name: hw8 -  Battle Damage
 * Author: Jason Weinberg
 * Purpose: Create a game to make ships fight
 * Modifications: 12/4-created shipData class and all its methods
 */
/// <summary>
/// Empty starter project with the shipstats.csv data file for HW 8
/// As configured, the relative path for shipstats.csv in this project is
///         "../../../shipstats.csv"
/// https://docs.google.com/document/d/1PZlqdP3MJlPMuIFZiztK-_R0iUy654XPnbFu85Xcuvo/edit?usp=sharing
/// </summary>
namespace HW8_BattleDamage
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Test code to test the methods of ShipData
            Console.WriteLine(ships.ToString());

            Random rng = new Random();
            List<ship> oneOfEach = new List<ship>();
            oneOfEach.Add(new ship(ships.GetShipData(0), rng));
            oneOfEach.Add(new ship(ships.GetShipData(2), rng));
            oneOfEach.Add(new ship(ships.GetShipData(4), rng));
            oneOfEach.Add(new ship(ships.GetShipData(6), rng));
            oneOfEach.Add(new ship(ships.GetShipData(7), rng));

            foreach(ship s in oneOfEach)
            {
                Console.WriteLine(s.ToString());
            }

            Console.WriteLine(oneOfEach[1].getAttackValue("short"));
            Console.WriteLine(oneOfEach[0].getDefenceValue("medium"));
            */

            //All the variables for two ships to fight

            ShipData ships = new ShipData();
            ships.LoadData();
            Random rng = new Random();
            int numShips = ships.Count;
            int turn = 1;
            bool gameOver = false;
            int damageDone = 0;
            int damageDodged = 0;
            string range;

            //Create two new objects that are random ships from the inputted file
            ship ship1 = new ship(ships.GetShipData(rng.Next(1, numShips)), rng);
            ship ship2 = new ship(ships.GetShipData(rng.Next(1, numShips)), rng);

            Console.WriteLine("Welcome to the battle between these two ships!");
            Console.WriteLine(ship1.ToString());
            Console.WriteLine(ship2.ToString());

            //Loop that makes both ships attack eachother until one or both of them dies. It then prints the winner, or that it's tie.
            while (!gameOver)
            {
                if (turn < 3)
                {
                    range = "long";
                }
                else if (turn < 5 && turn > 2)
                {
                    range = "medium";
                }
                else
                {
                    range = "long";
                }

                Console.WriteLine("Turn " + turn);
                Console.WriteLine("");

                Console.WriteLine("{0} will now attack {1}.\n\t", ship1.Name, ship2.Name);

                Console.Write("\t");
                damageDone = ship1.getAttackValue(range);
                Console.WriteLine("");
                Console.Write("\t");
                damageDodged = ship2.getDefenceValue(range);
                Console.WriteLine("");

                Console.WriteLine("\t{0} dodged {1} of {2}'s {3} damage", ship2.Name, damageDodged, ship1.Name, damageDone);
                damageDone = damageDone - damageDodged;
                if (damageDone < 0)
                {
                    damageDone = 0;
                }

                ship2.takeDamage(damageDone);

                Console.WriteLine("\tTotal Damage Done: " + damageDone + "\n");

                Console.WriteLine("{0} will now attack {1}.\n", ship2.Name, ship1.Name);

                Console.Write("\t");
                damageDone = ship2.getAttackValue(range);
                Console.WriteLine("");
                Console.Write("\t");
                damageDodged = ship2.getDefenceValue(range);
                Console.WriteLine("");

                Console.WriteLine("\t{0} dodged {1} of {2}'s {3} damage", ship1.Name, damageDodged, ship2.Name, damageDone);
                damageDone = damageDone - damageDodged;
                if (damageDone < 0)
                {
                    damageDone = 0;
                }

                ship1.takeDamage(damageDone);

                Console.WriteLine("\tTotal Damage Done: " + damageDone + "\n");

                if (ship2.isDestroyed())
                {
                    Console.WriteLine(ship1.Name + " is the winner!");
                    gameOver = true;
                }
                else if (ship1.isDestroyed())
                {
                    Console.WriteLine(ship2.Name + " is the winner!");
                    gameOver = true;
                }
                else if (ship1.isDestroyed() && ship2.isDestroyed())
                {
                    Console.WriteLine("It's a tie!");
                    gameOver = true;
                }

                turn++;

            }
        }
    }
}
