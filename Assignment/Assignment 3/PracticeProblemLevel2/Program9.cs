using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int greatestFactor = FindGreatestFactor(number);
        Console.WriteLine($"The greatest factor of {number} (besides itself) is: {greatestFactor}");
    }

    static int FindGreatestFactor(int number)
    {
        int greatestFactor = 1;
        for (int i = number - 1; i > 0; i--)
        {
            if (number % i == 0)
            {
                greatestFactor = i;
                break;
            }
        }
        return greatestFactor;
    }
}