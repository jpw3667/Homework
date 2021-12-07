using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
/*
 * Program name: Ship data class
 * Author: Jason Weinberg
 * Purpose: Read in all the data from the shipstats.csv file 
 * Modifications: 12/4-created shipData class and all its methods
 */
namespace HW8_BattleDamage
{
    class ShipData
    {

        private String[,] shipStats;

        public ShipData()
        {
        }

        //Loads all of the data from the shipstats.csv file in the folder of the project.
        public void LoadData() {
            try
            {
                StreamReader reader = new StreamReader("C:/Users/jbetb/OneDrive/Email attachments/Documents/school/HW8_BattleDamage/shipstats.csv");

                try
                {
                    string line = "";
                    int numShips = 0;

                    if (reader != null)
                    {
                        line = reader.ReadLine();
                        try
                        {
                            numShips = Int32.Parse(line);
                        }
                        //This returns an error if the first value of the file is not an integer.
                        catch (Exception e)
                        {
                            Console.WriteLine("ERROR: Data incorrectly sorted in file.");
                            Environment.Exit(0);
                        }
                        //Reads all the data of the file and adds it into a 2D array of strings.
                        shipStats = new string[numShips, 6];
                        line = reader.ReadLine();

                        int count = 0;
                        string[] stats = new string[6];
                            do
                            {
                                line = reader.ReadLine();
                                if (line != null)
                                {

                                
                                stats = line.Split(",");
                                

                                for (int i = 0; i < stats.Length; i++)
                                {
                                    shipStats[count, i] = stats[i];
                                }
                                count++;
                            }

                            } while (line != null);

                            Console.WriteLine("");
                            Console.WriteLine(numShips + " rows read.");

                    }

                    //Close the file
                        try
                        {
                            reader.Close();
                        }
                        catch (Exception e)
                    {
                            Console.WriteLine("ERROR: file could not be closed.");
                        Environment.Exit(0);
                    }
                    

                }
                catch (Exception e)
                {
                    Console.WriteLine("ERROR: Data not found");
                    Environment.Exit(0);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: FILE NOT FOUND");
                Environment.Exit(0);
            }
        }
    
        //Returns all the data of the ship at the row that was inputted in an array
        public String[] GetShipData(int row)
        {
            try
            {
                String[] ship = new string[shipStats.GetLength(0)];
                for (int i = 0; i < shipStats.GetLength(0) - 2; i++)
                {
                    ship[i] = shipStats[row, i];
                }
                return ship;
            }
            catch
            {
                Console.WriteLine("ERROR: Invalid ship data");
                return null;
            }
        }

        //Returns the number of ships in the file
        public int Count
        {
            get { return shipStats.GetLength(0); }
        }

        //Prints out all of the ships that were 
        public override string ToString()
        {
            string ship = "Faction name \t Ship Name \tWeapon  Agility Hull \tShields \n";

            for(int i = 0; i < shipStats.GetLength(0); i++)
            {
                for(int j = 0; j < shipStats.GetLength(1); j++)
                {
                    ship += (shipStats[i, j] + "\t");
                }
                ship += "\n";
            }
            return ship;
        }
    }
}
