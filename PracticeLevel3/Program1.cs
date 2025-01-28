using System;

class Program1
{
    static void Main(string[] args)
    {
        // Initialize an array of 11 players with random heights between 150 and 250 cm
        int[] heights = GenerateRandomHeights(11, 150, 250);

        // Display the heights of the players
        Console.WriteLine("Heights of players (in cm): " + string.Join(", ", heights));

        // Call methods to calculate results
        int sum = CalculateSum(heights);
        double mean = CalculateMean(heights);
        int shortest = FindShortestHeight(heights);
        int tallest = FindTallestHeight(heights);

        // Display the results
        Console.WriteLine($"Sum of heights: {sum} cm");
        Console.WriteLine($"Mean height: {mean:F2} cm");
        Console.WriteLine($"Shortest height: {shortest} cm");
        Console.WriteLine($"Tallest height: {tallest} cm");
    }

    // Method to generate an array of random heights
    static int[] GenerateRandomHeights(int size, int min, int max)
    {
        Random random = new Random();
        int[] heights = new int[size];

        for (int i = 0; i < size; i++)
        {
            heights[i] = random.Next(min, max + 1);
        }

        return heights;
    }

    // Method to calculate the sum of all heights
    static int CalculateSum(int[] heights)
    {
        int sum = 0;
        for (int i = 0; i < heights.Length; i++)
        {
            sum += heights[i];
        }
        return sum;
    }

    // Method to calculate the mean height
    static double CalculateMean(int[] heights)
    {
        int sum = CalculateSum(heights);
        return (double)sum / heights.Length;
    }

    // Method to find the shortest height
    static int FindShortestHeight(int[] heights)
    {
        int shortest = heights[0];
        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] < shortest)
            {
                shortest = heights[i];
            }
        }
        return shortest;
    }

    // Method to find the tallest height
    static int FindTallestHeight(int[] heights)
    {
        int tallest = heights[0];
        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > tallest)
            {
                tallest = heights[i];
            }
        }
        return tallest;
    }
}
