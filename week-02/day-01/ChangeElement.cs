using System;

namespace ChangeElement
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `s`
            //   with the following content: `[1, 2, 3, 8, 5, 6]`
            // - Change the 8 to 4
            // - Print the fourth element
            int[] s={1,2,3,8,5,6};
            Console.WriteLine(ChangeElement(s));
            Console.ReadLine();
        }
        static int ChangeElement(int[]x)
        {
            return x[4]=4;
        }
    }
}
