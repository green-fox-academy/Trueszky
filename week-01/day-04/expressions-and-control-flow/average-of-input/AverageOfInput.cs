using System;

namespace Trueszky
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4
            int var=0, temp;
            Console.WriteLine("Type here 5 integer: ");
            for(int i=1; i <= 5; i++)
            {
                temp = Convert.ToInt32(Console.ReadLine());
                var += temp;
            }
            Console.WriteLine("Sum: " +var+" Avarage: "+var/5);
            Console.ReadLine();
        }
    }
}
