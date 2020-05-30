using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    class Course
    {
        public string Title { get; set;}
        public int NumberOfCredits { get; set; }
        public List<string> subjects { get; set; }
        public List<Student> stduents { get; set; }

        public override string ToString()
        {
            return Title + " (Number of Credits: " + NumberOfCredits + ")";
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

            Course c = toBeCompared as Course;
            return c.Title == Title;
        }
    }
}
