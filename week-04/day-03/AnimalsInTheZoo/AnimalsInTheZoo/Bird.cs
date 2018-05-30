using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsInTheZoo
{
    class Bird : Animal
    {
        public Bird(string name, int age, string gender) : base(name, age, gender)
        {
        }

        public override string GetName()
        {
            return Name;
        }
        
        public override string WantChild()
        {
            return "want a child from an egg";
        }
    }
}
