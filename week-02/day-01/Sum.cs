using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Write a function called `sum` that sum all the numbers
            //   until the given parameter and returns with an integer
           
            Console.WriteLine("give me how many time should i add the numbers together");
            int x = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(Sum(x));
            Console.ReadLine();
        }
        static int Sum(int x)
        {
            int sum = 0;
            for (int i=0;i<x;i++)
            {
                sum += Convert.ToInt32(Console.ReadLine());
            }
            
            return sum;
        }
    }
}
