using System;
/*
 * Program name: Player Choice
 * Author: Jason Weinberg
 * Purpose: Practice methods for giving a player different choices
 * Modifications: 10/12 - Created scene 1. 10/13 - Finished the rest of the code. 10/14 - bug fixes
 */
namespace HW2__Player_Choice
{
    class Program
    {
        static void Main(string[] args)
        {
            String weapon; //Track's the user's current weapon
            String armor; //Tracks the user's armor

            weapon = scene1();
            armor = scene2(weapon);

            scene3(weapon, armor);

        }
        //Tell the user about the first scene and ask them to choose a weapon and store their choice.
        public static String scene1()
        {
            String weapon;
            Console.WriteLine("After a long day at work you finally get home and put your stuff down.");
            Console.WriteLine("After a few seconds, you hear some creaking from your basement.");
            Console.WriteLine("You live alone.");
            Console.WriteLine("What weapon shall you wield? the BASEBALL BAT in your closet, or the SAGE STICK in your room?");
            do {
                weapon = Console.ReadLine().Trim().ToUpper();
                switch (weapon)
                {
                    case "BASEBALL BAT":
                        Console.WriteLine("You grab the BASEBALL BAT and prepare yourself.");
                        return weapon;

                    case "SAGE STICK":
                        Console.WriteLine("You grab the SAGE STICK and a lighter from your room and prepare yourself");
                        return weapon;
                    default:
                        Console.WriteLine("You did not give me a valid option. Please try again.");
                        break;
                } 
            } while (weapon != "BASEBALL BAT" && weapon != "SAGE STICK");
            return weapon;
        }

        //Ask the user what kind of armor they want to wear and give it to them
        public static String scene2(string weapon)
        {
            String armor;
            Console.WriteLine("");
            Console.WriteLine("You decide that you need some armor.");
            Console.WriteLine("Do you put your JACKET back on, or do you put on the replica KNIGHT HELMET in your foyer?");
            if (weapon == "BASEBALL BAT")
            {
                Console.WriteLine("OR, do you put on the CATCHER GEAR that was next to your BASEBALL BAT?");
            }
            else
            {
                Console.WriteLine("OR, do you wrap yourself in the SHEETS in your bedroom, which is in the same room that you found your SAGE STICK?");
            }
            do
            {
                armor = Console.ReadLine().Trim().ToUpper();

                switch (armor)
                {
                    case "KNIGHT HELMET":

                    case "CATCHER GEAR":

                    case "SHEETS":

                    case "JACKET":
                        Console.WriteLine("You put on the {0} and prepare yourself once again", armor);
                        return armor;

                    default:
                        Console.WriteLine("You did not give me a valid answer. Please try again.");
                        break;
                }
            } while (weapon != "JACKET");
            return armor;

        }
        //Tell the user what happens in the third scene and give them the result based on their choices.
        public static void scene3(string weapon, string armor)
        {
            String choice;
            Console.WriteLine("");
            Console.WriteLine("With your {0} and your {1}, you are now ready.", weapon, armor);
            Console.WriteLine("Do you ENTER the basement to see what all the noise is?");
            Console.WriteLine("Or do you RUN away to safety? ");

            do
            {
                choice = Console.ReadLine().ToUpper().Trim();

                switch (choice)
                {
                    case "ENTER":
                        Console.WriteLine("You enter the basement and find a haunting ghost.");

                        if (weapon == "BASEBALL BAT")
                        {
                            Console.WriteLine("You attack it with your BASEBALL BAT, but it has no effect.");
                            Console.WriteLine("Your {0} armor gives you no protection from the ghost's attacks and it kills you.", armor);
                        }
                        else if (armor != "JACKET")
                        {
                            Console.WriteLine("You attack it with your SAGE STICK, and in combination with the indimidation from your {0},", armor);
                            Console.WriteLine("you ward off the ghost!", armor);
                        }
                        else
                        {
                            Console.WriteLine("You attack it with your SAGE STICK, but because you are wearing a JACKET, the ghost is not afraid and kills you.");
                        }
                        break;

                    case "RUN":

                        Console.WriteLine("You try to leave through the front door but it's locked. The basement door opens and an angered ghost emerges!");
                        if (weapon == "BASEBALL BAT")
                        {
                            if (armor == "CATCHER GEAR")
                            {
                                Console.WriteLine("You notice a window that looks smashable by your BASEBALL BAT! But your CATCHER GEAR slows you down as you run for it,");
                                Console.WriteLine("so the ghost catches you and kills you.");

                            }
                            else
                            {
                                Console.WriteLine("You notice a window that looks smashable by your BASEBALL BAT!");
                                Console.WriteLine("You run over and smash it and escape the enraged ghost wearing your {0} armor!", armor);
                            }
                        }
                        else if (armor == "SHEETS")
                        {
                            Console.WriteLine("After using the SAGE STICK to ward off the ghost while wearing SHEETS to look like another ghost,");
                            Console.WriteLine("it loses it's anger and lets you leave.");
                        }
                        else
                        {
                            Console.WriteLine("You try to use the SAGE STICK to ward off the ghost, but your wearing a {0}, so the ghost is too mad to care and kills you.", armor);
                        }
                        break;
                    default:
                        Console.WriteLine("You did not enter a valid input. Please try again.");
                        break;

                }
            } while (choice != "RUN" && choice != "ENTER");

        }
    }
}

