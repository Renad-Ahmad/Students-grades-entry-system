using System;
using System.Collections.Generic;
using System.Linq;

namespace Students_grades_entry_system
{
    class Program
    {
        static void results(string name, int grade)
        {
            if (grade >= 60)
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

            List<string> ls = new List<string>();
            ls.Add(studentName +' '+ studentGrade);

            foreach (var item in ls)
            {
                Console.WriteLine(item);
                results(studentName, studentGrade);
            }
            
        }
    }
}
