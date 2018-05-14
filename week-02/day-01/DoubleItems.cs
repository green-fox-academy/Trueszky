using System;

namespace DoubleItems
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `ag`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Double all the values in the array
            int[] ag = { 3, 4, 5, 6, 7 };
            DoubleItems(ag);
            foreach (int number in ag)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
        static int[] DoubleItems(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                x[i] *= 2;
            }
            return x;
        }
    }
}