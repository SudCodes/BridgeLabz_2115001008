using System;

public class Program9
{
    // Method to find the Euclidean distance between two points
    public static double CalculateEuclideanDistance(double x1, double y1, double x2, double y2)
    {
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return distance;
    }

    // Method to find the equation of the line given two points
    public static double[] FindEquationOfLine(double x1, double y1, double x2, double y2)
    {
        // Calculate the slope (m)
        double m = (y2 - y1) / (x2 - x1);

        // Calculate the y-intercept (b)
        double b = y1 - m * x1;


        return new double[] { m, b };
    }

    public static void Main()
    {
        // Take inputs for two points
        Console.Write("Enter the x-coordinate of the first point (x1): ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the y-coordinate of the first point (y1): ");
        double y1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the x-coordinate of the second point (x2): ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("Enter the y-coordinate of the second point (y2): ");
        double y2 = double.Parse(Console.ReadLine());

        // Calculate the Euclidean distance
        double distance = CalculateEuclideanDistance(x1, y1, x2, y2);
        Console.WriteLine($"The Euclidean distance between the two points is: {distance}");

        // Find the equation of the line
        double[] equation = FindEquationOfLine(x1, y1, x2, y2);
        double slope = equation[0];
        double intercept = equation[1];

        // Display the equation of the line
        Console.WriteLine($"The equation of the line is: y = {slope}*x + {intercept}");
    }
}
