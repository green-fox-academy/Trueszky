using System;

namespace AnimalsInTheZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            var reptile = new Reptile("Crocodile", 165, "male");
            var mammal = new Mammal("Koala", 16, "male");
            var bird = new Bird("Parrot", 4, "female");

            Console.WriteLine("Who want a baby?");
            Console.WriteLine(reptile.GetName() + ", " + reptile.WantChild());
            Console.WriteLine(mammal.GetName() + ", " + mammal.WantChild());
            Console.WriteLine(bird.GetName() + ", " + bird.WantChild());
            Console.ReadLine();
        }
    }
}
