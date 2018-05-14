using System;
namespace AppendA
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `animals`
            //   with the following content: `["kuty", "macsk", "cic"]`
            // - Add all elements an `"a"` at the end
            string[] animals = { "kuty", "macsk", "cic" };
            AppendA(animals);
            foreach(string name in animals)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
        public static string[] AppendA(string[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                x[i] += "a";
            }
            return x;
        }
    }
}