using System;

class Car
{
    private int maxSpeed;
    private string name;

    public string GetName()
    {
        return this.name;
    }

    public int GetMaxSpeed()
    {
        return this.maxSpeed;
    }

    public Car(string name, int speed)
    {
        this.name = name;
        this.maxSpeed = speed;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Car speed comparer!");

        Car carFirst = new Car("Chevrolet Corvette", 194);
        Car carSecond = new Car("Maserati MC20", 202);

        Console.WriteLine($"{carFirst.GetName()} with top speed {carFirst.GetMaxSpeed()} MPH" +
                          $" VS {carSecond.GetName()} with top speed {carSecond.GetMaxSpeed()} MPH : {CompareCars(carFirst, carSecond)}");
    }

    static string CompareCars(Car car1, Car car2)
    {
        return car1.GetMaxSpeed() > car2.GetMaxSpeed() ? car1.GetName() : car1.GetMaxSpeed() == car2.GetMaxSpeed() ? "equal" : car2.GetName();
    }
}