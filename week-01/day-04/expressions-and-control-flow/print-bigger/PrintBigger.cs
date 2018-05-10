using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one
            int num1,num2;
            Console.WriteLine("Give me two standard number");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 < num2)
            {
                Console.WriteLine(num2);
            }
            else if (num1 == num2)
            {
                Console.WriteLine("THEY ARE THE SAME");
            }
            else
            {
                Console.WriteLine(num1);
            }
            Console.ReadLine();

        }
    }
}
