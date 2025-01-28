using System;

public class Program5
{
    // Method to check if a number is a prime number
    public static bool IsPrime(int number)
    {
        if (number <= 1) return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    // Method to check if a number is a neon number
    public static bool IsNeon(int number)
    {
        int square = number * number;
        int sumOfDigits = 0;
        while (square > 0)
        {
            sumOfDigits += square % 10;
            square /= 10;
        }

        return sumOfDigits == number;
    }

    // Method to check if a number is a spy number
    public static bool IsSpy(int number)
    {
        int sum = 0, product = 1;
        while (number > 0)
        {
            int digit = number % 10;
            sum += digit;
            product *= digit;
            number /= 10;
        }

        return sum == product;
    }

    // Method to check if a number is an automorphic number
    public static bool IsAutomorphic(int number)
    {
        int square = number * number;
        while (square > 0)
        {
            if (square % 10 != number % 10)
                return false;
            square /= 10;
            number /= 10;
        }

        return true;
    }

    // Method to check if a number is a buzz number
    public static bool IsBuzz(int number)
    {
        return number % 7 == 0 || number % 10 == 7;
    }

    // Main method to call the different methods and display results
    public static void Main()
    {
        int number = Convert.ToInt32(Console.ReadLine()); // Example number, you can change this for testing

        Console.WriteLine($"Is {number} prime? {IsPrime(number)}");
        Console.WriteLine($"Is {number} a neon number? {IsNeon(number)}");
        Console.WriteLine($"Is {number} a spy number? {IsSpy(number)}");
        Console.WriteLine($"Is {number} an automorphic number? {IsAutomorphic(number)}");
        Console.WriteLine($"Is {number} a buzz number? {IsBuzz(number)}");
    }
}
