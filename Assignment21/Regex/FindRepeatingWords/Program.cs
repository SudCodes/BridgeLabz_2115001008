using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "This is is a repeated repeated word test.";
        Console.WriteLine(FindRepeatingWords(input));
    }

    static string FindRepeatingWords(string text)
    {
        string pattern = @"\b(\w+)\b(?=.*\b\1\b)";
        MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);
        HashSet<string> uniqueWords = new HashSet<string>();

        foreach (Match match in matches)
        {
            uniqueWords.Add(match.Value);
        }

        return string.Join(", ", uniqueWords);
    }
}
