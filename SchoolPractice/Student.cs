using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        private string Name;
        private int StudentId;
        private int NumberOfCredits;
        private double Gpa;

        public Student (string aName, int aStudentId, int aNumberOfCredits, double aGpa)
        {
            Name = aName;
            StudentId = aStudentId;
            NumberOfCredits = aNumberOfCredits;
            Gpa = aGpa;
        }

        public Student (string aName, int aStudentId)
        {
            Name = aName;
            StudentId = aStudentId;
            NumberOfCredits = 0;
            Gpa = 0.0;
        }

        public string GetGradeLevel()
        {
            if (NumberOfCredits < 30)
            {
                return ("Freshman");
            } else if (NumberOfCredits < 60)
            {
                return ("Sophomore");
            } else if (NumberOfCredits < 90)
            {
                return ("Junior");
            } else
            {
                return ("Senior");
            }
        }

        //public void AddGrade(int courseCredits, double grade)
        //{



        //    double totalQualityScore = qualityScore;


        //    NumberOfCredits += courseCredits;
        //    double qualityScore = grade * courseCredits;
        //    double gpa = totalQualityScore / courseCredits;

        //    double
        //}
    }

 
}
