﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxInheritanceExercise
{
    public class Person
    {
        public string name;
        public int age;
        public string gender;

        public virtual string Introduce()
        {
            return "Hi, I'm " + name + ", a " + age + " year old " + gender + ".";
        }

        public virtual string GetGoal()
        {
            return "My goal is: Live for the moment!";
        }

        public Person(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
        public Person()
        {
            name = "Jane Doe";
            age = 30;
            gender = "female";
        }
    }
}
