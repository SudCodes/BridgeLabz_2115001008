using System;

public class Program2
{
    // Function to perform the integer operations
    public static void PerformOperations(int a, int b, int c)
    {
        int result1 = a + b * c;  // Multiplication has higher precedence than addition
        int result2 = a * b + c;  // Multiplication has higher precedence than addition
        int result3 = c + a / b;  // Division has higher precedence than addition
        int result4 = a % b + c;  // Modulus has higher precedence than addition

        // Print the results of the operations
        Console.WriteLine($"The results of Int Operations are {result1}, {result2}, {result3}, and {result4}");
    }

    public static void Main(string[] args)
    {
        // Take user input for a, b, and c
        Console.Write("Enter value for a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter value for b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter value for c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        // Call the function to perform operations
        PerformOperations(a, b, c);
    }
}