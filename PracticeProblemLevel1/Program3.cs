// Q3. Create a program to print a multiplication table of a number.
// Hint => 
// Get an integer input and store it in the number variable. Also, define a integer array to store the results of multiplication 
// from 1 to 10
// Run a loop from 1 to 10 and store the results in the multiplication table array
// Finally, display the result from the array in the format number * i = ___

using System;

class Program3
{
    static void Main(string[] args)
    {
        // ask user for input
        Console.Write("Enter a number to generate its multiplication table: ");
        string userInput = Console.ReadLine();

        // Validate input
        if (!int.TryParse(userInput, out int number))
        {
            Console.Error.WriteLine("Error: Please input a valid integer.");
            Environment.Exit(1);
        }

        // Array to store multiplication table results
        int[] multiplicationTable = new int[10];

        // Generate the multiplication table
        GenerateMultiplicationTable(number, multiplicationTable);

        // Display the multiplication table
        DisplayMultiplicationTable(number, multiplicationTable);
    }

    // Method to generate the multiplication table
    static void GenerateMultiplicationTable(int number, int[] table)
    {
        for (int i = 0; i < table.Length; i++)
        {
            table[i] = number * (i + 1);
        }
    }

    // Method to display the multiplication table
    static void DisplayMultiplicationTable(int number, int[] table)
    {
        Console.WriteLine($"\nMultiplication Table for {number}:");

        for (int i = 0; i < table.Length; i++)
        {
            Console.WriteLine($"{number} * {i + 1} = {table[i]}");
        }
    }
}
