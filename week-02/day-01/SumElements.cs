using System;

namespace SumElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `r`
            //   with the following content: `[54, 23, 66, 12]`
            // - Print the sum of the second and the third element
            int[] r = { 54, 23, 66, 12 };
            Console.WriteLine(PrintSum(r));
            Console.ReadLine();
        }
        static int PrintSum(int[] x)
        {
            return x[1] + x[2];
        }
    }
}
