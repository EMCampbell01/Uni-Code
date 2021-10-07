using System;

namespace ObjectOrientedSoftwareDevelopment
{
    class Program
    {
        /** 
         * Week 2 - Unit 1 Activity
         * Written by Euan Campbell
         * 
         * Program takes in student data and prints a list of students who have passed/failed.
         * Calculates the average mark of students.
         **/
        static void Main(string[] args)
        {
            //Arrays used for storing student data
            string[] student_names   = new string[100];
            string[] student_matrics = new string[100];
            int[]    student_marks   = new int[100];

            //loop takes student data from user input until a blank name is input
            //Each student has a unique index shared between the 3 student data arrays
            int c = 0; //Current student index
            while (true)
            {
                //User prompted to enter students name
                //Name is added to student_names array at the students unique index
                Console.WriteLine("Enter Student Name:");
                string name = Console.ReadLine();
                student_names[c] = name;

                //Stop reccording student data if input is empty
                if (string.IsNullOrEmpty(name))
                {
                    break;
                }

                //User prompted to enter students matriculation number until input is valid
                String matric;
                while (true)
                {
                    Console.WriteLine("Enter Matriculation Number:");
                    matric = Console.ReadLine();
                    if (matric.Substring(0, 1).Equals("4") & matric.Length == 8)
                    {
                        student_matrics[c] = matric;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("*** Invalid Matriculation Number! ***");
                        Console.WriteLine("Try again...");
                    }
                }

                //User prompted to enter students mark until input is valid
                int mark;
                while (true)
                {
                    Console.WriteLine("Enter Student Mark:");
                    mark = int.Parse(Console.ReadLine());
                    if (mark < 0 || mark > 100)
                    {
                        Console.WriteLine("*** Invalid Mark! ***");
                        Console.WriteLine("Try again...");
                    }
                    else
                    {
                        student_marks[c] = mark;
                        break;
                    }
                }

                //Declares new student data has been reccorded
                Console.WriteLine("Student : " + name + " " + matric + " added to system");
                c++;
            }

            //Loops through each set of student data printing if they have passed/failed
            //Calculates and prints the average mark of students
            int i = 0;
            int marks_total = 0;
            float marks_average;
            while(i < c)
            { 
                Console.Write(student_names[i] + " " + student_matrics[i]);
                if(student_marks[i] > 39)
                {
                    Console.Write(" PASS");
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.Write(" FAIL");
                    Console.WriteLine(" ");
                }
                marks_total += student_marks[i];
                i++;
            }
            marks_average = marks_total / c;
            Console.WriteLine("Average Mark = " + marks_average);
        }
    }
}
