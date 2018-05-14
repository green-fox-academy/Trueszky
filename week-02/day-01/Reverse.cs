using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `aj`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Reverse the order of the elements in `aj`
            // - Print the elements of the reversed `aj`
            int[] aj = { 3, 4, 5, 6, 7 };

            aj=Reverse(aj);
            foreach(int num in aj)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
        static int[] Reverse(int[] x)
        {
         
            for(int i = 0; i < x.Length/2; i++)
            {
                int tmp = x[i];
                x[i] = x[x.Length - i - 1];
                x[x.Length - i - 1] = tmp;
            }
            return x;
        }
    }
}
