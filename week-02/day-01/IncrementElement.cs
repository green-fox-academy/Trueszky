using System;

namespace IncrementElement
{
    class Program
    {
        static void Main(string[] args)
        {
            //- Create an array variable named `t`
            //  with the following content: `[1, 2, 3, 4, 5]`
            //- Increment the third element
            //- Print the third element
            int[] t = { 1, 2, 3, 4, 5 };
            Console.WriteLine(IncrementElemenet(t));
            Console.ReadLine();
        }
        static int IncrementElemenet(int[] x)
        {
            return x[2] + 3;
        }
    }
}