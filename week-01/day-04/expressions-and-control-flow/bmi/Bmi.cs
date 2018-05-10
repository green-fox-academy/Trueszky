using System;

namespace Trueszky
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the Body mass index (BMI) based on these values
            double massInKg = 81.2;
            double heightInM = 1.78;
            double TTI;
            Console.WriteLine("A TTI = " + massInKg / (heightInM*heightInM));
            Console.ReadLine();
        }
    }
}
