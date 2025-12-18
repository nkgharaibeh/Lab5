using System;

namespace Basic_Example
{
    class Tyre
    {
        // SLIDE NOTE:
        // Base class has a member method that is reused by derived classes.
        protected void TyreType()
        {
            Console.WriteLine("This is Tubeless Tyre");
        }
    }

    class Scooter : Tyre
    {
        public void ScooterType()
        {
            Console.WriteLine("Scooter Color is Red");

            // Reusing the base functionality:
            TyreType();
        }
    }

    class Car : Tyre
    {
        public void CarType()
        {
            Console.WriteLine("Car Type : Ferrari");

            // Reusing the base functionality:
            TyreType();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Scooter sc = new Scooter();
            sc.ScooterType();

            Car c = new Car();
            c.CarType();

            Console.ReadKey();
        }
    }
}

/*
SLIDE CONNECTION:
- How inheritance works in programming:
  Base class (Tyre) provides shared behavior (TyreType()).
  Derived classes (Scooter, Car) reuse it + add their own output.
*/
