using System;
/*
 * Program name:Superman game
 * Author: Jason Weinberg
 * Purpose: To leap tall buildings and practice coding
 * Modifications: 
 */
namespace HW3_JW_Superman
{
    class Program
    {
        //Tells the user what the game is and plays the game then asks them if they want to play again. If not, the program ends. If yes, they get to play again.
        static void Main(string[] args)
        {
            String tryAgain = "Y";

            Console.WriteLine("Your target building height is 660.");
            Console.WriteLine("Please enter the gravitational constant for the planet on which superman");
            Console.WriteLine("is currently attempting this jump. Remember that the units should be in feet/second^2.");

            while(tryAgain == "Y")
            {
                Console.WriteLine("");
                calculateJump();
                Console.WriteLine("");

                Console.WriteLine("Would you like to try another value? Y or N: ");
                tryAgain = Console.ReadLine().Trim().ToUpper().Substring(0);
                while (tryAgain != "Y" && tryAgain != "N")
                {
                    Console.WriteLine("You did not give me Y or N. Please try again: ");
                    tryAgain = Console.ReadLine().Trim().ToUpper().Substring(0);
                }
            }

            Console.WriteLine("Thanks for playing!");
        }

        //Asks the user for a gravitational constant and calculates how much force is required for superman to jump up a 660 feet tall building on a planet with that amount of gravity.
        public static void calculateJump()
        {
            double gravity = -1;
            double jump;
            bool success;

            Console.Write("Gravitational Constant: ");
            success = double.TryParse(Console.ReadLine().Trim(), out gravity);
            while(gravity < 0 || success == false)
            {
                Console.WriteLine("You did not give me a valid number. Please try again: ");
                success = double.TryParse(Console.ReadLine().Trim(), out gravity);
            }

            jump = Math.Sqrt(gravity * 1320.0);

            Console.WriteLine("Superman must jump with an initial velocity of at least {0} feet/second.", jump);
        }
    }
}
