using System;

class Program6
{
    public static void Main()
    {
        // Get user input
        int number = GetInput();
        
        // Calculate factorial using recursion
        long result = CalculateFactorial(number);
        
        // Display the result
        DisplayResult(number, result);
    }

    // Function to get input from user
    public static int GetInput()
    {
        Console.Write("Enter a number: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    // Recursive function to calculate factorial
    public static long CalculateFactorial(int num)
    {
        if (num <= 1)
            return 1;
        return num * CalculateFactorial(num - 1);
    }

    // Function to display the result
    public static void DisplayResult(int number, long result)
    {
        Console.WriteLine("Factorial of " + number + " is: " + result);
    }
}
