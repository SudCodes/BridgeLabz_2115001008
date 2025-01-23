using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number to check if it is an Abundant Number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsAbundantNumber(number))
        {
            Console.WriteLine($"{number} is an Abundant Number.");
        }
        else
        {
            Console.WriteLine($"{number} is not an Abundant Number.");
        }
    }

    static bool IsAbundantNumber(int number)
    {
        int sum = 0;

        for (int i = 1; i < number; i++)
        {
            if (number % i == 0) // Check if i is a divisor
            {
                sum += i; // Add the divisor to sum
            }
        }

        return sum > number; // Check if sum of divisors is greater than the number
    }
}
