using System;
using System.IO;

// Open a file called "my-file.txt"
// Write your name in it as a single line
// If the program is unable to write the file,
// then it should print an error message like: "Unable to write file: my-file.txt

namespace WriteSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = Console.ReadLine();
            try
            {
                StreamWriter sw = new StreamWriter(file);
                sw.WriteLine("Andreas von Germany");
                sw.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine("Unable to write file: my - " + file);
            }
            Console.ReadLine();
        }
    }
}
