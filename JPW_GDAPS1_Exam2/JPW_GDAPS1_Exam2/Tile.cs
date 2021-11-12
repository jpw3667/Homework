using System;
using System.Collections.Generic;
using System.Text;

namespace JPW_GDAPS1_Exam2
{
    class Tile
    {
        private bool hasEnemy;

        //Creates a tile object and adds the property that tells if it has an enemy.       
        public Tile(bool HasEnemy)
        {
            hasEnemy = HasEnemy;
        }

        //Returns true if this tile has an enemy, false if not.
        public bool HasEnemy
        {
            get { return hasEnemy; }
        }

        //Draws the map with a red tile for each enemy and a white tile for no enemy.
        public void WriteTile()
        {
            if (hasEnemy)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write(" ");
                Console.BackgroundColor = ConsoleColor.White;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(" ");
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
