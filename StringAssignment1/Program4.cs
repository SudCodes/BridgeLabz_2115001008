/*4. Remove Duplicates from a String
Problem:
Write a C# program to remove all duplicate characters from a given string and return the
modified string.
*/

using System;

class Program4
{
    public static string RemoveDuplicateCharacters(string str)
    {
        char[] result = new char[str.Length];
        int index = 0;

        for (int i = 0; i < str.Length; i++)
        {
            char currentChar = str[i];
            bool isDuplicate = false;

            // Check if the character already exists in result array
            for (int j = 0; j < index; j++)
            {
                if (result[j] == currentChar)
                {
                    isDuplicate = true;
                    break;
                }
            }

            // If not duplicate, add to result array
            if (!isDuplicate)
            {
                result[index++] = currentChar;
            }
        }

        // Convert character array to string manually
        string modifiedString = "";
        for (int i = 0; i < index; i++)
        {
            modifiedString += result[i];
        }

        return modifiedString;
    }

    public static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine() ?? "";
        
        string result = RemoveDuplicateCharacters(input);
        
        Console.WriteLine($"Modified String without duplicates: {result}");
    }
}
