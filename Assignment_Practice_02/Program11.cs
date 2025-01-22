using System;

public class Program11{
    // Function to calculate simple interest
    public static void CalculateSimpleInterest(double principal, double rate, double time){
        // Calculate simple interest using the formula
        double simpleInterest = (principal * rate * time) / 100;

        // Print the result
        Console.WriteLine($"The Simple Interest is {simpleInterest} for Principal {principal}, " + $"Rate of Interest {rate}, and Time {time}");
    }

    public static void Main(string[] args){
        // Take user input for Principal, Rate, and Time
        Console.Write("Enter the Principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Rate of Interest: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Time period in years: ");
        double time = Convert.ToDouble(Console.ReadLine());

        // Call the function to calculate and print the simple interest
        CalculateSimpleInterest(principal, rate, time);
    }
}