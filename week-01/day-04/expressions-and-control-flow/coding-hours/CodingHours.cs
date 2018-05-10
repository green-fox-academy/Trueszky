using System;

namespace Trueszky
{
    class Program
    {
        static void Main(string[] args)
        {
            // An average Green Fox attendee codes 6 hours daily
            // The semester is 17 weeks long
            //
            // Print how many hours is spent with coding in a semester by an attendee,
            // if the attendee only codes on workdays.
            //
            // Print the percentage of the coding hours in the semester if the average
            // work hours weekly is 52
            Console.WriteLine("Itt van hogy mennyi idot toltunk itt a Green Fox -nál kodolással.");
            Console.WriteLine("Az kodolással töltött orak szama a 17week alatt {0}", 17 * 5 * 6);
            Console.WriteLine("A szemeszter " + 30.0/(52.0/100) + " százalékát töltüttük ezzel." );
            Console.ReadLine();
        }
    }
}
