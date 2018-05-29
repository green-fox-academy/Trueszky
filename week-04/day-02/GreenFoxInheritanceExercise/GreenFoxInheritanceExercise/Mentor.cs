using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxInheritanceExercise
{
    public class Mentor : Person
    {
        public string level;
        public Mentor(string name, int age, string gender, string level) : base(name, age, gender)
        {
            this.level = level;
        }

        public override string GetGoal()
        {
            return "Educate brilliant junior software developers.";
        }
        public override string Introduce()
        {
            return string.Format("Hi, I'm {0}, a {1} year old {2} {3} mentor.",name,age,gender,level);
        }

        public Mentor()
        {
            name = "Jane Doe";
            age = 30;
            gender = "female";
            level = "intermediate";
        }

    }
}
