using System;

public class Program9{
    // Function to calculate the number of rounds required
    public static void CalculateRounds(double side1, double side2, double side3, double totalDistance){
        // Calculate the perimeter of the triangle
        double perimeter = side1 + side2 + side3;

        // Calculate the number of rounds needed to complete the totalDistance
        double rounds = totalDistance / perimeter;

        // Print the result
        Console.WriteLine($"The total number of rounds the athlete will run is {rounds} to complete {totalDistance} meters.");
    }

    public static void Main(string[] args){
        // Take user input for the sides of the triangle
        Console.Write("Enter the length of side 1 (in meters): ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side 2 (in meters): ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side 3 (in meters): ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        // The total distance for the run (5 km = 5000 meters)
        double totalDistance = 5000;

        // Call the function to calculate and print the number of rounds
        CalculateRounds(side1, side2, side3, totalDistance);
    }
}