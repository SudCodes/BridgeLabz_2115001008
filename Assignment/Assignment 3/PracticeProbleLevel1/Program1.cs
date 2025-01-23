// Creating Class with name Program1 to check if a number is divisible by 5
using System;

class Program1
{
    public static string CheckDivisibilityByFive(int number)
    {
        // Check if the number is divisible by 5
        bool isDivisible = number % 5 == 0;

        // Return the result
        return $"Is the number {number} divisible by 5? {isDivisible}";
    }
}