using System;

namespace Trueszky
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have
            int chickenLeg, pigLeg;
            Console.WriteLine("How many are there chicks?");
            chickenLeg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many pigs?");
            pigLeg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Those animals have this many legs: "+((pigLeg*4)+(chickenLeg*2)));
            Console.ReadLine();

        }
    }
}
