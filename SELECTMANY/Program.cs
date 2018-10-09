using System;
using System.Linq;


class School
{
    public Student[] Students { get; set; }
}

class Student
{
    public string Name { get; set; }
}


public class Program
{
    public static void Main()
    {

        var schools = new[] {
            new School(){ Students = new [] { new Student(){ Name="Bob"}, new Student(){ Name="Jack"} }},
            new School(){ Students = new [] { new Student(){ Name="Jim"}, new Student(){ Name="John"} }}
        };

        var allStudents = schools.SelectMany(s => s.Students);

        foreach (var student in allStudents)
        {
            Console.WriteLine(student.Name);
        }


    }
}