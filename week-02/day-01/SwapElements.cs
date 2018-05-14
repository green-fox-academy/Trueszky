using System;

namespace SwapElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `abc`
            //   with the following content: `["first", "second", "third"]`
            // - Swap the first and the third element of `abc`
            string[] abc = { "first", "second", "third" };
            SwapElements(abc);
            foreach(string place in abc)
            {
                Console.WriteLine(place);
            }

            Console.ReadLine();
        }
        static string[] SwapElements(string[] x)
        {
            string y="";
            y=x[0];
            x[0] = x[2];
            x[2]=y;
            return x;
        }
    }
}
