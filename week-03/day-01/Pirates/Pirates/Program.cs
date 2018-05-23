using System;

namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            Pirate pirate1 = new Pirate();
            Pirate pirate2 = new Pirate();                
            while (true)
            {

                Pirate.Brawl(pirate1,pirate2);

                Console.WriteLine(pirate1.Names()+": " + pirate1.HowsItGoingMate());
                Console.WriteLine(pirate2.Names() + ": " + pirate2.HowsItGoingMate());
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
