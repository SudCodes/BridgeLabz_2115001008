using System;
using System.Text.RegularExpressions;

class DateExtractor
{
    static void ExtractDates(string text)
    {
        MatchCollection matches = Regex.Matches(text, @"\b(\d{2}/\d{2}/\d{4})\b");

        foreach (Match match in matches)
        {
            Console.Write(match.Value + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        string dateText = "The events are scheduled for 12/05/2023, 15/08/2024, and 29/02/2020.";
        ExtractDates(dateText);
    }
}
