using System;

class Program6{
	
    static double fahrenheit2celsius = 5.0/9.0, celsius2fahrenheit = 9.0/5.0, pounds2kilograms = 0.453592, kilograms2pounds = 2.20462;
    static double gallons2liters = 3.78541;

    //Fahrenheit to Celsius
    public static double ConvertFahrenheitToCelsius(double fahrenheit){
        return (fahrenheit-32)*fahrenheit2celsius;
    }

    //Celsius to Fahrenheit
    public static double ConvertCelsiusToFahrenheit(double celsius){
        return (celsius*celsius2fahrenheit)+32;
    }

    //Pounds to Kilograms
    public static double ConvertPoundsToKilograms(double pounds){
        return pounds*pounds2kilograms;
    }

    //Kilograms to Pounds
    public static double ConvertKilogramsToPounds(double kilograms){
        return kilograms * kilograms2pounds;
    }

    //Gallons to Liters
    public static double ConvertGallonsToLiters(double gallons){
        return gallons * gallons2liters;
    }

    public static void Main(){
		
        Console.Write("Enter Fahrenheit to convert to Celsius ");
        double fahrenheit = double.Parse(Console.ReadLine());
        Console.WriteLine(fahrenheit + " Fahrenheit = " + ConvertFahrenheitToCelsius(fahrenheit) + " Celsius");

        Console.Write("Enter Celsius to convert to Fahrenheit ");
        double celsius = double.Parse(Console.ReadLine());
        Console.WriteLine(celsius + " Celsius = " + ConvertCelsiusToFahrenheit(celsius) + " Fahrenheit");

        Console.Write("Enter pounds to convert to kilograms ");
        double pounds = double.Parse(Console.ReadLine());
        Console.WriteLine(pounds + " pounds = " + ConvertPoundsToKilograms(pounds) + " kilograms");

        Console.Write("Enter kilograms to convert to pounds ");
        double kilograms = double.Parse(Console.ReadLine());
        Console.WriteLine(kilograms + " kilograms = " + ConvertKilogramsToPounds(kilograms) + " pounds");

        Console.Write("Enter gallons to convert to liters ");
        double gallons = double.Parse(Console.ReadLine());
        Console.WriteLine(gallons + " gallons = " + ConvertGallonsToLiters(gallons) + " liters");
    }
}
