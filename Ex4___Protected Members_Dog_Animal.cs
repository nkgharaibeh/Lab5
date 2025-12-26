using System;

class Animal
{
    protected string Type = "Mammal";
}

class Dog : Animal
{
    public void ShowType()
    {
        Console.WriteLine("Animal Type: " + Type);
    }
}

class Program
{
    static void Main()
    {
        Dog d = new Dog();
        d.ShowType();
    }
}
