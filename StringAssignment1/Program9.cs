using System;

class Program9
{
    public static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine() ?? "";

        char mostFrequentChar = FindMostFrequentChar(input);
        Console.WriteLine($"Most Frequent Character: '{mostFrequentChar}'");
    }

    // Method to find the most frequent character without using built-in functions
    public static char FindMostFrequentChar(string str)
    {
        int[] frequency = new int[256]; // Array to store frequency of each ASCII character
        int maxCount = 0;
        char mostFrequent = '\0';

        // Count occurrences of each character
        for (int i = 0; i < str.Length; i++)
        {
            char c = str[i];
            int index = (int)c; // Convert char to ASCII index
            frequency[index]++;

            // Update most frequent character
            if (frequency[index] > maxCount)
            {
                maxCount = frequency[index];
                mostFrequent = c;
            }
        }

        return mostFrequent;
    }
}
