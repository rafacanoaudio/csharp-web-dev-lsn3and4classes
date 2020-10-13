using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.

            Student rafa = new Student("Rafa", 1, 15, 4.0);
            Student becca = new Student("Becca", 2, 85, 4.0);

            Console.WriteLine(becca.GetGradeLevel());
        }
    }
}
