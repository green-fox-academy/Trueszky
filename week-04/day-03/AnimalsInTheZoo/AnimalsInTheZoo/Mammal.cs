using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsInTheZoo
{
    class Mammal : Animal
    {
        public Mammal(string name, int age, string gender) : base(name, age, gender)
        {

        }

        public override string GetName()
        {
            return Name;
        }

        public override string Greet()
        {
            return string.Format($"Hi, my name is {Name}, I'm {Age} old {Gender}");
        }

        public override string WantChild()
        {
            return "want a child from my uterus";
        }
    }
}
