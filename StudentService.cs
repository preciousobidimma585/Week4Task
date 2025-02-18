using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Student_Information
{
    internal class StudentService
    {
        
        public void studentInfo()
        {
            bool stillEntering = true;
            while (stillEntering)
            {
                Student student = new Student();
                Console.WriteLine("Enter your name:   ");
                student.Name = Console.ReadLine().Trim();
                bool validate = true;

                while (true)
                {
                    try
                    {
                        while (validate)
                        {
                            Console.WriteLine("Enter your age:   ");
                            student.Age = int.Parse(Console.ReadLine());
                            if (student.Age < 1 || student.Age > 100)
                            {
                                Console.WriteLine("Age is out of Range. Enter an age between 1- 100");
                            }
                            else
                            {
                                Console.WriteLine("Information Saved.....");
                                break;
                            }
                            
                        }

                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter the right format for age (Numbers only)");
                    }
                   
                }
                
                Student.students.Add(student);
               

                bool enterAgain = true;
                while (enterAgain)
                {
                    Console.WriteLine("Do you want to Enter another student information /n Y/N");
                    string answer = Console.ReadLine().ToUpper();
                    if (answer == "Y")
                    {
                        stillEntering = true;
                        break;
                    }
                    else if (answer == "N")
                    {
                        stillEntering = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Choice");
                    }
                }
               
            }
           
        }
        public void DisplayStudent()
        {
            if (Student.students.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }

            Console.WriteLine("Student List:");

            foreach (Student stud in Student.students)
            {
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine($"| Name: {stud.Name}        Age: {stud.Age}");
  
            }
            Console.WriteLine("-------------------------------------------");
        }
    }
}
