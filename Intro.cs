using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information
{
    internal class Intro
    {
        public void intro()
        {
            bool introo = true;
            while (introo)
            { 
               
                try 
                {
                    Console.WriteLine("Hello Press \n 1. To enter your information \n 2. Display information \n 3. Exit ");
                    int userINput = int.Parse(Console.ReadLine());
                    if (userINput == 1)
                    {
                        StudentService studentService = new StudentService();
                        studentService.studentInfo();
                    }
                    else if (userINput == 2)
                    {
                        StudentService student = new StudentService();
                        student.DisplayStudent();

                    }
                    else if (userINput == 3)
                    {
                        introo = false;
                    }
                    else
                    {
                        Console.WriteLine("Wrong choice");
                        introo = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong format, Enter only numbers");
                }
                catch(Exception)
                {
                    Console.WriteLine("Wrong input");
                }
            }
            
        }
    }
}
