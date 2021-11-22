using System;
using System.Collections.Generic;
using System.Text;

namespace HW6___Character_behaviors
{
    class CommonCharacter
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

        //Creates a ToString that can be overrided.
        public virtual string ToString()
        {
            return "";
        }

    }
}
