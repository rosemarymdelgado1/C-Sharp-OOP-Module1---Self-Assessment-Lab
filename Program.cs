using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1___Self_Assessment_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate a UProgram object called Information Technology.
            var universityProgram = new UProgram("Information Technology");

            //Instantiate a Degree object, such as Bachelor.
            var degree = new Degree("Bachelor");

            //Add the Degree object to the UProgram object.
            universityProgram.Degree = degree;

            //Instantiate a Course object called Programming with C#.
            var course = new Course("Programming with C#");
            
            //Add your Course object to the Degree object.
            degree.Course = course;

            //Instantiate three Student objects.
            Student student1 = new Student("Alexander Delgado", 19);
            Student student2 = new Student("Janet Jackason", 18);
            Student student3 = new Student("Natalie Castro", 21);

            var sArray = new Student[3];
            sArray[0] = student1;
            sArray[1] = student2;
            sArray[2] = student3;

            //Add your three students to this Course object.
            course.Students = sArray;

            //Instantiate at least one Teacher object.
            Teacher teacher1 = new Teacher("Amy Shaffer", false);
            Teacher teacher2 = new Teacher("Juan Bonilla", true);

            var tArray = new Teacher[2];
            tArray[0] = teacher1;
            tArray[1] = teacher2;

            //Add that Teacher object to your Course object.
            course.Teachers = tArray;

            //Using Console.WriteLine statements, output the following information to the console window:
                //The name of the program and the degree it contains
                //The name of the course in the degree
                //The count of the number of students in the course.
            Console.WriteLine($"The name of the program is {universityProgram.Name} and it contains a {degree.Name} degree.");
            Console.WriteLine($"The name of the course in the {degree.Name} Degree is {course.Name}.");
            Console.WriteLine($"There are {Student.instances} students enrolled in the {course.Name} course.");
        }
    }
}
