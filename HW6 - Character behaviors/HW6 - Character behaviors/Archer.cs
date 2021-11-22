using System;
using System.Collections.Generic;
using System.Text;

namespace HW6___Character_behaviors
{
    class Archer : CommonCharacter
    {
        private int range;
        private double dodge;

        //Creates an archer object with the default stats from the common character class and adds range and dodge.
        public Archer(string Name, int Health, int Strength, int Speed, int Range) : base(Name, Health, Strength, Speed)
        {
            name = Name;
            health = Health;
            strength = Strength;
            speed = Speed;
            range = Range;
            rng = new Random();

            //The dodge chance of an archer should be a ratio based on their range. An archer close to their opponent would focus on avoiding attacks because they have no defense.
            //An archer that is far away from their target wouldn't need to focus on dodging because they can't be attacked in the first place.
            dodge = Math.Round(100.0 / Convert.ToDouble(Range),1);

            if (dodge <= 0)
            {
                dodge = 0;
            }
            else if (dodge >= 50)
            {
                dodge = 50;
            }
        }

        //Returns the range of the character
        public int Range
        {
            get { return range; }
        }

        //Returns the dodge of the character
        public double Dodge
        {
            get { return dodge; }
        }

        //Returns how much damage the current attack will do using strength, range, and a random number
        public int attack()
        {
            return rng.Next(1, 10) + strength * range;
        }

        //Changes the character's health based on how much damage they take and their dodge percentage
        public void takeDamage(int damage)
        {

            if (rng.Next(0,100) >= dodge)
            {
                health -= damage;
            }
            else
            {
                Console.WriteLine(name + " has dodged the attack!");
            }
        }

        //Checks if the character is dead and returns true if they are.
        public bool isDead()
        {
            if(health<= 0)
            {
                return true;
            }
            return false;
        }

        //This determines if the archer has fled or not. An archer would usually never flee, but if they are at 1 health, then they will flee because they want to live.
        public bool HasFled()
        {
            if (health == 1)
            {
                return true;
            }
            return false;
        }

        //Prints all character information
        public override string ToString()
        {
            return "The archer " + name + " has " + health + " health, " + strength + " strength, and " + speed + ". They also have " + range + " range, and a bonus " + dodge + "% chance to dodge attacks.";
        }

    }
}
