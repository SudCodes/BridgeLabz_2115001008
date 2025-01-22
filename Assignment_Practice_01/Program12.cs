/*Write a program that takes the base and height to find the area of a triangle in square inches and square centimeters
Hint: Area of a Triangle is ½ * base * height
I/P => base, height
O/P => Your Height in cm is ___ while in feet is ___ and inches is ___
*/

using System;

class TriangleArea
{
    // Function to calculate the area of the triangle
    public static void CalculateArea(double baseLength, double height)
    {
        // Calculate the area of the triangle
        double areaInSquareCm = 0.5 * baseLength * height;
        
        // Convert area from square cm to square inches
        double areaInSquareInches = areaInSquareCm / 6.4516;

        // Output the results
        Console.WriteLine("The area of the triangle is " + areaInSquareCm + " square centimeters and " + areaInSquareInches + " square inches.");
    }

    public static void Main()
    {
        // Ask user to enter the base and height of the triangle
        Console.Write("Enter the base of the triangle in centimeters: ");
        double baseLength = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the height of the triangle in centimeters: ");
        double height = Convert.ToDouble(Console.ReadLine());

        // Call the function to calculate the area
        CalculateArea(baseLength, height);
    }
}
