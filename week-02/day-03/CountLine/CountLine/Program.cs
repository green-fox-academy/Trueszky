using System;
using System.IO;

// Write a function that takes a filename as string,
// then returns the number of lines the file contains.
// It should return zero if it can't open the file, and
// should not raise any error.


namespace CountLines
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a path");
            string path = Console.ReadLine();
            
            try
            {
                string[] content = File.ReadAllLines(path);
                Console.WriteLine(content.Length);
            }
            catch(Exception e)
            {
                Console.WriteLine(0);
            }
            
            Console.ReadLine();
        }
    }
}
