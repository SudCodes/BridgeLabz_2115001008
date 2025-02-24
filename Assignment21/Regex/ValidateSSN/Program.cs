using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "My SSN is 123-45-6789.";
        Console.WriteLine(ValidateSSN(input));
    }

    static string ValidateSSN(string text)
    {
        string pattern = @"\b\d{3}-\d{2}-\d{4}\b";
        Match match = Regex.Match(text, pattern);

        if (match.Success)
        {
            return $"\"{match.Value}\" is valid";
        }
        else
        {
            return "No valid SSN found";
        }
    }
}
