using System;

namespace HW6___Character_behaviors
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior steve = new Warrior("Steve", 250, 10, 20, 5);
            Archer joe = new Archer("Joe", 175, 7, 6, 7);

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
                    if (joe.isDead() || joe.HasFled())
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
                        if (joe.isDead() || joe.HasFled())
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
        }
    }
}

