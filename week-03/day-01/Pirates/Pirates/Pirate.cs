using System;
using System.Collections.Generic;
using System.Text;

namespace Pirates
{
    class Pirate
    {
        private int health = 1;
        public int rum = 0;
        public string DrinkSomeRum()
        {
            if (health == 1)
            {
                rum++;
                return "";
            }
            return Die();
        }
        public string HowsItGoingMate()
        {
            if (health == 1)
            {
                if (rum <= 4)
                {
                    return "Pour me anudder!";
                }
                else if (rum == 5)
                {
                    return "Arghh, I'ma Pirate. How d'ya d'ink its goin?";
                }
                return "SnoooOOooreee....";
            }
            return Die();
        }
        public string Die()
        {
            health--;
            return "He's dead";
        }
        public static void Brawl(Pirate pirate1, Pirate pirate2)
        {
            Random rand = new Random();
            int chance = rand.Next(1, 33);
            if (pirate1.health != 1 || pirate2.health != 1)
            {
                if (pirate1.health == 1)
                {
                    pirate1.DrinkSomeRum();
                }
                pirate2.DrinkSomeRum();
            }
            else if (chance <= 11)
            {
                pirate1.DrinkSomeRum();
                pirate2.DrinkSomeRum();
            }
            else if (chance <= 22 && chance > 11)
            {
                pirate1.Die();
                Console.WriteLine("meghalt 1 es " + chance);
            }
            else if (chance > 23)
            {
                pirate2.Die();
                Console.WriteLine("meghalt 2 es " + chance);
            }
        }
        public string Parrot()
        {
            string color = "colorfull";
            double height = 1.84;
            return "I'm a PARROT HAaaRRGH " ;
        }
    }
}
