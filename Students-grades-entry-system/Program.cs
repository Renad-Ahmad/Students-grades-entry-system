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
            viewStudents();

            // prompt the user which student he wants to change (user input = 1 then index = 0)
            Console.WriteLine("enter a number");
            int search = int.Parse(Console.ReadLine());
            search -= 1;
            //print the student
            for (int i = 0; i < ls.Count; i++)
            {   if (search == i)
                { 
                    Console.WriteLine(ls[i].toString());

                    Console.WriteLine("Enter (1) to update both name and grade \n" +
                        " Enter (2) to update only the name \n" +
                        " Enter (3) to update only the name ");
                    int operation = int.Parse(Console.ReadLine());

                    switch (operation)
                    {
                        case 1:
                            Console.WriteLine("update student name: ");
                            ls[i].setName(Console.ReadLine());

                            Console.WriteLine("update Grade: ");
                            ls[i].setGrade(int.Parse(Console.ReadLine()));
                            break;
                        case 2:
                            Console.WriteLine("update student name: ");
                            ls[i].setName(Console.ReadLine());
                            break;
                        case 3:
                            Console.WriteLine("update Grade: ");
                            ls[i].setGrade(int.Parse(Console.ReadLine()));
                            break;
                        default:
                            Console.WriteLine("Invalid input");
                            break;
                    }

                }
            }

        }
    }

    class Student
    {
        public string name;
        private int grade;
        private string status;

        public void setName(string newname)
        {
            this.name = newname;
        }

        public void setGrade(int newGrade)
        {
            this.grade = newGrade;

            if (grade >=  60)
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
