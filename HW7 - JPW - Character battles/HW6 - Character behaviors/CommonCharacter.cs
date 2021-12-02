using System;
using System.Collections.Generic;
using System.Text;
/*
 * Program name: Common character class
 * Author: Jason Weinberg
 * Purpose: Basis for creating characters with their stats
 * Modifications: 
 */
namespace HW6___Character_behaviors
{
    abstract class CommonCharacter
    {
        protected string name;
        protected int health;
        protected int strength;
        protected int speed;
        protected Random rng;

        //Creates the basis character for all the other characters to be created off of. Uses name, health, strength, and speed.
        public CommonCharacter(string Name, int Health, int Strength, int Speed)
        {
            name = Name;
            health = Health;
            strength = Strength;
            speed = Speed;
            rng = new Random();
        }

        //Returns the name of the character
        public string Name
        {
            get { return name; }
        }

        //Returns or changes the health of the character. If the new health is below 0, then it sets the health to 0.
        public int Health
        {
            get { return health; }

            set
            {
                if (health >= value)
                {
                    health -= value;
                }
                else
                {
                    health = 0;
                }
            }
        }

        //Returns the strength of the character
        public int Strength
        {
            get { return strength; }
        }

        //Returns the speed of the character
        public double Speed
        {
            get { return speed; }
        }

        //Checks if the character is dead and returns true if they are.
        public bool isDead()
        {
            if (health <= 0)
            {
                return true;
            }
            return false;
        }


        //Deals the amound of damage inputted to the character
        public virtual bool takeDamage(int damage)
        {
            health = damage;
            return true;
        }

        //forces all other character classes to have an attack and fleeing method
        public abstract int attack();
        public abstract bool hasFled();

        //Creates a ToString that can be overrided.
        public virtual string ToString()
        {
            return name + " has " + health + " health, " + strength + " strength, and " + speed + ".";
        }


    }
}
