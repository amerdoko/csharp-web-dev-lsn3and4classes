using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name {
            get { return Name; }
            set { Name = value; } 
        }
        public int StudentId {
            get { return StudentId; }
            set { StudentId = value; } 
        }
        public int NumberOfCredits { 
            get { return NumberOfCredits; } 
            set { NumberOfCredits = value; }
        }
        public double Gpa { 
            get { return Gpa; }
            set { Gpa = value; }
        }

        public Student(string name, int sId, int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = sId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int sId)
        {
            Name = name;
            StudentId = sId;
            NumberOfCredits = 0;
            Gpa = 0.0;
        }

        public Student(string name)
        {
            Name = name;
            StudentId = nextStudentId;
            nextStudentId++;
            NumberOfCredits = 0;
            Gpa = 0.0;
        }

        public string StudentInfo()
        {
            return (Name + " has a GPA of: " + Gpa);
        }

        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate fields: NumberOfCredits, Gpa
            double currentTotalQualityScore = Convert.ToDouble(NumberOfCredits * Gpa);
            double newTotalQualityScore = currentTotalQualityScore + ( grade * courseCredits);
            this.NumberOfCredits = NumberOfCredits + courseCredits;
            this.Gpa = newTotalQualityScore/NumberOfCredits;
        }

        public string GetGradeLevel()
        {
            // Determine the grade level of the student based on NumberOfCredits
            if (this.NumberOfCredits <= 29)
            {
                return "Freshman";
            }
            else if (this.NumberOfCredits > 29 && this.NumberOfCredits <= 59)
            {
                return "Sophomore";
            }
            else if (this.NumberOfCredits > 59 && this.NumberOfCredits <= 89)
            {
                return "Junior";
            } else
            {
                return "Senior";
            }
        }

        public override string ToString()
        {
            return Name + " (Credits: " + NumberOfCredits + ", GPA: " + Gpa + ")";
        }

        public override bool Equals(object toBeCompared)
        {

            if (toBeCompared == this)
            {
                return true;
            }

            if (toBeCompared == null)
            {
                return false;
            }

            if (toBeCompared.GetType() != this.GetType())
            {
                return false;
            }

            Student s = toBeCompared as Student;
            return s.StudentId == StudentId;
        }
    }
}
