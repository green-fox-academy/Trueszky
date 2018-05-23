using System;

namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            Pirate pirate1 = new Pirate();
            Pirate pirate2 = new Pirate();
            pirate1.Names();
            pirate2.Names();
            Ships ship = new Ships();
            ship.FillShip();
            Console.WriteLine(ship.numberOfCrew);
            while (true)
            {

                Pirate.Brawl(pirate1,pirate2);

                Console.WriteLine(pirate1.name +": " + pirate1.HowsItGoingMate());
                Console.WriteLine(pirate2.name + ": " + pirate2.HowsItGoingMate());
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
