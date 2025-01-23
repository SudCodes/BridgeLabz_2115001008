using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number to count its digits: ");
        int number = int.Parse(Console.ReadLine());

        int digitCount = CountDigits(number);
        Console.WriteLine($"The number {number} has {digitCount} digit(s).");
    }

    static int CountDigits(int number)
    {
        int count = 0;
        while (number != 0)
        {
            number /= 10; // Remove the last digit
            count++; // Increment the count
        }
        return count;
    }
}