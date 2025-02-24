using System;
using System.Text.RegularExpressions;

class CapitalizedWordsExtractor
{
    static void ExtractCapitalizedWords(string text)
    {
        MatchCollection matches = Regex.Matches(text, @"\b[A-Z][a-z]*\b");

        foreach (Match match in matches)
        {
            Console.Write(match.Value + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        string capitalizedText = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";
        ExtractCapitalizedWords(capitalizedText);
    }
}
