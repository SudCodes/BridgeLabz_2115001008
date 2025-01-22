/* Write a program to find the distance in yards and miles for the distance provided by the user in feet
Hint: 1 mile = 1760 yards and 1 yard is 3 feet
I/P => distanceInFeet
O/P => Your Height in cm is ___ while in feet is ___ and inches is ___
*/

using System;

class DistanceConversion
{
    // Function to convert feet to yards and miles
    public static void ConvertDistance(double distanceInFeet)
    {
        // Conversion factors
        double distanceInYards = distanceInFeet / 3;         // 1 yard = 3 feet
        double distanceInMiles = distanceInYards / 1760;     // 1 mile = 1760 yards

        // Output the results
        Console.WriteLine("The distance in yards is " + distanceInYards + " and in miles is " + distanceInMiles);
    }

    public static void Main()
    {
        // Prompt user to enter distance in feet
        Console.Write("Enter the distance in feet: ");
        double distanceInFeet = Convert.ToDouble(Console.ReadLine());

        // Call the function to convert the distance
        ConvertDistance(distanceInFeet);
    }
}
