using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the base number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter the power: ");
        int power = int.Parse(Console.ReadLine());

        int result = CalculatePower(number, power);
        Console.WriteLine($"{number} raised to the power of {power} is: {result}");
    }

    static int CalculatePower(int number, int power)
    {
        int result = 1;
        for (int i = 1; i <= power; i++)
        {
            result *= number;
        }
        return result;
    }
}
