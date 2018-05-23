using System;
using System.Collections.Generic;
using System.Text;

namespace Pirates
{
    class Pirate
    {
        public int healt = 1;
        public static int rum = 0;
        public string DrinkSomeRum()
        {
            if (healt==1)
            {
            rum++;
            }
            return Die();
        }
        public string HowsItGoingMate()
        {
            if (healt == 1)
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
            healt--;
            return "He's dead";
        }
    }
}
