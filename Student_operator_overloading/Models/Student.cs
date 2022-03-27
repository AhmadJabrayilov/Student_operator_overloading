using System;
using System.Collections.Generic;
using System.Text;

namespace Student_operator_overloading.Models
{
    internal class Student
    {
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public double Point { get; set; }


        public Student(string name, string surname, double point)
        {
            _id++;
            Id = _id;
            Name = name;
            SurName = surname;
            Point = point;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"ID: {Id} //// Name: {Name} //// Surname: {SurName} //// Age: {Age} //// Point {Point} ");
        }

        public static bool operator >(Student std1, Student std2)
        {
            return std1.Point > std2.Point;
        }
        public static bool operator <(Student std1, Student std2)
        {
            return std1.Point < std2.Point;
        }

    }
}
