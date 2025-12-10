using System;

class Person
{
    public string Name;
    public int Age;

    public void DisplayPerson()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Student : Person
{
    public int StudentID;
    public string Major;

    public void DisplayStudent()
    {
        DisplayPerson();
        Console.WriteLine($"Student ID: {StudentID}, Major: {Major}");
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student()
        {
            Name = "Lina",
            Age = 21,
            StudentID = 2025205,
            Major = "Computer Science"
        };

        s.DisplayStudent();
    }
}
