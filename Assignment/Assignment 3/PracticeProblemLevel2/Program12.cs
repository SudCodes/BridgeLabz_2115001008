using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number to find its multiples below 100: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"The multiples of {number} below 100 are:");
        FindMultiplesBelow100(number);
    }

    static void FindMultiplesBelow100(int number)
    {
        for (int i = 100; i >= 1; i--)
        {
            if (i % number == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
