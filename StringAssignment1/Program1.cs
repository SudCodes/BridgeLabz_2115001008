using System;

class Program1
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the string: ");
        string str = Console.ReadLine() ?? "";

        Console.WriteLine($"No. of vowels in string are: {VowelsInString(str)} \nNo. of consonants in string are: {ConsonantsInString(str)}");
    }

    // Method to count vowels in string without using any built-in functions
    public static int VowelsInString(string str)
    {
        int noOfVowels = 0;
        for (int i = 0; i < str.Length; i++)
        {
            char c = str[i];

            // Manually checking for vowels (both uppercase and lowercase)
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
            {
                noOfVowels++;
            }
        }
        return noOfVowels;
    }

    // Method to count consonants in string without using any built-in functions
    public static int ConsonantsInString(string str)
    {
        int noOfConsonants = 0;
        for (int i = 0; i < str.Length; i++)
        {
            char c = str[i];

            // Check if the character is a letter (A-Z or a-z)
            if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
            {
                // If it's not a vowel, it's a consonant
                if (!(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                      c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U'))
                {
                    noOfConsonants++;
                }
            }
        }
        return noOfConsonants;
    }
}
