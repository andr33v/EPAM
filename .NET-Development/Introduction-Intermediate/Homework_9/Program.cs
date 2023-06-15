using System;
using System.Collections.Generic;

class Automobile
{
    private string carName;
    private int maxSpeed;

    public Automobile(string carName, int maxSpeed)
    {
        this.carName = carName;
        this.maxSpeed = maxSpeed;
    }

    public string GetName()
    {
        return carName;
    }

    public int GetMaxSpeed()
    {
        return maxSpeed;
    }
}

class Task
{
    static void Main(string[] args)
    {
        Automobile carOne = new Automobile("Chevrolet Corvette Z06", 310);
        Automobile carTwo = new Automobile("Maserati MC20", 325);
        Automobile carThree = new Automobile("Ferrari 296 GTB", 320);

        List<Automobile> cars = new List<Automobile>();
        cars.Add(carOne);
        cars.Add(carTwo);
        cars.Add(carThree);

        Console.WriteLine("Catalog of cars in list: ");
        for (int i = 0; i < cars.Count; ++i)
        {
            Console.WriteLine($"Automobile #{i + 1} - {cars[i].GetName()}, {cars[i].GetMaxSpeed()} km/h");
        }

        Automobile bestCar = GetFastestCar(cars);
        Console.WriteLine($"\nThe fastest car from catalog is {bestCar.GetName()}!\nThe top speed equal {bestCar.GetMaxSpeed()} km/h!");
    }

    static Automobile GetFastestCar(List<Automobile> cars)
    {
        Automobile topCar = new Automobile("", 0);
        foreach(Automobile car in cars)
        {
            if (car.GetMaxSpeed() > topCar.GetMaxSpeed())
            {
                topCar = car;
            }
        }
        return topCar;
    }
}