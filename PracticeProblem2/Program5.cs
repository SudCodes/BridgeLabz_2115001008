using System;

class Program5
{
    public static void Main()
    {
        // Get input from user
        string input = GetInput();
        
        // Check if the input is a palindrome
        bool isPalindrome = CheckPalindrome(input);
        
        // Display the result
        DisplayResult(input, isPalindrome);
    }

    // Function to get input from user
    public static string GetInput()
    {
        Console.Write("Enter a word or phrase: ");
        return Console.ReadLine();
    }

    // Function to check if the string is a palindrome
    public static bool CheckPalindrome(string text)
    {
        text = text.Replace(" ", "").ToLower();
        char[] charArray = text.ToCharArray();
        Array.Reverse(charArray);
        return text == new string(charArray);
    }

    // Function to display the result
    public static void DisplayResult(string input, bool isPalindrome)
    {
        if (isPalindrome)
            Console.WriteLine("Number is a palindrome.");
        else
            Console.WriteLine("Number is not a palindrome.");
    }
}
