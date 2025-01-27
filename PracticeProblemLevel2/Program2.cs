// Q2. Create a program to find the youngest friends among 3 Amar, Akbar, and Anthony based on their ages and the tallest among the friends based on their heights
// Hint => 
// Take user input for age and height for the 3 friends and store it in two arrays each to store the values for age and height of the 3 friends
// Loop through the array and find the youngest of the 3 friends and the tallest of the 3 friends
// Finally display the youngest and tallest of the 3 friends

using System;

class Program2
{
    // Function to find the youngest and tallest among friends
    static void FindYoungestAndTallest(string[] names, int[] ages, double[] heights, out string youngest, out string tallest)
    {
        int minAgeIndex = 0; // To track the index of the youngest
        int maxHeightIndex = 0; // To track the index of the tallest

        // Loop through the arrays to find the youngest and tallest
        for (int i = 1; i < 3; i++)
        {
            if (ages[i] < ages[minAgeIndex])
            {
                minAgeIndex = i; // Update youngest if found smaller age
            }

            if (heights[i] > heights[maxHeightIndex])
            {
                maxHeightIndex = i; // Update tallest if found greater height
            }
        }

        // Assign the names of the youngest and tallest friends
        youngest = names[minAgeIndex];
        tallest = names[maxHeightIndex];
    }

    static void Main()
    {
        // Names of the friends
        string[] names = { "Amar", "Akbar", "Anthony" };

        // Arrays to store ages and heights
        int[] ages = new int[3];
        double[] heights = new double[3];

        // Loop to take input for age and height
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Enter the age of {names[i]}: ");
            ages[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Enter the height of {names[i]} in meters: ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Call the function to find the youngest and tallest
        string youngest, tallest;
        FindYoungestAndTallest(names, ages, heights, out youngest, out tallest);

        // Display the results
        Console.WriteLine($"\nThe youngest friend is: {youngest}");
        Console.WriteLine($"The tallest friend is: {tallest}");
    }
}
