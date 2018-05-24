using System;
using System.Text.RegularExpressions;
// Given a string, compute recursively a new string where all the 'x' chars have been removed.
namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("give me some string");
            string text = Console.ReadLine();
            int lenght = text.Length;
            Console.WriteLine(XChanger(text, lenght));
            Console.ReadLine();
        }
        public static string XChanger(string text, int lenght)
        {
            if (lenght == 0)
            {
                return text.Replace("x", "");
            }
            return XChanger(text, lenght - 1);
        }
    }
}
