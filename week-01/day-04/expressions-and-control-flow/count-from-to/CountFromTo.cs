using System;

namespace Trueszky
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5
            int num1,num2;
            Console.WriteLine("Give me two number");
            num1 = Int32.Parse(Console.ReadLine());
            num2 = Int32.Parse(Console.ReadLine());
            if (num1 < num2)
            {
                for(;num1<=num2; num1++)
                {
                    Console.WriteLine(num1);
                }
                    
            }
            else if (num1 > num2)
            {
                Console.WriteLine("The second number should be bigger");
            }
            else
            {
                Console.WriteLine("They are the same");
            }
            Console.ReadLine();
        }
    }
}
