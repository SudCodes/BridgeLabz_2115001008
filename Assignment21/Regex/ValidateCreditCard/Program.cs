using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "4111111111111111";
        Console.WriteLine(IsValidCreditCard(input) ? "Valid Credit Card Number" : "Invalid Credit Card Number");
    }

    static bool IsValidCreditCard(string cardNumber)
    {
        string pattern = @"^(4\d{15}|5[1-5]\d{14})$";
        return Regex.IsMatch(cardNumber, pattern);
    }
}
