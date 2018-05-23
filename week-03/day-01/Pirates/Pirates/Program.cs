using System;

namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            Pirate pirate = new Pirate();
            while (true)
            {
                pirate.DrinkSomeRum();
                Console.WriteLine(pirate.HowsItGoingMate());
                Console.ReadLine();
                pirate.Die();
                Console.WriteLine(pirate.HowsItGoingMate());
            }
            Console.ReadLine();
        }
    }
}
