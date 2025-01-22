/*7. Write a Program to compute the volume of Earth in km^3 and miles^3
Hint: Volume of a Sphere is (4/3) * pi * r^3 and radius of earth is 6378 km
O/P => The volume of earth in cubic kilometers is ____ and cubic miles is ____
*/

using System;

public class Program7{
    public static void Main(string[] args){
        // Radius of Earth in kilometers
        double radiusKm = 6378.0;

        // Calculate volumes
        double volumeKm3 = CalculateVolume(radiusKm);
        double volumeMiles3 = CalculateVolume(ConvertToMiles(radiusKm));

        // Print results
        Console.WriteLine("The volume of Earth in cubic kilometers is " + volumeKm3:F2 + " and cubic miles is " + volumeMiles3:F2);
    }

    // Public function to calculate the volume of a sphere
    public static double CalculateVolume(double radius){
        return (4.0 / 3) * Math.PI * Math.Pow(radius, 3);
    }

    // Public function to convert kilometers to miles
    public static double ConvertToMiles(double kilometers){
        return kilometers * 0.621371;
    }
}
