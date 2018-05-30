using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsInTheZoo
{
    public abstract class Animal
    {

        private string name;
        private int age;
        private string gender;
        public Animal(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
        }
        public string Gender
        {
            get
            {
                return gender;
            }
        }
        public string Greet()
        {
            return string.Format($"Hi, my name is {Name}, I'm {Age} old {Gender}");
        }
        public abstract string GetName();
        public abstract string WantChild();


    }



}
