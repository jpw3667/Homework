using System;
using System.Collections.Generic;
using System.Text;

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
        public int attack()
        {
            return rng.Next(1, 6) * Strength + swordSkill;
        }

        //Changes health based on mow much damage was taken and the character's armor
        public void takeDamage(int damage)
        {
            if (damage > armor)
            {
                health -= (damage - armor);
            }
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

        //Prints all the character information
        public override string ToString()
        {
            return "The warrior " + name + " has " + health + " health, " + strength + " strength, and " + speed + ". This warrior also gets " + armor + " bonus armor and has a sword skill level of " + swordSkill + "."; 
        }

        
    }
}
