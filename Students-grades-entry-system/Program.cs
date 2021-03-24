using System;

namespace Students_grades_entry_system
{
    class Program
    {
        static void results(String name, int grade)
        {
            if(grade >= 60)
            {
                Console.WriteLine(name + " and his grade is " + grade + " Passed");
            }
            else 
            {
                Console.WriteLine(name + " and his grade is " + grade + " Failed");
            }
        }

        static void Main(string[] args)
        {
            var studentName = Console.ReadLine();
            int studentGrade = Convert.ToInt32(Console.ReadLine());

            results(studentName, studentGrade);
        }


    }
}
