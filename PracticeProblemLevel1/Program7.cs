//Q7. Create a program to save odd and even numbers into odd and even arrays between 1 to the number entered by the user. Finally, print the odd and even numbers array
// Hint => 
// Get an integer input from the user, assign it to a variable number, and check for Natural Number. If not a natural number then print an error and exit the program
// Create an integer array for even and odd numbers with size = number / 2 + 1
// Create index variables for odd and even numbers and initialize them to zero
// Using a for loop, iterate from 1 to the number, and in each iteration of the loop, save the odd or even number into the corresponding array
// Finally, print the odd and even numbers array using the odd and even index

using System;

class Program7
{
    static void Main(string[] args)
    {
        Console.Write("Enter a natural number: ");
        string userInput = Console.ReadLine();

        // Validate input
        if (!int.TryParse(userInput, out int number) || number <= 0)
        {
            Console.Error.WriteLine("Error: Please enter a valid natural number.");
            Environment.Exit(1);
        }

        // Call the sorting function
        SortAndDisplayOddEvenNumbers(number);
    }

    // Function to sort and display odd and even numbers
    static void SortAndDisplayOddEvenNumbers(int number)
    {
        // Arrays to store odd and even numbers
        int[] oddNumbers = new int[number / 2 + 1];
        int[] evenNumbers = new int[number / 2 + 1];

        // Index variables for odd and even arrays
        int oddIndex = 0, evenIndex = 0;

        // Sort numbers into odd and even arrays
        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                evenNumbers[evenIndex++] = i;
            }
            else
            {
                oddNumbers[oddIndex++] = i;
            }
        }

        // Display odd numbers
        Console.WriteLine("\nOdd Numbers:");
        for (int i = 0; i < oddIndex; i++)
        {
            Console.Write(oddNumbers[i] + (i < oddIndex - 1 ? ", " : "\n"));
        }

        // Display even numbers
        Console.WriteLine("\nEven Numbers:");
        for (int i = 0; i < evenIndex; i++)
        {
            Console.Write(evenNumbers[i] + (i < evenIndex - 1 ? ", " : "\n"));
        }
    }
}


