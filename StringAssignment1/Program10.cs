using System;

class Program10
{
    public static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine() ?? "";

        Console.Write("Enter the character to remove: ");
        char charToRemove = Console.ReadLine()[0]; // Read the first character

        string result = RemoveSpecificCharacter(input, charToRemove);
        Console.WriteLine($"Modified String: \"{result}\"");
    }

    // Method to remove all occurrences of a specific character without built-in functions
    public static string RemoveSpecificCharacter(string str, char charToRemove)
    {
        char[] resultArray = new char[str.Length];
        int index = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] != charToRemove) // Only add characters that are not the target
            {
                resultArray[index] = str[i];
                index++;
            }
        }

        // Construct the final string manually
        string modifiedString = "";
        for (int i = 0; i < index; i++)
        {
            modifiedString += resultArray[i];
        }

        return modifiedString;
    }
}
