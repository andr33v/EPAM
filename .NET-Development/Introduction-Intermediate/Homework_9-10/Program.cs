class WrongSpeedException : Exception
{
    public int Speed { get; }

    public override string Message
    {
        get
        {
            return "Speed exception";
        }
    }

    public WrongSpeedException(int speed)
    {
        this.Speed = speed;
    }
}

class Automobile
{
    public string Name { get; set; }
    public int Speed { get; set; }
}

class Task
{
    static void Main()
    {
        Console.WriteLine("Custom automobile catalog!");
        List<Automobile> cars = new();

        Console.Write("Enter number of cars in your catalog: ");
        int n = Convert.ToInt16(Console.ReadLine());

        for(int i = 0; i < n; ++i)
        {
            cars.Add(new Automobile());
        }

        int number = 1;
        foreach (Automobile car in cars)
        {
            try
            {
            Console.Write($"\nEnter car model #{number++}: ");
            car.Name = Convert.ToString(Console.ReadLine());
            Console.Write("Enter car speed: ");
            car.Speed = Convert.ToInt32(Console.ReadLine());
            if(car.Speed < 0 || car.Speed >= 300)
                {
                    throw new WrongSpeedException(car.Speed);
                }
            }
            catch (WrongSpeedException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine($"Speed is very {(car.Speed < 0 ? "low" : "high")}!");
                car.Speed = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        Console.WriteLine("\nCatalog of cars in list: ");
        for (int i = 0; i < cars.Count; ++i)
        {
            Console.WriteLine($"Automobile #{i + 1} - {cars[i].Name}, {cars[i].Speed} km/h");
        }

        Automobile bestCar = GetFastestCar(cars);
        if (bestCar.Speed != 0)
            Console.WriteLine($"\nThe fastest car from catalog is {bestCar.Name}!\nThe top speed equals {bestCar.Speed} km/h!");
        else 
            Console.WriteLine("\nThe catalog has only wrong cars!");
    }

    static Automobile GetFastestCar(List<Automobile> cars)
    {
        Automobile topCar = new();
        foreach (Automobile car in cars)
        {
            if (car.Speed > topCar.Speed)
            {
                topCar = car;
            }
        }
        return topCar;
    }
}