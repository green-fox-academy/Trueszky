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
            Console.WriteLine(reptile.Greet() + ", "+reptile.GetName() + ", " + reptile.WantChild());
            Console.WriteLine(mammal.Greet() + ", "+mammal.GetName() + ", " + mammal.WantChild());
            Console.WriteLine(bird.Greet()+", "+bird.GetName() + ", " + bird.WantChild());
            Console.ReadLine();
        }
    }
}
