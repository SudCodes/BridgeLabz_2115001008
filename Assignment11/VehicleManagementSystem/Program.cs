using System;

// Superclass: Vehicle
class Vehicle
{
    public string Model { get; set; }
    public int MaxSpeed { get; set; }

    public Vehicle(string model, int maxSpeed)
    {
        Model = model;
        MaxSpeed = maxSpeed;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Model: {Model}, Max Speed: {MaxSpeed} km/h");
    }
}

// Interface: Refuelable
interface Refuelable
{
    void Refuel();
}

// Subclass: ElectricVehicle (Inherits from Vehicle)
class ElectricVehicle : Vehicle
{
    public int BatteryCapacity { get; set; }

    public ElectricVehicle(string model, int maxSpeed, int batteryCapacity)
        : base(model, maxSpeed)
    {
        BatteryCapacity = batteryCapacity;
    }

    public void Charge()
    {
        Console.WriteLine($"{Model} is charging. Battery Capacity: {BatteryCapacity} kWh.");
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Type: Electric Vehicle");
    }
}

// Subclass: PetrolVehicle (Inherits from Vehicle, Implements Refuelable)
class PetrolVehicle : Vehicle, Refuelable
{
    public double FuelCapacity { get; set; }

    public PetrolVehicle(string model, int maxSpeed, double fuelCapacity)
        : base(model, maxSpeed)
    {
        FuelCapacity = fuelCapacity;
    }

    public void Refuel()
    {
        Console.WriteLine($"{Model} is refueling. Fuel Capacity: {FuelCapacity} liters.");
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Type: Petrol Vehicle");
    }
}

// Main Program
class Program
{
    static void Main()
    {
        ElectricVehicle ev = new ElectricVehicle("Tesla Model 3", 200, 75);
        PetrolVehicle pv = new PetrolVehicle("Honda City", 180, 40);

        ev.DisplayDetails();
        ev.Charge();
        Console.WriteLine();

        pv.DisplayDetails();
        pv.Refuel();
    }
}
