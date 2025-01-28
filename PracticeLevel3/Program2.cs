using System;

class Program2
{
    static void Main(string[] args)
    {
        int number = 153;

        Console.WriteLine($"Number: {number}");
        Console.WriteLine($"Count of digits: {CountDigits(number)}");

        int[] digits = GetDigitsArray(number);
        Console.WriteLine("Digits: " + string.Join(", ", digits));

        Console.WriteLine($"Is Duck Number: {IsDuckNumber(digits)}");
        Console.WriteLine($"Is Armstrong Number: {IsArmstrongNumber(number, digits)}");

        (int largest, int secondLargest) largestResults = FindLargestAndSecondLargest(digits);
        Console.WriteLine($"Largest digit: {largestResults.largest}, Second largest digit: {largestResults.secondLargest}");

        (int smallest, int secondSmallest) smallestResults = FindSmallestAndSecondSmallest(digits);
        Console.WriteLine($"Smallest digit: {smallestResults.smallest}, Second smallest digit: {smallestResults.secondSmallest}");
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

    // Method to check if a number is an Armstrong number
    static bool IsArmstrongNumber(int number, int[] digits)
    {
        int sum = 0;
        int power = digits.Length;

        foreach (int digit in digits)
        {
            sum += (int)Math.Pow(digit, power);
        }

        return sum == number;
    }

    // Method to find the largest and second largest elements
    static (int largest, int secondLargest) FindLargestAndSecondLargest(int[] digits)
    {
        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        foreach (int digit in digits)
        {
            if (digit > largest)
            {
                secondLargest = largest;
                largest = digit;
            }
            else if (digit > secondLargest && digit != largest)
            {
                secondLargest = digit;
            }
        }

        return (largest, secondLargest);
    }

    // Method to find the smallest and second smallest elements
    static (int smallest, int secondSmallest) FindSmallestAndSecondSmallest(int[] digits)
    {
        int smallest = int.MaxValue;
        int secondSmallest = int.MaxValue;

        foreach (int digit in digits)
        {
            if (digit < smallest)
            {
                secondSmallest = smallest;
                smallest = digit;
            }
            else if (digit < secondSmallest && digit != smallest)
            {
                secondSmallest = digit;
            }
        }

        return (smallest, secondSmallest);
    }
}
