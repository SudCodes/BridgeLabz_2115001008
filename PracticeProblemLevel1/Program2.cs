// Q2. Write a program to take user input for 5 numbers and check whether a number is positive,  negative, or zero. Further for positive
//  numbers check if the number is even or odd. Finally compare the first and last elements of the array and display if they equal, 
// greater or less
// Hint => 
// Define an integer array of 5 elements and get user input to store in the array.
// Loop through the array using the length If the number is positive, check for even or odd numbers and print accordingly
// If the number is negative, print negative. Else if the number is zero, print zero. 
// Finally compare the first and last element of the array and display if they equal, greater or less


using System;

class Program2
{
    static void Main(string[] args)
    {
        // Array to hold 5 numbers
        int[] numbers = new int[5];

        // Collect numbers from the user
        CollectNumbers(numbers);

        // Analyze the numbers
        AnalyzeNumbers(numbers);

        // Compare the first and last elements
        CompareFirstAndLast(numbers);
    }

    // Method to collect numbers from user input
    static void CollectNumbers(int[] numbers)
    {
        Console.WriteLine("Please enter 5 numbers:");

        for (int idx = 0; idx < numbers.Length; idx++)
        {
            Console.Write($"Enter number {idx + 1}: ");
            string userInput = Console.ReadLine();

            // Validate input
            if (!int.TryParse(userInput, out numbers[idx]))
            {
                Console.Error.WriteLine("Error: Please input a valid integer.");
                Environment.Exit(1);
            }
        }
    }

    // Method to analyze each number for positivity and parity
    static void AnalyzeNumbers(int[] numbers)
    {
        Console.WriteLine("\nNumber Analysis Results:");

        foreach (int number in numbers)
        {
            if (number > 0)
            {
                Console.WriteLine($"{number} is positive and {(number % 2 == 0 ? "even" : "odd")}.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"{number} is negative.");
            }
            else
            {
                Console.WriteLine("0 is zero.");
            }
        }
    }

    // Method to compare the first and last elements of the array
    static void CompareFirstAndLast(int[] numbers)
    {
        Console.WriteLine("\nComparison of First and Last Elements:");

        if (numbers[0] > numbers[^1])
        {
            Console.WriteLine("The first element is greater than the last element.");
        }
        else if (numbers[0] < numbers[^1])
        {
            Console.WriteLine("The first element is less than the last element.");
        }
        else
        {
            Console.WriteLine("The first and last elements are equal.");
        }
    }
}
