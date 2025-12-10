using System;

class Employee
{
    public string Name;
    public int BasicSalary;
}

class FullTimeEmployee : Employee
{
    public int CalculateSalary()
    {
        return BasicSalary + 500;
    }
}

class PartTimeEmployee : Employee
{
    public int CalculateSalary()
    {
        return BasicSalary / 2;
    }
}

class Program
{
    static void Main()
    {
        FullTimeEmployee f = new FullTimeEmployee() { Name = "Ahmad", BasicSalary = 1000 };
        PartTimeEmployee p = new PartTimeEmployee() { Name = "Sara", BasicSalary = 800 };

        Console.WriteLine($"{f.Name} Salary: {f.CalculateSalary()}");
        Console.WriteLine($"{p.Name} Salary: {p.CalculateSalary()}");
    }
}
