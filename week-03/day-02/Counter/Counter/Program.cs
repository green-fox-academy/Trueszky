using System;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a recursive function that takes one parameter: n and counts down from n.
            Console.WriteLine("Give me n!!");
            int n = Int32.Parse(Console.ReadLine());
            nCounter(n);
            Console.ReadLine();
        }
        public static int nCounter(int n)
        {
            if (n==0)
            {
                return 1;
            }
            else
            {
                Console.WriteLine(n);
                return nCounter(n-1);
            }
        }
    }
}
