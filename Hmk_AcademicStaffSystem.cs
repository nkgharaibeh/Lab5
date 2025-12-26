using System;

namespace AcademicStaffSystem
{
    class Staff
    {
        public string Name;
        public string Department;
        public double BaseSalary;

        public Staff(string name, string department, double baseSalary)
        {
            Name = name;
            Department = department;
            BaseSalary = baseSalary;
        }

        public virtual double CalculateSalary()
        {
            return BaseSalary;
        }
    }

    class Lecturer : Staff
    {
        public Lecturer(string name, string department, double baseSalary)
            : base(name, department, baseSalary) { }

        public override double CalculateSalary()
        {
            return BaseSalary + (BaseSalary * 0.2);
        }
    }

    class Administrator : Staff
    {
        public Administrator(string name, string department, double baseSalary)
            : base(name, department, baseSalary) { }

        public override double CalculateSalary()
        {
            return BaseSalary + 300;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Lecturer l1 = new Lecturer("Lina", "CS", 1000);
            Lecturer l2 = new Lecturer("Omar", "SE", 1200);

            Administrator a1 = new Administrator("Ahmad", "IT", 900);
            Administrator a2 = new Administrator("Sara", "HR", 950);

            PrintStaff(l1);
            PrintStaff(l2);
            PrintStaff(a1);
            PrintStaff(a2);
        }

        static void PrintStaff(Staff s)
        {
            Console.WriteLine($"{s.Name} ({s.Department}) => Total Salary: {s.CalculateSalary()}");
        }
    }
}
