using System;
using System.Collections.Generic;

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

            /*var studentName = Console.ReadLine();
             int studentGrade = Convert.ToInt32(Console.ReadLine());

            List<string> ls = new List<string>();
            ls.Add(studentName +' '+ studentGrade);

            foreach (var item in ls)
            {
                Console.WriteLine(item);
                results(studentName, studentGrade);
            }*/

            List<string> numbersInput = new List<string>();

            Console.WriteLine("Please enter an student Name and his Grade :");

            string studentName = Console.ReadLine();
            int studentGrade = Convert.ToInt32(Console.ReadLine());
            var input = studentName +" "+ studentGrade;

            numbersInput.Add(input);

            while (input != "")
            {
                Console.WriteLine("Please enter another student: ");
                input = Console.ReadLine();
                numbersInput.Add(input);
            }

            if (input == "")
            {
                foreach (var item in numbersInput)
                {
                    Console.WriteLine(item);
                }

            }

        }
    }
}
