using System;
// We have bunnies standing in a line, numbered 1, 2, ... The odd bunnies
// (1, 3, ..) have the normal 2 ears. The even bunnies (2, 4, ..) we'll say
// have 3 ears, because they each have a raised foot. Recursively return the
// number of "ears" in the bunny line 1, 2, ... n (without loops or multiplication).
namespace BunnyAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many odd and normal bunnies should we have ?(odd enough odd is the normal)");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine(BunnyEarCounter(n,0));
            Console.ReadLine();
        }
        public static int BunnyEarCounter(int n,int ears)
        {
            if (n % 2 == 0)
            {
                ears += 3;
            }
            else if (n%2!=0)
            {
                ears += 2;
            }
            if (n == 1)
            {
                return ears;
            }
            return BunnyEarCounter(n - 1,ears);

        }
    }
}
