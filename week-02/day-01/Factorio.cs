using System;

namespace Factorio
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `factorio`
            //   that returns it's input's factorial
            int x;
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Factorio(x));
            Console.ReadLine();
        }
        static int Factorio(int x)
        {
            int fact=1;
           for(int i = 1; i <= x; i++)
            {
                fact=i*fact;
            }
            return fact;
        }
    }
}