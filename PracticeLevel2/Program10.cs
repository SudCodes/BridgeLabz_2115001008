using System;

class Program10{

    public static double CalculatewindChill(double temperature, double windSpeed){
        return 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);
    }
	
	
    public static void Main(String[] args){
		
        Console.Write("Enter temperature ");
        double temperature = double.Parse(Console.ReadLine());

        Console.Write("Enter wind speed ");
        double windSpeed = double.Parse(Console.ReadLine());

        double windChill = CalculatewindChill(temperature, windSpeed);

        Console.WriteLine("Wind chill temperature " + windChill);
    }
}
