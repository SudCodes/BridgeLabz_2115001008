//Q8. Create a program to find the factors of a number taken as user input, store the factors in an array, and display the factors
// Hint => 
// Take the input for a number
// Find the factors of the number and save them in an array. For this create integer variable maxFactor and initialize to 10, factors array of size maxFactor and index variable to reflect the index of the array. 
// To find factors loop through the numbers from 1 to the number, find the factors, and add them to the array element by incrementing the index. If the index is equal to maxIndex, then need factors array to store more elements
// To store more elements, reset the maxIndex to twice its size, use the temp array to store the elements from the factors array, and eventually assign the factors array to the temp array
// Finally, Display the factors of the number

using System;
class Program8
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number to find its factors: ");
        string userInput = Console.ReadLine();

        // Validate input
        if (!int.TryParse(userInput, out int number) || number <= 0)
        {
            Console.Error.WriteLine("Error: Please enter a valid positive number.");
            Environment.Exit(1);
        }

        // Call the function to find and display factors
        FindAndDisplayFactors(number);
    }

    // Function to find and display factors of a number
    static void FindAndDisplayFactors(int number)
    {
        int maxFactor = 10; // Initial size of the factors array
        int[] factors = new int[maxFactor];
        int index = 0; // Index to track the position in the factors array

        // Find factors of the number
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                // Resize the array if needed
                if (index == maxFactor)
                {
                    maxFactor *= 2;
                    int[] temp = new int[maxFactor];
                    Array.Copy(factors, temp, factors.Length);
                    factors = temp;
                }

                factors[index++] = i;
            }
        }

        // Display the factors
        Console.WriteLine($"\nFactors of {number}:");
        for (int i = 0; i < index; i++)
        {
            Console.Write(factors[i] + (i < index - 1 ? ", " : "\n"));
        }
    }
}

