using System;
using System.Text;

namespace TakesLonger
{
    public class TakesLonger
    {
        public static void Main(string[] args)
        {
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";
            int Index=0;
            Index += quote.IndexOf("It")+2;
            // When saving this quote a disk error has occured. Please fix it.
            // Add "always takes longer than" to the StringBuilder (quote) between the words "It" and "you"
            // Using pieces of the quote variable (instead of just redefining the string)
            StringBuilder TakesLonger = new StringBuilder();
            TakesLonger.Append(quote);
            TakesLonger.Insert(Index , " always takes longer than");
            Console.WriteLine(TakesLonger);
            Console.ReadLine();
        }
    }
}