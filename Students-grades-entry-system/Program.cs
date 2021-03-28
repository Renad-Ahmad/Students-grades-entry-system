using System;
using System.Collections.Generic;

namespace Students_grades_entry_system
{
    class Program
    {
        public static List<Student> ls = new List<Student>();

        static void Main(string[] args)
        {
            //While the program is runing let the user chose what operation he want
            while (true)
            {
                Console.WriteLine("Chose your operation \n" +
                    "1. Add student\n"+
                    "2. View students\n"+
                    "3.Change student info"
                    );
                string operation = Console.ReadLine();
                if (operation == "1")
                {
                    //call the add function to add new student
                    addStudent();
                }
                else if (operation == "2")
                {
                    //call the view function to show all students
                    viewStudents();
                }
                else if (operation == "3")
                {
                    //call the change info function to update a student
                    changeStudentsInfo();
                }
                else
                {
                    //if the user entered invalid input it will print this
                    Console.WriteLine("Invalid input");
                }
            }
        }

        public static void addStudent()
        {   
            //let the user know what operation he's into for the moment
            Console.WriteLine("In add student");

            //creat a new student
            Student student = new Student();

            //ask the user to enter a name and take his input
            Console.WriteLine("Enter student name: ");
            student.name = Console.ReadLine();

            // if the user input not empty let him add the student grad
            if(student.name != "") 
            {
                Console.WriteLine("Enter Grade: ");
                //to make sure the user enter a grade in numbers for a student
                //otherwise it will not creat a new student
                try
                {
                    student.setGrade(int.Parse(Console.ReadLine()));
                    ls.Add(student);
                }
                catch (Exception)
                {

                    Console.WriteLine("The grade can not be empty and it should be in numbers.");
                }
            }

            //if the student name is empty print this
            else
            {
                Console.WriteLine("The student name can not be empty.");
            }
        }

        public static void viewStudents()
        {
            //let the user know what operation he's into for the moment
            Console.WriteLine("In view student");

            Console.WriteLine("# Student Name \t grade \t status");

            //outputs all elements in the student array using a for loop
            for (int i = 0; i < ls.Count; i++)
            {
                //outputs numbers for the students and student info
                Console.WriteLine(i + 1 + ". " + ls[i].toString());
            }
        }

        public static void changeStudentsInfo()
        {
            //let the user know what operation he's into for the moment
            Console.WriteLine("In update student");

            // print all students
            viewStudents();

            // prompt the user which student he wants to change
            Console.WriteLine("Enter student number");
            try
            {
                //(user input = 1 then index = 0)
                int search = int.Parse(Console.ReadLine());
                search -= 1;

                //loop over students and output the student
                //with the same number as what the user entered
                for (int i = 0; i < ls.Count; i++)
                {
                    if (search == i)
                    {
                        // prompt the student he wants to change
                        Console.WriteLine(ls[i].toString());

                        //ask what he want to update exactly
                        Console.WriteLine("\n Enter (1) to update both name and grade \n" +
                            " Enter (2) to update only the name \n" +
                            " Enter (3) to update only the grade ");

                        //take user input for what operation he want
                        int operation = int.Parse(Console.ReadLine());

                        switch (operation)
                        {
                            case 1:
                                Console.WriteLine("Update student name: ");
                                ls[i].setName(Console.ReadLine());

                                Console.WriteLine("Update Grade: ");

                                //to make sure the user enter a grade in numbers for a student
                                //otherwise it will not creat a new student
                                try
                                {
                                    ls[i].setGrade(int.Parse(Console.ReadLine()));
                                }
                                catch (Exception)
                                {

                                    Console.WriteLine("The grade can not be empty and it should be in numbers.");
                                }
                                break;

                            case 2:
                                Console.WriteLine("Update student name: ");
                                ls[i].setName(Console.ReadLine());
                                break;

                            case 3:
                                Console.WriteLine("Update student Grade: ");

                                //to make sure the user enter a grade in numbers for a student
                                try
                                {
                                    ls[i].setGrade(int.Parse(Console.ReadLine()));
                                }
                                catch (Exception)
                                {

                                    Console.WriteLine("The grade can not be empty and it should be in numbers.");
                                }
                                break;

                            //if the user entered invalid input it will print this
                            default:
                                Console.WriteLine("Invalid input");
                                break;
                        }

                    }
                }
            }

            //to make sure the user enter operation in numbers and it's not empty
            catch (Exception)
            {
                Console.WriteLine("This can not be empty and you should enter numbers only.");
            }
        }
    }

    //Create Student Object
    class Student
    {
        public string name;
        private int grade;
        private string status;

        // to set a new student name
        public void setName(string newname)
        {
            this.name = newname;
        }

        // to set a new student grade
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

        // to print student info
        public string toString()
        {
            return this.name + "\t \t " + this.grade + "\t " + this.status;
        }
    }
}
