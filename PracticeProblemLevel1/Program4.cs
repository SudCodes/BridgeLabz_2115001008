// Q4. Write a program to store multiple values in an array up to a maximum of 10 or until the user enters a 0 or a negative number. Show all the numbers as well as the sum of all numbers 
// Hint => 
// Create a variable to store an array of 10 elements of type double as well as a variable to store the total of type double initializes to 0.0. Also, the index variable is initialized to 0 for the array
// Use infinite while loop as in while (true)
// Take the user entry and check if the user entered 0 or a negative number to break the loop 
// Also, break from the loop if the index has a value of 10 as the array size is limited to 10.
// If the user entered a number other than 0 or a negative number inside the while loop then assign the number to the array element and increment the index value
// Take another for loop to get the values of each element and add it to the total 
// Finally display the total value


using System;
class Program4
{
    static void Main(string[] args)
    {
        // Array to store numbers, maximum size is 10
        double[] numbers = new double[10];

        // Variables to store the total and the current index
        double total = 0.0;
        int index = 0;

        Console.WriteLine("Enter numbers (up to 10). Enter 0 or a negative number to stop:");

        // Infinite loop to take user input
        while (true)
        {
            Console.Write($"Enter number {index + 1}: ");
            string input = Console.ReadLine();

            // Validate input
            if (!double.TryParse(input, out double number))
            {
                Console.Error.WriteLine("Error: Please input a valid number.");
                continue;
            }

            // Check for termination condition
            if (number <= 0 || index >= 10)
            {
                break;
            }

            // Store the number in the array and increment the index
            numbers[index] = number;
            index++;
        }

        // Calculate the total
        for (int i = 0; i < index; i++)
        {
            total += numbers[i];
        }

        // Display the entered numbers
        Console.WriteLine("\nNumbers Entered:");
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        // Display the total
        Console.WriteLine($"\nTotal Sum: {total}");
    }
}

