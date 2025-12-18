using System;

class Person
{
    // FIELD (State) in the base class:
    // This data belongs to the general concept "Person".
    public string Name;
    public int Age;
    
    // METHOD (Behavior) in the base class:
    // Any derived class will inherit this behavior.
    public void DisplayPerson()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Student : Person
{
    // SINGLE INHERITANCE:
    // Student IS-A Person (Student inherits from Person using ':').
    // Student gets Name + Age + Display() for free (code reuse).
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
        // Creating an object from the derived class:
        Student s = new Student()
        {
            Name = "Lina",         // Accessing inherited public fields:
            Age = 21,
            StudentID = 2025205,          // Accessing derived class own field:
            Major = "Computer Science"
        };

        s.DisplayStudent();         // Calling inherited method:
/*
KEY IDEA (OOP / Software Engineering):
- Reusability: do not repeat base logic; call inherited method.
- Extensibility: child can add features without changing the parent.
*/
        
    }
}
