using System;

class Animal
{
    protected string Type = "Mammal";
        // 'protected' members are accessible ONLY:
        // 1) inside the same class (Animal)
        // 2) inside derived classes (Dog)
}

class Dog : Animal
{
    public void ShowType()
    {
        Console.WriteLine("Animal Type: " + Type);  // Accessing protected member (Type) from base class inside derived class:
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
