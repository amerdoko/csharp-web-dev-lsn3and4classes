using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student amer = new Student();
            amer.Name = "Amer";
            amer.StudentId = 1;
            amer.NumberOfCredits = 1;
            amer.Gpa = 4.0;

            Student sam = new Student();
            sam.Name = "Sam";
            amer.StudentId = 2;
            amer.NumberOfCredits = 2;
            amer.Gpa = 3.9;


            Course math = new Course();
            math.Title = "Algebra";
            math.NumberOfCredits = 1;
            math.subjects = new List<string> { "Subject 1", "Subject 2"};
            math.stduents = new List<Student> { amer, sam};

            Teacher matt = new Teacher();
            matt.FirstName = "Matt";
            matt.LastName = "Flanesse";
            matt.Subject = "Math";
            matt.YearsOfTeaching = 10;

        }
    }
}
