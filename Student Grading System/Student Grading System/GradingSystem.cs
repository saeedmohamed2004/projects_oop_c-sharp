using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grading_System
{
    internal class GradingSystem
    {

        public void Displaygradinginfo(
            List<Student> students,
            Func<List<int>,double> calculateaverage,
            Predicate<double> CheckIfPassed,
            Action<Student,double,bool> Displaydata) 
        {
            foreach (var student in students)
            {
               
                double averagegrades = calculateaverage(student.Grades);

                bool isstudentpass = CheckIfPassed(averagegrades);

                Displaydata(student, averagegrades, isstudentpass);
            }
        }










    }
}
