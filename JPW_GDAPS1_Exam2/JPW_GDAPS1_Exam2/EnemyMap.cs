using System;
using System.Collections.Generic;
using System.Text;

namespace JPW_GDAPS1_Exam2
{
    class EnemyMap
    {
        private Tile[,] map;

        //Creates a new map with the target density as the average density of enimies.
        public EnemyMap(double targetDensity)
        {
            map = new Tile[10,75];
            Random rng = new Random();
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    bool hasEnemy = rng.NextDouble() < targetDensity;
                    map[i,j] = new Tile(hasEnemy);
                }
            }
        }

        //Calculates the actual enemy density be dividing the total number of enemies by the total number of tiles on the map.
        public double EnemyDensity
        {
            get
            {
                double totalEnemies = 0;
                foreach(Tile t in map)
                {
                    if (t.HasEnemy)
                    {
                        totalEnemies++;
                    }
                }
                return (totalEnemies / map.Length);
            }
        }

        //Displays every location on the map using the WriteTile method from the Tile class
        public void Display()
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j].WriteTile();
                }
                Console.WriteLine("");
            }
            
        }
    }
}
