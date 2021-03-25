using System;
using System.Collections.Generic;

namespace Students_grades_entry_system
{
    class Program
    {
        // comments

        // test edge cases

        // clean up

        // read the question again and make sure you didn't miss any thing

        public static List<Student> ls = new List<Student>();

        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("chose your operation \n" +
                    "1. Add student\n"+
                    "2. View students\n"+
                    "3.change student info"
                    );
                string operation = Console.ReadLine();
                if (operation == "1")
                {
                    addStudent();
                }
                else if (operation == "2")
                {
                    viewStudents();
                }
                else if (operation == "3")
                {
                    changeStudentsInfo();
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }

        }

        public static void addStudent()
        {
            Console.WriteLine("In add student");

            Student student = new Student();

            Console.WriteLine("Enterstudent name: ");
            student.name = Console.ReadLine();

            Console.WriteLine("Enter Grade: ");
            student.setGrade(int.Parse(Console.ReadLine()));

            ls.Add(student);

        }

        public static void viewStudents()
        {
            Console.WriteLine("# Student Name \t grade \t status");

            for (int i = 0; i < ls.Count; i++)
            {
                //Console.WriteLine(i);
                Console.WriteLine(i + 1 + ". " + ls[i].toString());
            }

            

        }

        public static void changeStudentsInfo()
        {
            // print students

            // prompt the user which student he wants to change (user input = 1 then index = 0)

            // prompt the user to change the name (-1 don't change)
            // if -1 keep the old name 

            // prompt the user to change the grade (-1 don't change)
            // if -1 keep the old grade 

        }
    }

    class Student
    {
        public string name;
        private int grade;
        private string status;

        public void setGrade(int newGrade)
        {
            this.grade = newGrade;

            if (grade >= 60)
            {
                this.status = "Pass";
            }
            else
            {
                this.status = "Fail";
            }
        }

        public string toString()
        {
            return this.name + "\t" + this.grade + "\t" + this.status;
        }

    }
    
}
