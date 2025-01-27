//Q10. Create a program to take a number as input find the frequency of each digit in the number using an array and display the frequency of each digit
// Hint => 
// Take the input for a number
// Find the count of digits in the number
// Find the digits in the number and save them in an array
// Find the frequency of each digit in the number. For this define a frequency array of size 10, Loop through the digits array, and increase the frequency of each digit
// Display the frequency of each digit in the number


using System;

class Program10
{
    // Function to calculate the frequency of each digit
    static int[] CalculateDigitFrequency(int number)
    {
        int[] frequency = new int[10]; // Array to store frequencies of digits 0-9

        while (number > 0)
        {
            int digit = number % 10; // Extract the last digit
            frequency[digit]++; // Increment the frequency of the digit
            number /= 10; // Remove the last digit
        }

        return frequency;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine("Please enter a positive number.");
            return;
        }

        int[] digitFrequency = CalculateDigitFrequency(number);

        Console.WriteLine("\nDigit Frequency:");
        for (int i = 0; i < digitFrequency.Length; i++)
        {
            if (digitFrequency[i] > 0)
            {
                Console.WriteLine($"Digit {i}: {digitFrequency[i]}");
            }
        }
    }
}