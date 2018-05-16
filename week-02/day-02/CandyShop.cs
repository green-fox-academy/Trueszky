using System;
using System.Collections.Generic;

namespace CandyShop
{
    public class Candyshop
    {
        public static void Main(string[] args)
        {
            var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);

            // Accidentally we added "2" and "false" to the list.
            // Your task is to change from "2" to "Croissant" and change from "false" to "Ice cream"
            // No, don't just remove the lines
            // Create a method called Sweets() which takes the list as a parameter.

            Console.WriteLine(Sweets(list));
            // Expected output: "Cupcake", "Croissant", "Brownie", "Ice cream"
            Console.ReadLine();
        }
        public static string Sweets(List<object> x)
        {
            for(int i = 0; i < x.Count; i++)
            {
                if (x[i] is bool)
                {
                    x.Remove(i);
                    x.Add("Ice cream");
                }
                else if(x[i] is int) 
                {
                    x.Remove(i);
                    x.Add("Croissant");
                } 
            }
            foreach(object name in x)
            {
                Console.WriteLine(name);
            }
            
            return x.ToString();
        }
    }
}
