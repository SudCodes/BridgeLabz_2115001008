using System;
using System.Text.RegularExpressions;

class LinkExtractor
{
    static void ExtractLinks(string text)
    {
        MatchCollection matches = Regex.Matches(text, @"\bhttps?://[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}[^\s]*");

        foreach (Match match in matches)
        {
            Console.Write(match.Value + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        string linkText = "Visit https://www.google.com and http://example.org for more info.";
        ExtractLinks(linkText);
    }
}
