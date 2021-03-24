using System;

namespace Students_grades_entry_system
{
    class Program
    {
        static void results(String name, int grade)
        {
            Console.WriteLine(name + " and his grade is " + grade);


        }

        static void Main(string[] args)
        {
            var studentName = Console.ReadLine();
            int studentGrade = Convert.ToInt32(Console.ReadLine());

            results(studentName, studentGrade);
        }


    }
}
