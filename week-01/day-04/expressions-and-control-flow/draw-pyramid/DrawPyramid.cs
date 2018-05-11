using System;

namespace Trueszky
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //
            // The pyramid should have as many lines as the number was
            Console.WriteLine("Tell me with a number how big the pyramid should be");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    Console.Write("  ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                   Console.Write("*" + " ");
                }
                 Console.WriteLine();
            }
                    
            Console.ReadLine();
        }
    }
}
