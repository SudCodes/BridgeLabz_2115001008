//Q6. Create a program to find the mean height of players present in a football team.
// Hint => 
// The formula to calculate the mean is: mean = sum of all elements / number of elements
// Create a double array named heights of size 11 and get input values from the user.
// Find the sum of all the elements present in the array.
// Divide the sum by 11 to find the mean height and print the mean height of the football team


using System;
class Program6
{
    static void Main(string[] args)
    {
        // Array to store the heights of 11 players
        double[] heights = new double[11];
        double sum = 0.0;

        Console.WriteLine("Enter the heights of 11 players:");

        // Collect heights from the user
        for (int i = 0; i < heights.Length; i++)
        {
            Console.Write($"Enter height for player {i + 1}: ");
            string userInput = Console.ReadLine();

            // Validate input
            if (!double.TryParse(userInput, out heights[i]) || heights[i] <= 0)
            {
                Console.Error.WriteLine("Error: Please enter a valid positive height value.");
                Environment.Exit(1);
            }

            // Add the height to the sum
            sum += heights[i];
        }

        // Calculate the mean height
        double mean = sum / heights.Length;

        // Display the mean height
        Console.WriteLine($"\nThe mean height of the football team is: {mean:F2} meters");
    }
}
