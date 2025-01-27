//Q10. Write a program FizzBuzz, take a number as user input and if it is a positive integer loop from 0 to the number and save the number, but for multiples of 3 save "Fizz" instead of the number, for multiples of 5 save "Buzz", and for multiples of both save "FizzBuzz". Finally, print the array results for each index position in the format Position 1 = 1, …, Position 3 = Fizz,...
// Hint => 
// Create a String Array to save the results and 
// Finally, loop again to show the results of the array based on the index position

using System;

class Program10
{
    // Function to solve the FizzBuzz problem
    static string[] FizzBuzz(int n)
    {
        string[] results = new string[n + 1]; // Array to store the results

        for (int i = 0; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                results[i] = "FizzBuzz"; // Multiple of both 3 and 5
            else if (i % 3 == 0)
                results[i] = "Fizz"; // Multiple of 3
            else if (i % 5 == 0)
                results[i] = "Buzz"; // Multiple of 5
            else
                results[i] = i.ToString(); // Not a multiple of 3 or 5, save the number itself
        }

        return results;
    }

    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        int number;
        
        // Ensure valid input
        if (int.TryParse(Console.ReadLine(), out number) && number > 0)
        {
            string[] fizzBuzzResults = FizzBuzz(number);

            // Loop to print the results in the required format
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine($"Position {i} = {fizzBuzzResults[i]}");
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid positive integer.");
        }
    }
}

