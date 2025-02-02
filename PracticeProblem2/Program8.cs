using System;

class Program8
{
    static void Main(string[] args)
    {
        Console.Write("Enter temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        double celsius = FahrenheitToCelsius(fahrenheit);
        Console.WriteLine(fahrenheit + " Fahrenheit is equal to " + celsius + " Celsius.");

   
        Console.Write("Enter temperature in Celsius: ");
        double celsiusInput = Convert.ToDouble(Console.ReadLine());
        double fahrenheitResult = CelsiusToFahrenheit(celsiusInput);
        Console.WriteLine(celsiusInput + " Celsius is equal to " + fahrenheitResult + " Fahrenheit.");
    }

    // Function to convert Fahrenheit to Celsius
    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    // Function to convert Celsius to Fahrenheit
    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
}
