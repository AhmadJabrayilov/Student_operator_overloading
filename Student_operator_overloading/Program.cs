using Student_operator_overloading.Models;
using System;

namespace Student_operator_overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student std1 = new Student("Ahmed", "Cabrayilov", 66.5);
            std1.ShowInfo();

            Student std2 = new Student("Kermit", "The Frog", 66);
            std2.ShowInfo();
            Console.WriteLine($"Is std1 point bigger than std2 point?: --{std1>std2}--");

            Group gp1 = new Group();
            Group gp2 = new Group();
            Console.WriteLine();

        }
    }
}
