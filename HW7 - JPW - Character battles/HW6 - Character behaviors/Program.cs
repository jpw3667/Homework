using System;
using System.Collections.Generic;
/*
 * Program name: Character behaviors
 * Author: Jason Weinberg
 * Purpose: create a turn based fighting game with 2 different character types 
 * Modifications: 12/1 - Added battle royale feature to include 4 characters fighting
 */
namespace HW6___Character_behaviors
{
    class Program
    {
        //This is my Homework 6 refactored for homework 7
        static void Main(string[] args)
        {
            //Creates 4 characters, adds them to a list, and prints all their information
            List<CommonCharacter> characters = new List<CommonCharacter>();
            Warrior steve = new Warrior("Steve", 250, 10, 20, 5);
            Warrior jim = new Warrior("Jim", 300, 7, 15, 10);
            Archer mary = new Archer("Mary", 150, 8, 10, 8);
            Archer joe = new Archer("Joe", 175, 7, 6, 7);

            characters.Add(steve);
            characters.Add(jim);
            characters.Add(mary);
            characters.Add(joe);

            foreach(CommonCharacter x in characters)
            {
                Console.WriteLine(x.ToString());
                Console.WriteLine("");
            }

            Console.WriteLine("It's time for the fight between {0}, {1}, {2}, and {3}!", steve.Name, joe.Name, jim.Name, mary.Name);
            Random order = new Random();
            bool gameOver = false;
            int damageDone;
            int gotHit;
            int round = 1;

            while (!gameOver)
            {
                Console.WriteLine("");
                Console.WriteLine("Round " + round);
                Console.WriteLine("");

                //Has every character do an attack on a random other character and print the results.
                for (int i = 0; i < characters.Count; i++)
                {
                    gotHit = order.Next(0, characters.Count);
                    while(gotHit == i)
                    {
                        gotHit = order.Next(0, characters.Count);
                    }
                    damageDone = characters[i].attack();
                    if (characters[gotHit].takeDamage(damageDone))
                    {
                        Console.WriteLine("{0} hit {1} for {2} damage.", characters[i].Name, characters[gotHit].Name, damageDone);
                    }
                    else
                    {
                        Console.WriteLine("{0} has dodged the attack from {1}!", characters[gotHit].Name, characters[i].Name);
                    }
                    
                   System.Threading.Thread.Sleep(500);
                }

                //Print all the health values of all the characters
                Console.WriteLine("");
                foreach (CommonCharacter c in characters)
                {
                    if(c.Health < 0)
                    {
                        c.Health = 0;
                    }
                    Console.WriteLine("{0} has {1} health left.", c.Name, c.Health);
                    System.Threading.Thread.Sleep(500);
                }

                //Checks if each character is dead and removes them from the list of characters if they are
                for (int j = 0; j < characters.Count; j++)
                {
                    if (characters[j].isDead())
                    {
                        Console.WriteLine("");
                        Console.WriteLine(characters[j].Name + " has died.");
                        characters.Remove(characters[j]);
                        j = 0;
                        System.Threading.Thread.Sleep(500);
                    }
                    else if (characters[j].hasFled())
                    {
                        Console.WriteLine("");
                        Console.WriteLine(characters[j].Name + " has fled.");
                        characters.Remove(characters[j]);
                        j = 0;
                        System.Threading.Thread.Sleep(500);
                    }
                }

                if(characters[0].isDead())
                {
                    Console.WriteLine("");
                    Console.WriteLine(characters[0].Name + " has died.");
                    characters.Remove(characters[0]);
                    System.Threading.Thread.Sleep(500);
                }

                if(characters.Count < 2)
                {
                    gameOver = true;
                }
                round++;
            }

            Console.WriteLine("");

            //If there is a winner then prints their name
            if (characters.Count == 1)
            {
                Console.WriteLine("{0} is the winner!", characters[0].Name);
            }
            else
            {
                Console.WriteLine("Everyone has died, so there is no winner.");
            }

            /*
             * HW 6 CODE HERE
            Console.WriteLine("Today the warrior " + steve.Name + " and the archer " + joe.Name + " will be fighting to the death!");

            Console.WriteLine(steve.ToString());
            Console.WriteLine(joe.ToString());
            int turn = 1;
            bool gameEnd = false;
            int currentAttack;

            //Loops for each turn
            while (!gameEnd)
            {
                Console.WriteLine("");
                Console.WriteLine("Round " + turn + " ---------------------");
                //Checks who has the higher speed and makes them attack first
                if (steve.Speed > joe.Speed)
                {
                    currentAttack = steve.attack();
                    Console.WriteLine(steve.Name + " has attacked " + joe.Name + " for " + currentAttack + " damage.");
                    joe.takeDamage(currentAttack);

                    //If the character who just got attacked died then end the game
                    if (joe.isDead() || joe.hasFled())
                    {
                        gameEnd = true;
                        Console.WriteLine(joe.Name + " has been slain by " + steve.Name);
                    }
                    //If not, then they get to attack
                    else
                    {
                        currentAttack = joe.attack();
                        Console.WriteLine(joe.Name + " has done " + (currentAttack - steve.Armor)  + " damage to " + steve.Name);
                        steve.takeDamage(currentAttack);
                        if (steve.isDead())
                        {
                            gameEnd = true;
                            Console.WriteLine(steve.Name + " has been slain by " + joe.Name);
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine(steve.Name + " has " + steve.Health + " health left.");
                            Console.WriteLine(joe.Name + " has " + joe.Health + " health left.");

                        }
                    }
                }
                //If joe is faster then steve then he gets to attack first
                else
                {
                    currentAttack = joe.attack();
                    Console.WriteLine(joe.Name + " has done " + (currentAttack - steve.Armor) + " damage to " + steve.Name);
                    steve.takeDamage(currentAttack);
                    //If the character who just got attacked died then end the game
                    if (steve.isDead())
                    {
                        gameEnd = true;
                        Console.WriteLine(joe.Name + " has been slain by " + steve.Name);
                    }
                    //If not then the other player gets to attack
                    else
                    {
                        currentAttack = steve.attack();
                        Console.WriteLine(steve.Name + " has attacked " + joe.Name + " for " + currentAttack + " damage.");
                        joe.takeDamage(currentAttack);
                        if (joe.isDead() || joe.hasFled())
                        {
                            gameEnd = true;
                            Console.WriteLine(steve.Name + " has been slain by " + joe.Name);
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine(steve.Name + " has " + steve.Health + " health left.");
                            Console.WriteLine(joe.Name + " has " + joe.Health + " health left.");

                        }
                    }


                }
                turn++;
            }
            */
        }
    }
}

