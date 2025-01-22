using System;

public class Program8{
    // Function to calculate and print the trip details
    public static void DisplayTripDetails(string name, string fromCity, string viaCity, string toCity,double fromToVia, double viaToFinalCity, double timeTaken){
        // Compute total distance and average speed
        double totalDistance = fromToVia + viaToFinalCity;
        double averageSpeed = totalDistance / timeTaken;

        // Print the trip details
        Console.WriteLine($"The results of the trip are: {name}, {fromCity} to {viaCity} to {toCity}, " +
                          $"Total Distance: {totalDistance} miles, Average Speed: {averageSpeed} miles/hour");
    }

    public static void Main(string[] args)
    {
        // Take user input for name, cities, distances, and time
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your starting city: ");
        string fromCity = Console.ReadLine();

        Console.Write("Enter your via city: ");
        string viaCity = Console.ReadLine();

        Console.Write("Enter your destination city: ");
        string toCity = Console.ReadLine();

        Console.Write("Enter the distance from starting city to via city (in miles): ");
        double fromToVia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the distance from via city to destination city (in miles): ");
        double viaToFinalCity = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the time taken for the journey (in hours): ");
        double timeTaken = Convert.ToDouble(Console.ReadLine());

        // Call the function to display trip details
        DisplayTripDetails(name, fromCity, viaCity, toCity, fromToVia, viaToFinalCity, timeTaken);
    }
}