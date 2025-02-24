using System;
using System.Text.RegularExpressions;

public class LicensePlateValidator
{
    public static bool IsValidLicensePlate(string plate)
    {
        string pattern = "^[A-Z]{2}\\d{4}$";
        return Regex.IsMatch(plate, pattern);
    }
}
