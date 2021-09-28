using System;
/* MadLibs homework 1
 * by Jason Weinberg
 * 9/8/21
 * Create a fun game for IGME 105 class
 * 9/18-finished activity 1.
 * 9/20-wrote the story and prompted the user for all the variables.
 * 9/27-print the story with all the user-inputted variables.
 */

namespace HW1___Mad_Libs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize player information variables and the constant.
            string playerFirstName;
            string playerLastName;
            String nickname;
            double age;
            const int AvgOrbitalSpeedMPH = 66616;

            //Get player's first name, last name, age, and store them all.
            Console.WriteLine("Please enter your information to play.\n");
            Console.Write("What is yout first name? ");
            playerFirstName = Console.ReadLine();
            Console.Write("What is your last name? ");
            playerLastName = Console.ReadLine();
            Console.Write("How old are you? (decimals are allowed) ");
            age = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            //Form player's nickname.

            nickname = playerFirstName.Substring(0, 3) + playerLastName.Substring(playerLastName.Length - 3, 3);

            //Print welcome message.

            Console.WriteLine("Hello " + playerFirstName + " " + playerLastName + "! I think I shall call you " + nickname + ".\n");

            //Print some interesting facts about the user and their name.

            Console.WriteLine("Here are some interesting facts about your name!");
            Console.WriteLine("     Your first name is " + (playerFirstName.Length - playerLastName.Length) + " letter(s) longer than your last name.");
            Console.WriteLine("     In your " + age + " trips around the sun, you have traveled " + (age * 8766 * AvgOrbitalSpeedMPH) + " miles!");


            /*The story
             * Once upon a time there was a (animal) named (name). (name) was a quiet (animal), and never left his (room of house). (name) loved to (action phrase) whenever they were feeling excited, but could
             * only do this (whole number) times per week. This has gone on for (decimal number of years), which is (calculate this into months) months. Today, (name)'s owner (owner name) decided to get another
             * (animal) named (name2)! This new (animal) came with (whole number 2) toys and is only 2 years old. This is about (calculated number) toys per year! That's way too many for such a young (animal)! (name) was
             * so mad that they smashed (whole number 3) of (name2)'s toys! How outrageous! (owner's name) put (name) in timeout for (5x whole number 3) minutes, which is 5 minutes per toy destroyed.
             * I sure hope that (name) never "gets angry" again!
             */

            //Initialize variables for the story.
            String animal;
            String petName;
            String room;
            String ownerName;
            String action;
            String pet2Name;
            int timesPerWeek;
            int toysNumber;
            int toysSmashed;
            double years;



            //Tell user to input story details, request them and store them into variables.
            Console.WriteLine(" ");
            Console.WriteLine("I would like you to help me write a story. Please give me the details that I request. \n");

            Console.Write("     Enter an animal: ");
            animal = Console.ReadLine().ToUpper();
            Console.Write("     Enter an name for a pet: ");
            petName = Console.ReadLine().ToUpper();
            Console.Write("     Enter a room of a house: ");
            room = Console.ReadLine().ToUpper();
            Console.Write("     Enter a name for a person: ");
            ownerName = Console.ReadLine().ToUpper();
            Console.Write("     Enter an action phrase: ");
            action = Console.ReadLine().ToUpper();
            Console.Write("     Enter a name for another pet: ");
            pet2Name = Console.ReadLine().ToUpper();
            Console.Write("     Enter a whole number 1-50: ");
            timesPerWeek = int.Parse(Console.ReadLine());
            Console.Write("     Enter an even whole number 2-50: ");
            toysNumber = int.Parse(Console.ReadLine());
            Console.Write("     Enter a whole number 1-" + toysNumber + ": ");
            toysSmashed = int.Parse(Console.ReadLine());
            Console.Write("     Enter a decimal number 1-5: ");
            years = double.Parse(Console.ReadLine());

            //Print the story with the user-inputted variables as details.
            Console.WriteLine(" ");
            Console.WriteLine("Once upon a time there was a(n) " + animal + " named " + petName);
            Console.WriteLine(petName + " was a quiet " + animal + ", and never left their " + room + ".");
            Console.WriteLine(petName + " loved to " + action + " whenever they were feeling excited, but could only do this " + timesPerWeek + " times per week.");
            Console.WriteLine("This has gone on for " + years + " years, which is " + Math.Round(years * 12.0, 3) + " months.");
            Console.WriteLine("Today, " + petName + "'s owner " + ownerName + " decided to get another " + animal + " named " + pet2Name + "!");
            Console.WriteLine("This new " + animal + " came with " + toysNumber + " toys and is only 2 years old. This is about " + toysNumber / 2 + " toys per year!");
            Console.WriteLine("That is way too much for such a young " + animal);
            Console.WriteLine(petName + " was so mad that they smashed " + toysSmashed + " of " + pet2Name + "'s toys!");
            Console.WriteLine("How outrageous!");
            Console.WriteLine(ownerName + " put " + petName + " in timeout for " + toysSmashed * 5 + " minutes, which is 5 minutes per toy destroyed.");
            Console.WriteLine("I sure hope that " + petName + " never \"gets angry\" again!");

        }
    }
}
