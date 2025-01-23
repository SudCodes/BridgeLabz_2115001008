// Class to calculate the factorial of a number using for loop
using System;
class Program15
{
    public void FactorialWithFor()
    {
        // Prompting the user to input a number
        Console.Write("Enter a positive integer: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Validating if the input is a positive integer
        if (n < 0)
        {
            Console.WriteLine("The number is not a positive integer.");
            return;
        }

        int factorial = 1; // Variable to store the factorial

        // Using a for loop to calculate the factorial
        for (int i = 1; i <= n; i++)
        {
            factorial *= i; // Multiplying the current number to the factorial
        }

        // Displaying the factorial
        Console.WriteLine("The factorial of " + n + " is: " + factorial);
    }
}