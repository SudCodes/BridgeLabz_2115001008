using System;
using System.Text.RegularExpressions;

class Program
{
    static void ExtractEmails(string text)
    {
        MatchCollection matches = Regex.Matches(text, @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}");

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }

    static void Main()
    {
        string text = "Contact us at support@example.com and info@company.org";
        ExtractEmails(text);
    }
}
