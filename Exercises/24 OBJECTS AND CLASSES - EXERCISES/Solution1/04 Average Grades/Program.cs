﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Student
{
    public string Name { get; set; }
    public double[] Grades { get; set; }
    public double AverageGrade
    {
        get
        {
            return Grades.Average();
        }
    }

}
class Program
{


    static void Main(string[] args)
    {
        int numberOfStudents = int.Parse(Console.ReadLine());
        var students = new Student[numberOfStudents];
        for (int i = 0; i < numberOfStudents; i++)
        {
            var input = Console.ReadLine().Split().ToArray();
            students[i] = new Student
            {
                Name = input.First(),
                Grades = input.Skip(1).Select(double.Parse).ToArray()

            };
        }
        var orderedStudents = students.Where(x => x.AverageGrade >= 5).OrderBy(n => n.Name).ThenByDescending(a => a.AverageGrade).ToArray();
        foreach (var st in orderedStudents)
        {
            Console.WriteLine($"{st.Name} -> {st.AverageGrade:f2}");
        }
    }
}

