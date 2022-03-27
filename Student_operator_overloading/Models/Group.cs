using System;
using System.Collections.Generic;
using System.Text;

namespace Student_operator_overloading.Models
{
    internal class Group
    {
        public int No { get; }
        private static int _no { get; set; } = 100;


        public Group()
        {
            //ap = "AP";
            _no++;
            No = _no;
            Console.WriteLine($"AP{No}");
        }

        private Student[] students;

        public Group(Student student)
        {
            students = new Student[0];
        }


        public void AddStudent(Student student)
        {
            Array.Resize(ref students, 4);
            students[students.Length - 1] = student;
        }

        public Student[] GetAllStudents()
        {
            return students; 
        }
    }
}
