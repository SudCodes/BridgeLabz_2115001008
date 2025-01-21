//Q8. Write a program that takes two numbers as input: a base and an exponent,
//    and prints the result of base raised to the exponent (without using loops or
//    conditionals).

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the base: ");
        double baseNumber = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the exponent: ");
        double exponent = Convert.ToDouble(Console.ReadLine());

        double result = Math.Pow(baseNumber, exponent);

        Console.WriteLine(baseNumber+ " raised to the power of " + exponent + "is " + result);
    }
}




