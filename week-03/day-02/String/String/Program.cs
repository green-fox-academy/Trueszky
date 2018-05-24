using System;
// Given a string, compute recursively (no loops) a new string where all the
// lowercase 'x' chars have been changed to 'y' chars.
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
        public static string XChanger(string text,int lenght)
        {
            if (lenght==0)
            {
                return text.Replace('x', 'y');
            }
            return XChanger(text,lenght-1);
        }
    }
}
