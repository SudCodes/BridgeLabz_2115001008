using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "192.168.1.1";
        Console.WriteLine(IsValidIPv4(input) ? "Valid IP Address" : "Invalid IP Address");
    }

    static bool IsValidIPv4(string ip)
    {
        string pattern = @"^((25[0-5]|2[0-4][0-9]|1?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|1?[0-9][0-9]?)$";
        return Regex.IsMatch(ip, pattern);
    }
}
