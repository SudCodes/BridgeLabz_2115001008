using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number to find its factors: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"The factors of {number} are:");
        FindFactors(number);
    }

    static void FindFactors(int number)
    {
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}