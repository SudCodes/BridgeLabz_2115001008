using System;

public class Program10
{
    // Method to calculate the slope between two points
    public static double CalculateSlope(double x1, double y1, double x2, double y2)
    {
        return (y2 - y1) / (x2 - x1);
    }

    // Method to check if three points are collinear using the slope formula
    public static bool AreCollinearBySlope(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        double slopeAB = CalculateSlope(x1, y1, x2, y2);
        double slopeBC = CalculateSlope(x2, y2, x3, y3);
        double slopeAC = CalculateSlope(x1, y1, x3, y3);

        // If the slopes of AB, BC, and AC are equal, the points are collinear
        return slopeAB == slopeBC && slopeBC == slopeAC;
    }

    // Method to check if three points are collinear using the area of the triangle formula
    public static bool AreCollinearByArea(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        // Area of the triangle formed by points A(x1, y1), B(x2, y2), and C(x3, y3)
        double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));

        // If the area is 0, the points are collinear
        return area == 0;
    }

    // Main method to take user input and display results
    public static void Main()
    {
        // Take inputs for the 3 points
        Console.Write("Enter x1: ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("Enter y1: ");
        double y1 = double.Parse(Console.ReadLine());

        Console.Write("Enter x2: ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("Enter y2: ");
        double y2 = double.Parse(Console.ReadLine());

        Console.Write("Enter x3: ");
        double x3 = double.Parse(Console.ReadLine());
        Console.Write("Enter y3: ");
        double y3 = double.Parse(Console.ReadLine());

        // Check if the points are collinear using the slope method
        bool areCollinearBySlope = AreCollinearBySlope(x1, y1, x2, y2, x3, y3);
        if (areCollinearBySlope)
        {
            Console.WriteLine("The points are collinear using the slope method.");
        }
        else
        {
            Console.WriteLine("The points are not collinear using the slope method.");
        }

        // Check if the points are collinear using the area method
        bool areCollinearByArea = AreCollinearByArea(x1, y1, x2, y2, x3, y3);
        if (areCollinearByArea)
        {
            Console.WriteLine("The points are collinear using the area method.");
        }
        else
        {
            Console.WriteLine("The points are not collinear using the area method.");
        }
    }
}
