// Class to calculate the factorial of a number using while loop
using System;
class Program14
{
    public void FactorialWithWhile()
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
        int i = 1; // Counter variable for the while loop

        // Using a while loop to calculate the factorial
        while (i <= n)
        {
            factorial *= i; // Multiplying the current number to the factorial
            i++; // Incrementing the counter
        }

        // Displaying the factorial
        Console.WriteLine("The factorial of " + n + " is: " + factorial);
    }
}