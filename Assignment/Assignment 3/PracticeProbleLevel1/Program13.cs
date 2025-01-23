// Class to compute and verify the sum of natural numbers using formula and for loop
using System;
class Program13
{
    public void SumOfNaturalNumbersWithFor()
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

        // Using a for loop to calculate the sum
        for (int i = 1; i <= n; i++)
        {
            sum += i; // Adding the current number to the sum
        }

        // Calculating the sum using the formula
        int formulaSum = n * (n + 1) / 2;

        // Displaying the results
        Console.WriteLine("Sum using for loop: " + sum);
        Console.WriteLine("Sum using formula: " + formulaSum);
    }
}