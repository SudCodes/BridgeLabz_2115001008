// Class to compute and verify the sum of natural numbers using formula and while loop
using System;
class Program12
{
    public void SumOfNaturalNumbersWithWhile()
    {
        // Prompting the user to input a number
        Console.Write("Enter a positive integer: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Validating if the input is a natural number
        if (n <= 0)
        {
            Console.WriteLine("The number is not a natural number.");
            return;
        }

        int sum = 0; // Variable to store the sum
        int i = 1; // Counter variable for the while loop
        // Using a while loop to calculate the sum
        while (i <= n)
        {
            sum += i; // Adding the current number to the sum
            i++; // Incrementing the counter
        }

        // Calculating the sum using the formula
        int formulaSum = n * (n + 1) / 2;

        // Displaying the results
        Console.WriteLine("Sum using while loop: " + sum);
        Console.WriteLine("Sum using formula: " + formulaSum);
    }
}