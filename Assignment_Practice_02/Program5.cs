using System;

public class Program5{
    // Function to convert Fahrenheit to Celsius
    public static void ConvertTemperature(double fahrenheit){
        // Convert Fahrenheit to Celsius using the formula
        double celsiusResult = (fahrenheit - 32) * 5 / 9;

        // Print the result
        Console.WriteLine($"{fahrenheit} Fahrenheit is {celsiusResult} Celsius");
    }

    public static void Main(string[] args){
        // Take user input for temperature in Fahrenheit
        Console.Write("Enter the temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        // Call the function to convert and print the temperature
        ConvertTemperature(fahrenheit);
    }
}