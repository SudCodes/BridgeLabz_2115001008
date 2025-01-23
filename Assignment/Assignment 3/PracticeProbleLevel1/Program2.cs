// Creating Class with name Program2 to check if the first number is the smallest
using System;
class Program2
{
    public static string IsFirstSmallest(int number1, int number2, int number3)
    {
        // Check if the first number is the smallest
        bool isSmallest = number1 < number2 && number1 < number3;

        // Return the result
        return $"Is the first number the smallest? {isSmallest}";
    }
}