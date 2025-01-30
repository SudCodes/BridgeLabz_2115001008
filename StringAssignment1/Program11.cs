using System;

class Program11
{
    public static void Main()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine() ?? "";

        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine() ?? "";

        bool result = AreAnagrams(str1, str2);
        
        if (result)
            Console.WriteLine("The strings are anagrams.");
        else
            Console.WriteLine("The strings are NOT anagrams.");
    }

    // Method to check if two strings are anagrams without built-in sorting
    public static bool AreAnagrams(string str1, string str2)
    {
        int length1 = str1.Length, length2 = str2.Length;


        // If lengths are different, they cannot be anagrams
        if (length1 != length2)
            return false;

        // Create frequency arrays for both strings
        int[] count1 = new int[256];
        int[] count2 = new int[256];

        // Count frequency of each character
        for (int i = 0; i < length1; i++)
        {
            count1[(int)str1[i]]++;
            count2[(int)str2[i]]++;
        }

        // Compare frequency arrays
        for (int i = 0; i < 256; i++)
        {
            if (count1[i] != count2[i])
                return false;
        }

        return true;
    }
}
