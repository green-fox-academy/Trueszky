using System;

namespace Trueszky
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a number.
            // It would ask this many times to enter an integer,
            // if all the integers are entered, it should print the sum and average of these
            // integers like:
            //
            // Sum: 22, Average: 4.4
            int var, num = 0;
            Console.WriteLine("Give me a number ");
            var = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type here that many integer: ");
            for (int i = 1; i <= var; i++)
            {
                num += Convert.ToInt32(Console.ReadLine());               
            }
            Console.WriteLine("Sum: " + num + "\r\nAvarage: " + (num / var));
            Console.ReadLine();
        }
    }
}
