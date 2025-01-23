using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a year (>= 1582): ");
        int year;
        if (int.TryParse(Console.ReadLine(), out year) && year >= 1582)
        {
            // Using a single if statement with logical operators
            if (IsLeapYearLogical(year))
            {
                Console.WriteLine($"{year} is a Leap Year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a Leap Year.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a year >= 1582.");
        }
    }

    // Method using a single if statement with logical operators
    static bool IsLeapYearLogical(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}