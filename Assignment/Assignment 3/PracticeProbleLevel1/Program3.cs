// Creating Class with name Program3 to find the largest among three numbers
using System;
class Program3
{
    public static string FindLargestNumber(int number1, int number2, int number3)
    {
        // Check for the largest number
        string result = $"Is the first number the largest? {number1 > number2 && number1 > number3}\n" +
                        $"Is the second number the largest? {number2 > number1 && number2 > number3}\n" +
                        $"Is the third number the largest? {number3 > number1 && number3 > number2}";

        // Return the result
        return result;
    }
}