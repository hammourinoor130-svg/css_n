using System;

class Car
{
    private string Brand;
    private string Model;
    private int Year;

    public void SetData(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    public void Start()
    {
        Console.WriteLine("The car is starting");
    }

    public void Drive()
    {
        Console.WriteLine("The car is driving");
    }

    public void Stop()
    {
        Console.WriteLine("The car has stopped");
    }

    public void PrintInfo()
    {
        Console.WriteLine("Brand: " + Brand);
        Console.WriteLine("Model: " + Model);
        Console.WriteLine("Year: " + Year);
    }
}

class Program
{
    static void Main()
    {
        Car car1 = new Car();
        car1.SetData("BMW", "X5", 2022);
        car1.Start();
        car1.Drive();
        car1.Stop();
        car1.PrintInfo();

        Console.WriteLine("----------------");

        Car car2 = new Car();
        car2.SetData("Toyota", "Corolla", 2020);
        car2.Start();
        car2.Drive();
        car2.Stop();
        car2.PrintInfo();
    }
}
