using System;

class Calculator
{
    // Function to perform the calculation
    public static double PerformCalculation(double first, double second, string op)
    {
        double result = 0;

        switch (op)
        {
            case "+":
                result = first + second;
                break;
            case "-":
                result = first - second;
                break;
            case "*":
                result = first * second;
                break;
            case "/":
                if (second != 0)
                {
                    result = first / second;
                }
                else
                {
                    Console.WriteLine("Error: Division by zero");
                    return double.NaN; // Return NaN for division by zero
                }
                break;
            default:
                Console.WriteLine("Invalid Operator");
                return double.NaN; // Return NaN for invalid operator
        }

        return result;
    }

    static void Main()
    {
        // Get input values from the user
        Console.Write("Enter first number: ");
        double first = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double second = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operator (+, -, *, /): ");
        string op = Console.ReadLine();

        // Run a loop from i = 1 to i < 5 (for demonstration purposes)
        for (int i = 1; i < 5; i++)
        {
            // Call PerformCalculation function to get result
            double result = PerformCalculation(first, second, op);
            
            if (!double.IsNaN(result))
            {
                Console.WriteLine("Result: " + result);
            }
        }
    }
}