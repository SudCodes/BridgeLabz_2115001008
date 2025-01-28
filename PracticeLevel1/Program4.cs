using System;

class Program4{
	
    static double km2miles = 0.621371;
    static double miles2km = 1.60934;
    static double meters2feet = 3.28084;
    static double feet2meters = 0.3048;

    //km to miles
    public static double ConvertKmToMiles(double km){
		return km*km2miles; 
	}

    //miles to km
    public static double ConvertMilesToKm(double miles) { 
		return miles*miles2km; 
	}

    //m to feet
    public static double ConvertMetersToFeet(double meters){
		return meters*meters2feet; 
	}

    //feet to m
    public static double ConvertFeetToMeters(double feet){
		return feet*feet2meters; 
	}

    public static void Main(){
		
        Console.Write("Enter kilometers to convert to miles ");
        double km = double.Parse(Console.ReadLine());
        Console.WriteLine(km + " km = " + ConvertKmToMiles(km) + " miles");

        Console.Write("Enter miles to convert to kilometers ");
        double miles = double.Parse(Console.ReadLine());
        Console.WriteLine(miles + " miles = " + ConvertMilesToKm(miles) + " km");

        Console.Write("Enter meters to convert to feet ");
        double meters = double.Parse(Console.ReadLine());
        Console.WriteLine(meters + " meters = " + ConvertMetersToFeet(meters) + " feet");

        Console.Write("Enter feet to convert to meters ");
        double feet = double.Parse(Console.ReadLine());
        Console.WriteLine(feet + " feet = " + ConvertFeetToMeters(feet) + " meters");
    }
}
