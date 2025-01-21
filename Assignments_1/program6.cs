//Q6. Write a program to calculate simple interest using the formula: Simple Interest = (Principal * Rate * Time) / 100.
//    Take Principal, Rate, and Time as inputs from the user.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the Principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Rate of interest (in %): ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Time (in years): ");
        double time = Convert.ToDouble(Console.ReadLine());

        double simpleInterest = (principal * rate * time) / 100;

        Console.WriteLine("The Simple Interest is " + simpleInterest);
    }
}



