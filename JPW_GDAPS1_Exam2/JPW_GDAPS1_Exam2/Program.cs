using System;

namespace JPW_GDAPS1_Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            bool isDouble = false;
            double density = -1;

            //Gets user inputted enemy density and gives and error message and asks again if the input is invalid.
            while (!isDouble)
            {
                Console.Write("Please input the target density of enemies (0.0 - 1.0): ");
                isDouble = double.TryParse(Console.ReadLine().Trim(), out density);

                if (!isDouble || density < 0.0 || density > 1.0)
                {
                    Console.WriteLine("Invalid value. Please try again. ");
                    isDouble = false;
                }
            }

            Console.WriteLine("");

            //Creates a new map with the inputted density, calculates the true enemy ddensity and displays the map.
            EnemyMap map1 = new EnemyMap(density);
            Console.WriteLine("The generated map has an actual enemy density of {0}.", Math.Round(map1.EnemyDensity,3));
            map1.Display();


            
        }
    }
}
