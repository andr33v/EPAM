using System;
using System.Runtime.ConstrainedExecution;
using System.Text;

class Automobile
{
    protected string name = "";
    protected int maxSpeed;

    private void SetName(string name)
    {
        this.name = name;
    }

    private void SetMaxSpeed(int speed)
    {
        this.maxSpeed = speed;
    }

    public virtual string GetName()
    {
        return name;
    }

    public virtual int GetMaxSpeed()
    {
        return maxSpeed;
    }

    public Automobile()
    {
        Console.Write("Enter your automobile's name: ");
        SetName(Console.ReadLine());

        Console.Write("Enter your automobile's max speed: ");
        SetMaxSpeed(Convert.ToInt16(Console.ReadLine()));
    }
}

class Car : Automobile
{
    protected int places;

    private void SetMaxPlaces(int places)
    {
        this.places = places;
    }

    public int GetMaxPlaces()
    {
        return this.places;
    }

    public Car()
    {
        Console.Write("Enter your car's max places: ");
        SetMaxPlaces(Convert.ToInt16(Console.ReadLine()));
    }
}

class Vehicle : Automobile
{
    protected int weight;

    private void SetWeight(int weight)
    {
        this.weight = weight;
    }

    public int GetWeight()
    {
        return this.weight;
    }

    public Vehicle()
    {
        Console.Write("Enter your vehicle's weight: ");
        SetWeight(Convert.ToInt16(Console.ReadLine()));
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        Vehicle vehicle = new Vehicle();

        Automobile[] automobiles = {car, vehicle};
        if (automobiles[0].GetMaxSpeed() > automobiles[1].GetMaxSpeed())
        {
            Console.WriteLine($"The fastest automobile is car with name {automobiles[0].GetName()},\nmax speed is {automobiles[0].GetMaxSpeed} and number of places are {(automobiles[0] as Car).GetMaxPlaces()}");
        }
        else if (automobiles[0].GetMaxSpeed() < automobiles[1].GetMaxSpeed())
        {
            Console.WriteLine($"The fastest automobile is vehicle with name {automobiles[1].GetName()},\nmax speed is {automobiles[1].GetMaxSpeed()} and weight {(automobiles[1] as Vehicle).GetWeight()} kg");
        }
        else
        {
            Console.WriteLine("Both of automobiles have the same speed!");
        }
    }
}
