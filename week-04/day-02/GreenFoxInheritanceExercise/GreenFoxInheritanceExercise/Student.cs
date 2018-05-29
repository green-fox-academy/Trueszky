using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxInheritanceExercise
{
    public class Student : Person
    {
        private string previousOrganization;
        private int skippedDays = 0;

        public Student(string name, int age, string gender, string previousOrganization) : base(name, age, gender)
        {
            this.previousOrganization = previousOrganization;
        }

        public override string GetGoal()
        {
            return "Be a junior software developer.";
        }

        public override string Introduce()
        {
            return string.Format("Hi, I'm {0}, a {1} year old {2} from {3} who skipped {4} days from the course already.", name, age, gender, previousOrganization, skippedDays);
        }

        public int SkipDays(int numberOfDays)
        {
            return skippedDays += numberOfDays;
        }

        public Student()
        {
            name = "Jane Doe";
            age = 30;
            gender = "female";
            previousOrganization = "The School of Life";
            skippedDays = 0;
        }


    }
}
