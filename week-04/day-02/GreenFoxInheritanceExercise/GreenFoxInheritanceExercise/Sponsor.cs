using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxInheritanceExercise
{
     public class Sponsor : Person
    {
        public string company;
        public int hiredStudents=0;
        public Sponsor(string name, int age, string gender, string company) : base(name, age, gender)
        {
            this.company = company;
        }

        public override string Introduce()
        {
            return string.Format("Hi, I'm {0}, a {1} year old {2} who represents {3} and hired {4} students so far."
                                                , name, age, gender, company, hiredStudents);
        }

        public int Hire()
        {
            return hiredStudents+1;
        }

        public override string GetGoal()
        {
            return "Hire brilliant junior software developers.";
        }

        public Sponsor()
        {
            name = "Jane Doe";
            age = 30;
            gender = "female";
            company = "Google";
            hiredStudents = 0;
        }

    }
}
