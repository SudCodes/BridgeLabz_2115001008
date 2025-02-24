using System;
using System.Text.RegularExpressions;

class Program
{
    static bool IsValidHexColor(string color)
    {
        return Regex.IsMatch(color, "^#([0-9A-Fa-f]{6})$");
    }

    static void Main()
    {
        string[] testCases = { "#FFA500", "#ff4500", "#123", "#GHIJKL", "#abcdef" };

        foreach (var color in testCases)
        {
            Console.WriteLine($"{color} → {(IsValidHexColor(color) ? "Valid" : "Invalid")}");
        }
    }
}
