using System;
using System;

// Create a function that takes a number
// divides ten with it,
// and prints the result.
// It should print "fail" if the parameter is 0
namespace DividebyZero
{
    public class DividebyZero
    {
        public static void Main(string[] args)
        {
            int x;
            Console.Write("I divide 10 with the gien number,so give me one: ");
            x = Convert.ToInt32(Console.ReadLine());
            try
            {
                double y = 10 / x;
                Console.WriteLine("Result: "+y);
            }
            catch(Exception error)
            {
                Console.WriteLine("fail");
                
            }
            finally
            {
                Console.ReadLine();
            }
            
           
        } 
    }
}