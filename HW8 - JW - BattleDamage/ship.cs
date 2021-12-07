using System;
using System.Collections.Generic;
using System.Text;
/*
 * Program name: ship class
 * Author: Jason Weinberg
 * Purpose: Create a ship object with all its data
 * Modifications: 12/4-created shipData class and all its methods
 */
namespace HW8_BattleDamage
{
    class ship
    {
        private string faction;
        private string name;
        private int mainWeapon;
        private int agility;
        private int hull;
        private int shields;
        private Random randomNum = new Random();

        //Creates a new ship with its faction, name, number of main weapons, agility, hull health, and shields using an inputted array of values. It also creates a new random object using the inputted random.
        public ship(string[] data, Random rng)
        {
            Random randomNum = rng;
            faction = data[0];
            name = data[1];
            int.TryParse(data[2], out mainWeapon);
            int.TryParse(data[3], out agility);
            int.TryParse(data[4], out hull);
            int.TryParse(data[5], out shields);
        }

        //Returns the name of the ship
        public string Name

            {
            get {return name;}
            }

        //Returns all of the information of the ship into a formatted string.
        public override string ToString()
        {
            return "Faction " + faction + ". Name: " + name + ". Main weapons: " + mainWeapon + ". Agility: " + agility + ". Hull: " + hull + " . Shields " + shields + ".";
        }

        //Returns the amount of attacks that the ship hit, using the number of main weapons and random 8-sided dice rolls
        public int getAttackValue(string range)
        {
            int attacks = mainWeapon;
            int damage = 0;
            int currentAttack = 0;
            if(range == "short")
            {
                attacks++;
            }
            for(int i = 0; i < attacks; i++)
            {
                currentAttack = randomNum.Next(1, 9);
                if(currentAttack == 1)
                {
                    Console.Write("Critical hit! ");
                    damage += 2;
                }
                else if (currentAttack >  1 && currentAttack < 5)
                {
                    Console.Write("Regular hit. ");
                    damage += 1;
                }
                else
                {
                    Console.Write("Miss. ");
                }
            }
            return damage;
        }
        
        //Returns the number of attacks that the ship evaded using its agility and 8-sided dice rolls
        public int getDefenceValue(string range)
        {
            int defences = agility;
            int roll = 0;
            int avoided = 0 ;
            if(range == "long")
                {
                defences++;
            }
            for(int i = 0; i < defences; i++)
            {
                roll = randomNum.Next(1, 9);
                if(roll < 4)
                {
                    Console.Write("No effect! ");
                    
                }
                else
                {
                    Console.Write("Dodge! ");
                    avoided++;
                }
            }
            return avoided;
        }

        //Calculates how much damage the ship takes by damaging its shields before it damages the hull.
        public void takeDamage(int damage)
        {
            if(shields > damage)
            {
                shields -= damage;
            }
            else
            {
                hull -= (damage - shields);
                shields = 0;
            }
        }

        //Returns true if thge ship has 0 or less shields and hull. Returns false if not.
        public bool isDestroyed()
        {
            if (shields <= 0 && hull <= 0)
            {
                return true;
            }
            return false;
        }
    }
}
