using System;

class Program8
{
    public static void Main()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine() ?? "";

        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine() ?? "";

        int result = CompareLexicographically(str1, str2);

        if (result < 0)
            Console.WriteLine($"\"{str1}\" comes before \"{str2}\" in lexicographical order.");
        else if (result > 0)
            Console.WriteLine($"\"{str1}\" comes after \"{str2}\" in lexicographical order.");
        else
            Console.WriteLine($"\"{str1}\" is equal to \"{str2}\".");
    }

    // Method to compare two strings lexicographically without using built-in functions
    public static int CompareLexicographically(string str1, string str2)
    {
        int length1 = 0, length2 = 0;

        // Find lengths manually
        while (length1 < str1.Length) length1++;
        while (length2 < str2.Length) length2++;

        int minLength = length1 < length2 ? length1 : length2;

        // Compare characters one by one
        for (int i = 0; i < minLength; i++)
        {
            if (str1[i] < str2[i]) return -1; // str1 comes before str2
            if (str1[i] > str2[i]) return 1;  // str1 comes after str2
        }

        // If all characters are equal, compare lengths
        if (length1 < length2) return -1; // Shorter string comes first
        if (length1 > length2) return 1;  // Longer string comes later

        return 0; // Both strings are equal
    }
}
