using System;
/*
 * Program name:  
 * Author: Jason Weinberg
 * Purpose: play a golf game and practice coding
 * Modifications: 10/25: finished the 10 attempt loop and asking the user for inputs. 10/29: finished the rest of the project.
 */

namespace HW3_JW_Golf
{
    class Program
    {
        //Give the user 10 turns to hit the target. If they succeed then the program ends. If not, then they are prompted to try again and get another 10 turns. If they say no, then the program ends.
        static void Main(string[] args)
        {
            int attempt = 1;

            Console.WriteLine("Welcome to Artillery Golf!");
            Console.WriteLine("Your goal is to hit a target 751 meters away.");


            while (attempt <= 10)
            {
                Console.WriteLine("");


                Console.WriteLine("Attempt {0} --------------------------------------------", attempt);
                if (shootCannon())
                {
                    Console.WriteLine();
                    Console.Write("Thanks for playing!");
                    Environment.Exit(0);
                }
                attempt++;

            }

            Console.WriteLine("");
            Console.WriteLine("You ran out of attempts, but thanks for playing!");
        }

        //Ask the user for the starting velocity and angle, then determine if they hit the target or not.
        public static Boolean shootCannon()
        {
            double angle = -1;
            double angleRadians;
            double velocity = -1;
            double flightTime;
            double distance;
            bool success = false;



            //Ask user for starting veloctiy
            Console.Write("Please input the cannonball's initial velocity as a positive number in meters per second: ");
            success = double.TryParse(Console.ReadLine(), out velocity);
            while (velocity <= 0)
            {
                Console.Write("You did not give me a valid velocity. Please try again: ");
                success = double.TryParse(Console.ReadLine(), out velocity);
            }

            //Ask user for starting angle
            Console.Write("Please input the cannon's starting angle between 0 and 90: ");
            success = double.TryParse(Console.ReadLine(), out angle);
            while (angle <= 0 || angle >= 90)
            {
                Console.Write("You did not give me a valid angle. Please try again: ");
                success = double.TryParse(Console.ReadLine(), out angle);
            }

            //Convert from degrees to radians.
            angleRadians = Math.PI * angle / 180;

            //Calculate flight time and total distance.
            flightTime = (velocity * Math.Sin(angleRadians) + Math.Pow((Math.Pow(velocity, 2) * Math.Pow(Math.Sin(angleRadians), 2) + 40.0 * Math.Sin(angleRadians)), 0.5)) / 10.0;

            distance = velocity * Math.Cos(angleRadians) * flightTime;

            Console.WriteLine("");
            Console.WriteLine("A cannonball fired with an initial velocity of {0} m/s, at an angle", velocity);
            Console.WriteLine("of {0} degrees from the ground will strke the ground ", angle);
            Console.WriteLine("{0} meters away.", distance);

            if (distance >= 750.5 && distance <= 751.5)
            {
                if (distance >= 751)
                    Console.WriteLine("You are {0} meters away from the target. A successful hit!", distance - 751);
                else
                {
                    Console.WriteLine("You are {0} meters away from the target. A successful hit!", 751 - distance);
                }
                return true;
            }

            if (distance >= 751)
                Console.WriteLine("You are {0} meters away from the target. Try again!", distance - 751);
            else
            {
                Console.WriteLine("You are {0} meters away from the target. Try again!", 751 - distance);
            }
            return false;
        }

    }
}


