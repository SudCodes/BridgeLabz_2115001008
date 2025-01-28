using System;

public class Program6
{
    // Method to find factors of a number and return them as an array
    public static int[] FindFactors(int number)
    {
        int[] factors = new int[number / 2];
        int count = 0;

        for (int i = 1; i <= number / 2; i++)
        {
            if (number % i == 0)
            {
                factors[count] = i;
                count++;
            }
        }

        Array.Resize(ref factors, count); // Resize array to actual number of factors
        return factors;
    }

    // Method to find the greatest factor of a number using the factors array
    public static int GreatestFactor(int number)
    {
        int[] factors = FindFactors(number);
        return factors.Length > 0 ? factors[factors.Length - 1] : 0;
    }

    // Method to find the sum of the factors using the factors array and return the sum
    public static int SumOfFactors(int number)
    {
        int[] factors = FindFactors(number);
        int sum = 0;

        foreach (var factor in factors)
        {
            sum += factor;
        }

        return sum;
    }

    // Method to find the product of the factors using the factors array and return the product
    public static int ProductOfFactors(int number)
    {
        int[] factors = FindFactors(number);
        int product = 1;

        foreach (var factor in factors)
        {
            product *= factor;
        }

        return product;
    }

    // Method to find the product of the cube of the factors using the factors array
    public static double ProductOfCubeOfFactors(int number)
    {
        int[] factors = FindFactors(number);
        double product = 1;

        foreach (var factor in factors)
        {
            product *= Math.Pow(factor, 3);
        }

        return product;
    }

    // Method to check if a number is a perfect number
    public static bool IsPerfectNumber(int number)
    {
        return SumOfFactors(number) == number;
    }

    // Method to check if a number is an abundant number
    public static bool IsAbundantNumber(int number)
    {
        return SumOfFactors(number) > number;
    }

    // Method to check if a number is a deficient number
    public static bool IsDeficientNumber(int number)
    {
        return SumOfFactors(number) < number;
    }

    // Method to check if a number is a strong number
    public static bool IsStrongNumber(int number)
    {
        int originalNumber = number;
        int sumOfFactorials = 0;

        while (number > 0)
        {
            int digit = number % 10;
            sumOfFactorials += Factorial(digit);
            number /= 10;
        }

        return sumOfFactorials == originalNumber;
    }

    // Helper method to calculate factorial of a number
    public static int Factorial(int number)
    {
        int result = 1;
        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }

    // Main method to call the different methods and display results
    public static void Main()
    {
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Factors of {number}:");
        int[] factors = FindFactors(number);
        foreach (var factor in factors)
        {
            Console.Write(factor + " ");
        }
        Console.WriteLine();

        Console.WriteLine($"Greatest Factor of {number}: {GreatestFactor(number)}");
        Console.WriteLine($"Sum of Factors of {number}: {SumOfFactors(number)}");
        Console.WriteLine($"Product of Factors of {number}: {ProductOfFactors(number)}");
        Console.WriteLine($"Product of Cube of Factors of {number}: {ProductOfCubeOfFactors(number)}");
        Console.WriteLine($"Is {number} a Perfect Number? {IsPerfectNumber(number)}");
        Console.WriteLine($"Is {number} an Abundant Number? {IsAbundantNumber(number)}");
        Console.WriteLine($"Is {number} a Deficient Number? {IsDeficientNumber(number)}");
        Console.WriteLine($"Is {number} a Strong Number? {IsStrongNumber(number)}");
    }
}
