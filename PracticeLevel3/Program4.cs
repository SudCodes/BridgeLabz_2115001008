using System;

class Program4
{
    static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Number: {number}");
        Console.WriteLine($"Count of digits: {CountDigits(number)}");

        int[] digits = GetDigitsArray(number);
        Console.WriteLine("Digits: " + string.Join(", ", digits));

        int[] reversedDigits = ReverseDigitsArray(digits);
        Console.WriteLine("Reversed Digits: " + string.Join(", ", reversedDigits));

        Console.WriteLine($"Are original and reversed arrays equal: {AreArraysEqual(digits, reversedDigits)}");
        Console.WriteLine($"Is Palindrome: {IsPalindrome(digits)}");
        Console.WriteLine($"Is Duck Number: {IsDuckNumber(digits)}");
    }

    // Method to count digits in the number
    static int CountDigits(int number)
    {
        int count = 0;
        while (number > 0)
        {
            count++;
            number /= 10;
        }
        return count;
    }

    // Method to get digits array from the number
    static int[] GetDigitsArray(int number)
    {
        int count = CountDigits(number);
        int[] digits = new int[count];

        for (int i = count - 1; i >= 0; i--)
        {
            digits[i] = number % 10;
            number /= 10;
        }

        return digits;
    }

    // Method to reverse the digits array
    static int[] ReverseDigitsArray(int[] digits)
    {
        int[] reversed = new int[digits.Length];
        for (int i = 0; i < digits.Length; i++)
        {
            reversed[i] = digits[digits.Length - 1 - i];
        }
        return reversed;
    }

    // Method to compare two arrays
    static bool AreArraysEqual(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length)
        {
            return false;
        }

        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] != array2[i])
            {
                return false;
            }
        }

        return true;
    }

    // Method to check if a number is a palindrome
    static bool IsPalindrome(int[] digits)
    {
        int[] reversedDigits = ReverseDigitsArray(digits);
        return AreArraysEqual(digits, reversedDigits);
    }

    // Method to check if a number is a duck number
    static bool IsDuckNumber(int[] digits)
    {
        for (int i = 1; i < digits.Length; i++) // Ignore the first digit
        {
            if (digits[i] == 0)
            {
                return true;
            }
        }
        return false;
    }
}
