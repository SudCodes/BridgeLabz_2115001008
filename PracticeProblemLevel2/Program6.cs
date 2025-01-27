//Q6. An organization took up an exercise to find the Body Mass Index (BMI) of all the persons in the team. For this create a program to find the BMI and display the height, weight, BMI and status of each individual
// Hint => 
// Take input for a number of persons
// Create arrays to store the weight, height, BMI, and weight status of the persons
// Take input for the weight and height of the persons
// Calculate the BMI of all the persons and store them in an array and also find the weight status of the persons
// Display the height, weight, BMI, and weight status of each person
// Use the table to determine the weight status of the person

using System;

class Program6
{
    // Function to calculate BMI and determine weight status
    static void CalculateBMI(int numberOfPeople, double[] weights, double[] heights, double[] bmis, string[] status)
    {
        for (int i = 0; i < numberOfPeople; i++)
        {
            // BMI calculation: BMI = weight (kg) / height (m)^2
            bmis[i] = weights[i] / (heights[i] * heights[i]);

            // Determine weight status based on BMI
            if (bmis[i] < 18.5)
                status[i] = "Underweight";
            else if (bmis[i] >= 18.5 && bmis[i] < 24.9)
                status[i] = "Normal weight";
            else if (bmis[i] >= 25 && bmis[i] < 29.9)
                status[i] = "Overweight";
            else
                status[i] = "Obese";
        }
    }

    static void Main()
    {
        // Take input for the number of persons
        Console.Write("Enter the number of persons: ");
        int numberOfPeople = Convert.ToInt32(Console.ReadLine());

        // Create arrays to store the weight, height, BMI, and status
        double[] weights = new double[numberOfPeople];
        double[] heights = new double[numberOfPeople];
        double[] bmis = new double[numberOfPeople];
        string[] status = new string[numberOfPeople];

        // Take input for weight and height of each person
        for (int i = 0; i < numberOfPeople; i++)
        {
            Console.WriteLine($"\nEnter details for person {i + 1}:");

            Console.Write("Enter weight (in kg): ");
            weights[i] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height (in meters): ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Call the function to calculate BMI and determine weight status
        CalculateBMI(numberOfPeople, weights, heights, bmis, status);

        // Display the results for each person
        Console.WriteLine("\nDetails of persons:");
        Console.WriteLine("Person | Height (m) | Weight (kg) | BMI    | Weight Status");

        for (int i = 0; i < numberOfPeople; i++)
        {
            Console.WriteLine($"{i + 1,6} | {heights[i],10:F2} | {weights[i],12:F2} | {bmis[i],6:F2} | {status[i]}");
        }
    }
}

