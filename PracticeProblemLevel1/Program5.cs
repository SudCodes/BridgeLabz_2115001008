//Q5. Create a program to find the multiplication table of a number entered by the user from 6 to 9 and display the result
// Hint => 
// Take integer input and store it in the variable number as well as define an integer array to store the multiplication result in the variable multiplicationResult
// Using a for loop, find the multiplication table of numbers from 6 to 9 and save the result in the array
// Finally, display the result from the array in the format number * i = ___


using System;

class Program5
{
    static void Main(string[] args)
    {
        // Ask user for input
        Console.Write("Enter a number to generate its multiplication table (6 to 9): ");
        string userInput = Console.ReadLine();

        // Validate input
        if (!int.TryParse(userInput, out int number) || number < 6 || number > 9)
        {
            Console.Error.WriteLine("Error: Please enter a valid number between 6 and 9.");
            Environment.Exit(1);
        }

        // Array to store multiplication results
        int[] multiplicationResult = new int[10];

        // Generate the multiplication table
        for (int i = 0; i < multiplicationResult.Length; i++)
        {
            multiplicationResult[i] = number * (i + 1);
        }

        // Display the multiplication table
        Console.WriteLine($"\nMultiplication Table for {number}:");
        for (int i = 0; i < multiplicationResult.Length; i++)
        {
            Console.WriteLine($"{number} * {i + 1} = {multiplicationResult[i]}");
        }
    }
}
