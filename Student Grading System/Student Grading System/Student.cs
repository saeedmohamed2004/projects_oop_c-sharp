using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grading_System
{
    internal class Student
    {
        public string Name { get; set; }

        public List <int> Grades { get; set; }

        public Student(string name, List<int> grades)
        {
            Name = name;
            Grades = grades;
        }
    }
}
