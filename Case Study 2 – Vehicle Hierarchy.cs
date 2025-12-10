using System;

class Vehicle
{
    public string Brand;
    public int Speed;

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
    }
}

class Car : Vehicle
{
    public override void DisplayInfo()
    {
        Console.WriteLine($"Car Brand: {Brand}, Speed: {Speed} km/h");
    }
}

class Bike : Vehicle
{
    public override void DisplayInfo()
    {
        Console.WriteLine($"Bike Brand: {Brand}, Speed: {Speed} km/h");
    }
}

class Program
{
    static void Main()
    {
        Vehicle v = new Vehicle { Brand = "Generic", Speed = 60 };
        Car c = new Car { Brand = "Toyota", Speed = 180 };
        Bike b = new Bike { Brand = "Yamaha", Speed = 120 };

        v.DisplayInfo();
        c.DisplayInfo();
        b.DisplayInfo();
    }
}
