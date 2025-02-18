using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information
{
    internal class Student
    {
        public int Age { get; set; }    
        public string Name { get; set; }
        public static List<Student> students { get; set; } = new List<Student>();


        public Student() 
        {

        }

        public Student(int Age, string Name) 
        {
            students = new List<Student>();
            this.Age = Age;
            this.Name = Name;
        }    
    }
}
