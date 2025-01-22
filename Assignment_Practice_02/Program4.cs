using System;

public class TemperatureConversion{
    // Function to convert Celsius to Fahrenheit
    public static void ConvertTemperature(double celsius){
        // Convert Celsius to Fahrenheit using the formula
        double fahrenheitResult = (celsius * 9 / 5) + 32;

        // Print the result
        Console.WriteLine($"{celsius} Celsius is {fahrenheitResult} Fahrenheit");
    }

    public static void Main(string[] args){
        // Take user input for temperature in Celsius
        Console.Write("Enter the temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        // Call the function to convert and print the temperature
        ConvertTemperature(celsius);
    }
}