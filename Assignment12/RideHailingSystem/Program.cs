using System;
using System.Collections.Generic;

abstract class Vehicle
{
    public int VehicleId { get; private set; }
    public string DriverName { get; private set; }
    protected double RatePerKm { get; private set; }

    protected Vehicle(int vehicleId, string driverName, double ratePerKm)
    {
        VehicleId = vehicleId;
        DriverName = driverName;
        RatePerKm = ratePerKm;
    }

    public abstract double CalculateFare(double distance);

    public virtual void GetVehicleDetails()
    {
        Console.WriteLine($"Vehicle ID: {VehicleId}, Driver: {DriverName}, Rate per Km: {RatePerKm:C}");
    }
}

interface IGPS
{
    string GetCurrentLocation();
    void UpdateLocation(string newLocation);
}

class Car : Vehicle, IGPS
{
    private string CurrentLocation;

    public Car(int vehicleId, string driverName, double ratePerKm)
        : base(vehicleId, driverName, ratePerKm) { }

    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm;
    }

    public string GetCurrentLocation()
    {
        return CurrentLocation;
    }

    public void UpdateLocation(string newLocation)
    {
        CurrentLocation = newLocation;
        Console.WriteLine($"Car location updated to: {CurrentLocation}");
    }

    public override void GetVehicleDetails()
    {
        base.GetVehicleDetails();
        Console.WriteLine("Vehicle Type: Car");
    }
}

class Bike : Vehicle, IGPS
{
    private string CurrentLocation;

    public Bike(int vehicleId, string driverName, double ratePerKm)
        : base(vehicleId, driverName, ratePerKm) { }

    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm * 0.9;
    }

    public string GetCurrentLocation()
    {
        return CurrentLocation;
    }

    public void UpdateLocation(string newLocation)
    {
        CurrentLocation = newLocation;
        Console.WriteLine($"Bike location updated to: {CurrentLocation}");
    }

    public override void GetVehicleDetails()
    {
        base.GetVehicleDetails();
        Console.WriteLine("Vehicle Type: Bike");
    }
}

class Auto : Vehicle, IGPS
{
    private string CurrentLocation;

    public Auto(int vehicleId, string driverName, double ratePerKm)
        : base(vehicleId, driverName, ratePerKm) { }

    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm * 1.1;
    }

    public string GetCurrentLocation()
    {
        return CurrentLocation;
    }

    public void UpdateLocation(string newLocation)
    {
        CurrentLocation = newLocation;
        Console.WriteLine($"Auto location updated to: {CurrentLocation}");
    }

    public override void GetVehicleDetails()
    {
        base.GetVehicleDetails();
        Console.WriteLine("Vehicle Type: Auto");
    }
}

class Program
{
    static void ProcessRides(List<Vehicle> vehicles, double distance)
    {
        foreach (var vehicle in vehicles)
        {
            vehicle.GetVehicleDetails();
            Console.WriteLine($"Fare for {distance} km: {vehicle.CalculateFare(distance):C}\n");
        }
    }

    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car(101, "Rahul Sharma", 12.5),
            new Bike(102, "Anjali Verma", 8),
            new Auto(103, "Amit Kumar", 10)
        };

        ProcessRides(vehicles, 15);

        IGPS carGps = new Car(104, "Vikram Singh", 14);
        carGps.UpdateLocation("Downtown");
        Console.WriteLine($"Car's Current Location: {carGps.GetCurrentLocation()}");
    }
}
