using System;
using System.Collections.Generic;
using System.Text;
/*
 * Program name: Warrior class
 * Author: Jason Weinberg
 * Purpose: creates a warrior with its stats
 * Modifications: 
 */
namespace HW6___Character_behaviors
{
     class Warrior : CommonCharacter
    {
        private int armor;
        private int swordSkill;

        //Creates a warrior object with the default stats from the common character class and adds armor and sword skill.
        public Warrior(string Name, int Health, int Strength, int Speed, int Armor) : base(Name, Health, Strength, Speed)
        {
            name = Name;
            health = Health;
            strength = Strength;
            speed = Speed;
            armor = Armor;

            //Warrior's sword skill is based on a ratio with their speed. A faster warrior would be more skilled at using a sword than a slower one.
            swordSkill = 100 / speed;
            rng = new Random();
        }

        //Returns the armor of the character
        public int Armor
        {
            get { return armor; }
        }
        
        //Returns the sword skill of the character
        public int SwordSkill
        {
            get { return swordSkill; }
        }

        //Returns how much damage the current attack will do using strength, sword skill, and a random number
        public override int attack()
        {
            return rng.Next(1, 6) * Strength + swordSkill;
        }

        //Changes health based on mow much damage was taken and the character's armor
        public override bool takeDamage(int damage)
        {
            if (damage > armor)
            {
                health -= (damage - armor);
            }
            return true;
        }

        public override bool hasFled()
        {
            return false;
        }

        //Prints all the character information
        public override string ToString()
        {
            return "The warrior " + base.ToString() + "This warrior also gets " + armor + " bonus armor and has a sword skill level of " + swordSkill + "."; 
        }

        
    }
}
