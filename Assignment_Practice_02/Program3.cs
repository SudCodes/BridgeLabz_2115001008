using System;

public class Program3
{
    // Function to perform the double operations
    public static void PerformOperations(double a, double b, double c)
    {
        double result1 = a + b * c;  // Multiplication has higher precedence than addition
        double result2 = a * b + c;  // Multiplication has higher precedence than addition
        double result3 = c + a / b;  // Division has higher precedence than addition
        double result4 = a % b + c;  // Modulus has higher precedence than addition (not valid with doubles)

        // Print the results of the operations
        Console.WriteLine($"The results of Double Operations are {result1}, {result2}, {result3}, and {result4}");
    }

    public static void Main(string[] args)
    {
        // Take user input for a, b, and c
        Console.Write("Enter value for a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter value for b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter value for c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Call the function to perform operations
        PerformOperations(a, b, c);
    }
}