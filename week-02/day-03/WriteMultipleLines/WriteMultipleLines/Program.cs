using System;
using System.IO;
// Create a function that takes 3 parameters: a path, a word and a number,
// than it should write to a file.
// The path parameter should be a string, that describes the location of the file.
// The word parameter should be a string, that will be written to the file as lines
// The number paramter should describe how many lines the file should have.
// So if the word is "apple" and the number is 5, than it should write 5 lines
// to the file and each line should be "apple"
// The function should not raise any error if it could not write the file

namespace WriteMultipleLines
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a PATH that describes the location of the file, \na WORD that will be written to the file \nand a NUMBER that describe how many lines the file should ");

            string[] pathWordNumber = new string[3];
             pathWordNumber = Console.ReadLine().Split(" ");
            string path = pathWordNumber[0];

            string word = pathWordNumber[1];
            int number = Int32.Parse(pathWordNumber[2]);
           
            StreamWriter sw = new StreamWriter(path);
            for(int i = 0; i < number; i++)
            {
                sw.WriteLine(word);                
            }
            sw.Dispose();
            Console.ReadLine();
        }
    }
}
