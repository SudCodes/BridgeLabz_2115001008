using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number to check if it is an Armstrong number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsArmstrongNumber(number))
        {
            Console.WriteLine($"{number} is an Armstrong number.");
        }
        else
        {
            Console.WriteLine($"{number} is not an Armstrong number.");
        }
    }

    static bool IsArmstrongNumber(int number)
    {
        int originalNumber = number;
        int sum = 0;

        while (originalNumber != 0)
        {
            int digit = originalNumber % 10; // Get the last digit
            sum += digit * digit * digit; // Add the cube of the digit to the sum
            originalNumber /= 10; // Remove the last digit
        }

        return sum == number;
    }
}
