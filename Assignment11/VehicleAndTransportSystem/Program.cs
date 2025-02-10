class Vehicle
{
    public int MaxSpeed { get; set; }
    public string FuelType { get; set; }

    public Vehicle(int maxspeed, string fueltype)
    {
        this.MaxSpeed = maxspeed;
        this.FuelType = fueltype;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Max Speed: {MaxSpeed} km/h, Fuel Type: {FuelType}");
    }
}

class Car : Vehicle
{
    public int SeatCapacity { get; set; }
    public Car(int maxspeed, string fueltype, int seatcapacity) : base(maxspeed, fueltype) 
    {
        this.SeatCapacity = seatcapacity;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Seat Capacity: {SeatCapacity}");
    }
}
class Truck : Vehicle
{
    public int PayloadCapacity { get; set; }

    public Truck(int maxspeed, string fueltype, int payloadcapacity) : base(maxspeed, fueltype)
    {
        this.PayloadCapacity = payloadcapacity;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Payload Capacity : {PayloadCapacity}");
    }
}
class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }

    public Motorcycle(int maxspeed, string fueltype, bool hassidecar) : base(maxspeed, fueltype)
    {
        this.HasSidecar = hassidecar;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Has Side Car: {HasSidecar}");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Vehicle[] vehicles = new Vehicle[]
        {
            new Car(200, "Petrol", 5),
            new Truck(120, "Diesel", 10000),
            new Motorcycle(180, "Petrol", false)
        };

        foreach (Vehicle v in vehicles)
        {
            v.DisplayInfo();
        }
    }
}