// Creating Class with name Program4 to calculate the sum of n natural numbers
using System;
class Program4
{
    public static string CalculateSumOfNaturalNumbers(int number)
    {
        if (number <= 0)
        {
            return $"The number {number} is not a natural number.";
        }

        // Calculate sum using formula
        int sum = number * (number + 1) / 2;

        // Return the result
        return $"The sum of {number} natural numbers is {sum}";
    }
}