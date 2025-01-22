using System;

public class Program12{
    // Function to convert pounds to kilograms
    public static void ConvertWeight(double weightInPounds){
        // Convert the weight to kilograms
        double weightInKg = weightInPounds * 2.2;

        // Print the result
        Console.WriteLine($"The weight of the person in pounds is {weightInPounds} and in kg is {weightInKg}");
    }

    public static void Main(string[] args){
        // Take user input for weight in pounds
        Console.Write("Enter the weight in pounds: ");
        double weightInPounds = Convert.ToDouble(Console.ReadLine());

        // Call the function to convert weight and display the result
        ConvertWeight(weightInPounds);
    }
}