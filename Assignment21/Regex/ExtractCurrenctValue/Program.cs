using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "The price is $45.99, and the discount is $ 10.50.";
        Console.WriteLine(ExtractCurrencyValues(input));
    }

    static string ExtractCurrencyValues(string text)
    {
        string pattern = @"\$\s*\d+\.\d{2}";
        MatchCollection matches = Regex.Matches(text, pattern);
        return string.Join(", ", matches);
    }
}