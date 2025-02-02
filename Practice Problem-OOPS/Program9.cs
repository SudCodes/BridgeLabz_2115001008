using System;

class Vehicle
{
    // Instance variables
    public string OwnerName { get; set; }
    public string VehicleType { get; set; }

    // Class variable (shared among all vehicles)
    public static double RegistrationFee { get; set; } = 100.0; // Default registration fee

    // Constructor
    public Vehicle(string ownerName, string vehicleType)
    {
        OwnerName = ownerName;
        VehicleType = vehicleType;
    }

    // Instance method to display vehicle details
    public void DisplayVehicleDetails()
    {
        Console.WriteLine($"Owner Name: {OwnerName}");
        Console.WriteLine($"Vehicle Type: {VehicleType}");
        Console.WriteLine($"Registration Fee: ${RegistrationFee}");
    }

    // Class method to update the registration fee for all vehicles
    public static void UpdateRegistrationFee(double newFee)
    {
        RegistrationFee = newFee;
        Console.WriteLine($"Registration Fee updated to: ${RegistrationFee}");
    }
}

class Program9
{
    public static void Main()
    {
        // Creating vehicles
        Vehicle vehicle1 = new Vehicle("Alice Johnson", "Car");
        vehicle1.DisplayVehicleDetails();

        Console.WriteLine();

        Vehicle vehicle2 = new Vehicle("Bob Smith", "Motorcycle");
        vehicle2.DisplayVehicleDetails();

        Console.WriteLine();

        // Updating the registration fee for all vehicles
        Vehicle.UpdateRegistrationFee(150.0);

        // Displaying updated vehicle details
        Console.WriteLine("\nUpdated Vehicle Details:");
        vehicle1.DisplayVehicleDetails();
        vehicle2.DisplayVehicleDetails();
    }
}
