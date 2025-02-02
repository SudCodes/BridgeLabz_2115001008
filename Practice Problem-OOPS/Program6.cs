using System;

class CarRental
{
    // Attributes
    public string CustomerName { get; set; }
    public string CarModel { get; set; }
    public int RentalDays { get; set; }
    public double DailyRate { get; set; } // Assuming a daily rental rate

    // Default Constructor
    public CarRental()
    {
        CustomerName = "Unknown";
        CarModel = "Standard";
        RentalDays = 1;
        DailyRate = 50.0; // Default daily rate
    }

    // Parameterized Constructor
    public CarRental(string customerName, string carModel, int rentalDays, double dailyRate)
    {
        CustomerName = customerName;
        CarModel = carModel;
        RentalDays = rentalDays;
        DailyRate = dailyRate;
    }

    // Method to calculate the total cost
    public double CalculateTotalCost()
    {
        return RentalDays * DailyRate;
    }

    // Method to display rental details
    public void DisplayRentalDetails()
    {
        Console.WriteLine($"Customer: {CustomerName}");
        Console.WriteLine($"Car Model: {CarModel}");
        Console.WriteLine($"Rental Days: {RentalDays}");
        Console.WriteLine($"Daily Rate: ${DailyRate}");
        Console.WriteLine($"Total Cost: ${CalculateTotalCost()}");
    }
}

class Program6
{
    public static void Main()
    {
        // Using the default constructor
        CarRental rental1 = new CarRental();
        rental1.DisplayRentalDetails();

        Console.WriteLine();

        // Using the parameterized constructor
        CarRental rental2 = new CarRental("John Doe", "Toyota Corolla", 5, 60.0);
        rental2.DisplayRentalDetails();
    }
}
