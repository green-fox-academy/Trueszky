using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores a number, and the user has to figure it out.
            // The user can input guesses, after each guess the program would tell one
            // of the following:
            //
            // The stored number is higher
            // The stried number is lower
            // You found the number: 8
            int num, var;
            Console.WriteLine("Give me a number other ppl can guess.");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("you can guess the number");
            var = Convert.ToInt32(Console.ReadLine());
            while (num != var)
            {
                 if (var > num)
                {
                    Console.WriteLine("Number is higher");
                }
                else if (var < num)
                {
                    Console.WriteLine("Number is lower");
                }
                var = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("You guessed right!!!");

            Console.ReadLine();
        }
    }
}
