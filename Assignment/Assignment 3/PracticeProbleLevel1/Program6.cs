// Creating Class with name Program6 to check if a number is positive, negative, or zero
using System;
class Program6
{
    public static string CheckNumberType(int number)
    {
        // Check if number is positive, negative, or zero
        if (number > 0) return "The number is positive.";
        if (number < 0) return "The number is negative.";
        return "The number is zero.";
    }
}