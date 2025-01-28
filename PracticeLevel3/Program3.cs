using System;

class Program3
{
    static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Number: {number}");
        Console.WriteLine($"Count of digits: {CountDigits(number)}");

        int[] digits = GetDigitsArray(number);
        Console.WriteLine("Digits: " + string.Join(", ", digits));

        Console.WriteLine($"Sum of digits: {SumOfDigits(digits)}");
        Console.WriteLine($"Sum of squares of digits: {SumOfSquaresOfDigits(digits)}");
        Console.WriteLine($"Is Harshad Number: {IsHarshadNumber(number, digits)}");

        int[,] frequency = GetDigitFrequency(digits);
        Console.WriteLine("Digit Frequency:");
        for (int i = 0; i < frequency.GetLength(0); i++)
        {
            Console.WriteLine($"Digit: {frequency[i, 0]}, Frequency: {frequency[i, 1]}");
        }
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

    // Method to find the sum of digits
    static int SumOfDigits(int[] digits)
    {
        int sum = 0;
        foreach (int digit in digits)
        {
            sum += digit;
        }
        return sum;
    }

    // Method to find the sum of squares of digits
    static int SumOfSquaresOfDigits(int[] digits)
    {
        int sum = 0;
        foreach (int digit in digits)
        {
            sum += (int)Math.Pow(digit, 2);
        }
        return sum;
    }

    // Method to check if a number is a Harshad number
    static bool IsHarshadNumber(int number, int[] digits)
    {
        int sumOfDigits = SumOfDigits(digits);
        return number % sumOfDigits == 0;
    }

    // Method to find the frequency of each digit in the number
    static int[,] GetDigitFrequency(int[] digits)
    {
        int[,] frequency = new int[10, 2];

        for (int i = 0; i < 10; i++)
        {
            frequency[i, 0] = i; // Digit
            frequency[i, 1] = 0; // Frequency
        }

        foreach (int digit in digits)
        {
            frequency[digit, 1]++;
        }

        // Count non-zero frequencies only
        int nonZeroCount = 0;
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i, 1] > 0)
            {
                nonZeroCount++;
            }
        }

        int[,] result = new int[nonZeroCount, 2];
        int index = 0;
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i, 1] > 0)
            {
                result[index, 0] = frequency[i, 0];
                result[index, 1] = frequency[i, 1];
                index++;
            }
        }

        return result;
    }
}
