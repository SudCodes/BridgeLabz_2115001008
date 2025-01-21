//Q2. Write a program that takes two numbers as input from the user and prints their sum.

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the distance in kilometers: ");
        double kilometers = Convert.ToDouble(Console.ReadLine());
        double miles = kilometers * 0.621371;
        Console.WriteLine(kilometers + " kilometers is equal to "+ miles +" miles.");
    }
}

