using System.Diagnostics;

namespace Homework3
{
    public class Student
    {
        public string name;
        public double gpa;

        public Student(string name)
        {
            this.name = name;
        }

        public Student(string name, double gpa)
        {
            this.name = name;
            this.gpa = gpa;
        }
    }
}