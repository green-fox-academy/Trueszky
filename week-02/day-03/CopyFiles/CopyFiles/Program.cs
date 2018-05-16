using System;
using System.IO;

// Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
// It should take the filenames as parameters
// It should return a boolean that shows if the copy was successful

namespace CopyFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a file to copy");
            string fileToCopy = Console.ReadLine();
            Console.WriteLine("New file name");
            string copyOfTheFile = Console.ReadLine();
            Copy(fileToCopy, copyOfTheFile);
            Console.ReadLine();
        }
        public static void Copy(string file1,string file2)
        {
            File.Copy(file1, file2);
        }
    }
}
