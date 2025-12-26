using System;

class Person
{
    public string Name;

    public Person(string n)
    {
        Name = n;
    }
}

class Student : Person
{
    public int ID;

    public Student(string n, int id) : base(n)
    {
        ID = id;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, ID: {ID}");
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student("Sara", 221144);
        s.Display();
    }
}
