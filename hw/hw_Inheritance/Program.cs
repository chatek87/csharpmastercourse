namespace hw_Inheritance;

class Program
{
    static void Main(string[] args)
    {
        Console.ReadLine();
    }
}

public class Vehicle
{
    public int TopSpeed { get; set; }
    public bool HasEngine { get; set; }
    public int PassengerCapacity { get; set; }
}

public class Car : Vehicle
{
    public int NumberOfWheels { get; set; }
}

public class Motorcycle : Vehicle
{
    public int NumberOfWheels { get; set; }
}

public class Boat : Vehicle
{
    public string BoatName { get; set; }
}