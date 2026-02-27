namespace Student_Grading_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<Student> Students = new List<Student>();

            while (true)
            {
                Console.WriteLine("Welcome to the Grading system");

                Console.WriteLine("Please Enter Your Name: or enter 'done' when finshed");


                string studentname = Console.ReadLine();

                if (studentname=="done")
                {
                    break;
                }
                List<int> StudentsGrades = new List<int>();//for 1 student


                Console.WriteLine("Please Enter Your grades:(5 subjects)");


                for (int i = 0; i < 5; i++)
                {
                    int gradevalue =Convert.ToInt32(Console.ReadLine());

                    StudentsGrades.Add(gradevalue);
                }

                Student student = new Student(studentname, StudentsGrades);
                Students.Add(student);


                Console.WriteLine($"A new student added to The system With name {studentname} with total {StudentsGrades.Count}");

            }
           GradingSystem gradingSystem = new GradingSystem();

           gradingSystem.Displaygradinginfo(Students, CalculateAverageType1,Checkifstudentpass,Displaydata);

        }

       

        private static double CalculateAverageType1(List<int> grades)
        {
            return grades.Sum()/grades.Count;
        }
        private static bool Checkifstudentpass(double averagevalue)
        {
            if (averagevalue >= 50)
            {
                return true;
            }
            return false;

        }
        private static void Displaydata(Student student, double average, bool ispassed)
        {
            string status = "Passed";

            if (!ispassed) 
            {
                 status = "faiiled";
            }
            Console.WriteLine($"The user name is {student.Name} and average grde is {average} ");

            Console.WriteLine($"The user name is {student.Name} and status is {status} ");


        }
    }
}
