using System;

namespace Trueszky
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000
            double sideA, sideB, sideC;
            sideA = 5;
            sideB = 3;
            sideC = 4;
            Console.WriteLine("Surface Area: " + ((sideA * sideB) + (sideC * sideB) + (sideA * sideC))*2);
            Console.WriteLine("Volume: " + sideA * sideB * sideC +"m²");
            Console.ReadLine();
        }
    }
}
