using System;
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
            int var = 0, temp,num=0;
            Console.WriteLine("Give me a number ");
            var = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type here that many integer: ");
            for (int i = 1; i <= 5; i++)
            {
                temp = Convert.ToInt32(Console.ReadLine());
                num += temp;
            }
            Console.WriteLine("Sum: " + num + " Avarage: " + (num/var));
            Console.ReadLine();
        }
    }
}
