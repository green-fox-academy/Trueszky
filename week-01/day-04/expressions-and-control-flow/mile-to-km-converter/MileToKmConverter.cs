using System;

namespace Trueszky
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for an integer that is a distance in kilometers,
            // then it converts that value to miles and prints it
            int var;
            Console.WriteLine("How long ??(in meter)");
            var = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("It is " + var* 0.62137 + " in miles");
            Console.ReadLine();
        }
    }
}
