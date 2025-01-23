using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number to check if it is a Harshad Number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsHarshadNumber(number))
        {
            Console.WriteLine($"{number} is a Harshad Number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a Harshad Number.");
        }
    }

    static bool IsHarshadNumber(int number)
    {
        int sum = 0;
        int originalNumber = number;

        while (originalNumber != 0)
        {
            sum += originalNumber % 10; // Add the last digit to sum
            originalNumber /= 10; // Remove the last digit
        }

        return number % sum == 0; // Check if number is divisible by the sum of its digits
    }
}