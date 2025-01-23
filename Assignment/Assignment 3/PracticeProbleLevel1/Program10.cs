// Class to calculate the sum of numbers until the user enters 0
using System;
class Program10
{
    public void SumUntilZero()
    {
        double total = 0; // Initializing the total sum variable
        double userInput; // Variable to hold user input

        // Prompting the user to input numbers
        Console.WriteLine("Enter numbers to sum (0 to stop):");

        // Using a while loop to sum the numbers until 0 is entered
        while (true)
        {
            userInput = Convert.ToDouble(Console.ReadLine()); // Reading user input
            if (userInput == 0)
            {
                break; // Exiting the loop if input is 0
            }

            total += userInput; // Adding the input to the total sum
        }

        // Displaying the total sum
        Console.WriteLine("The total sum is: " + total);
    }
}