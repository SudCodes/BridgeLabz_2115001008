using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number to check if it is prime: ");
        int number = int.Parse(Console.ReadLine());

        if (number > 1)
        {
            bool isPrime = CheckIfPrime(number);

            if (isPrime)
            {
                Console.WriteLine($"{number} is a Prime Number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a Prime Number.");
            }
        }
        else
        {
            Console.WriteLine("Prime numbers are greater than 1.");
        }
    }

    static bool CheckIfPrime(int number)
    {
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                return false; // Not a prime number
            }
        }
        return true; // Prime number
    }
}