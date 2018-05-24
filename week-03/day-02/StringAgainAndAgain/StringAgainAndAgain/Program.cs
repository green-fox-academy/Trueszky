using System;
// Given a string, compute recursively a new string where all the
// adjacent chars are now separated by a "*".
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
                return text;
            }
            else
            {
                return XChanger(text.Insert(lenght,"*"), lenght - 1);
            }
        }
    }
}
