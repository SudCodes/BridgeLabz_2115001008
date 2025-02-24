using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";
        Console.WriteLine(ExtractLanguages(input));
    }

    static string ExtractLanguages(string text)
    {
        string pattern = "\\b(JavaScript|Java|Python|Go|C#|C|Ruby|Swift|Kotlin)\\b";
        MatchCollection matches = Regex.Matches(text, pattern);
        return string.Join(", ", matches);
    }
}
