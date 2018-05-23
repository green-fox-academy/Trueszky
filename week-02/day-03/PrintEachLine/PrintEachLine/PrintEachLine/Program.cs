using System;
using System.IO;
// Write a program that opens a file called "my-file.txt", then prints
// each of lines form the file.
// If the program is unable to read the file (for example it does not exists),
// then it should print an error message like: "Unable to read file: my-file.txt"

namespace PrintEachLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "my-file.txt";
            try
            {
                StreamReader sr = new StreamReader(path);
                string line = sr.ReadLine();
                Console.WriteLine(sr);
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to read file: "+path);
            }
             Console.ReadLine();
        }
    }
}
