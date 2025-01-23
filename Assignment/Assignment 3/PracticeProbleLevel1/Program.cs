using System;

class Program
{
    public static void Main()
    {
        // Creating an object of Program1 and calling CheckDivisibilityByFive method
        Console.Write("Enter a number to check divisibility by 5: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Program1.CheckDivisibilityByFive(num1));

        // Creating an object of Program2 and calling IsFirstSmallest method
        Console.Write("Enter three numbers to check if the first is the smallest: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());
        int num4 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Program2.IsFirstSmallest(num2, num3, num4));

        // Creating an object of Program3 and calling FindLargestNumber method
        Console.Write("Enter three numbers to find the largest: ");
        int num5 = Convert.ToInt32(Console.ReadLine());
        int num6 = Convert.ToInt32(Console.ReadLine());
        int num7 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Program3.FindLargestNumber(num5, num6, num7));

        // Creating an object of Program4 and calling CalculateSumOfNaturalNumbers method
        Console.Write("Enter a number to calculate the sum of natural numbers: ");
        int num8 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Program4.CalculateSumOfNaturalNumbers(num8));

        // Creating an object of Program5 and calling CheckVotingEligibility method
        Console.Write("Enter an age to check voting eligibility: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Program5.CheckVotingEligibility(age));

        // Creating an object of Program6 and calling CheckNumberType method
        Console.Write("Enter a number to check if it is positive, negative, or zero: ");
        int num9 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Program6.CheckNumberType(num9));

        // Creating an object of Program7 and calling CheckSpringSeason method
        Console.Write("Enter a month (1-12) and a day to check if it is Spring Season: ");
        int month = Convert.ToInt32(Console.ReadLine());
        int day = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Program7.CheckSpringSeason(month, day));

        // Creating an object of Program8 and calling CountdownWithWhileLoop method
        Program8 program8 = new Program8();
        program8.CountdownWithWhileLoop();

        // Creating an object of Program9 and calling CountdownWithForLoop method
        Program9 program9 = new Program9();
        program9.CountdownWithForLoop();

        // Creating an object of Program10 and calling SumUntilZero method
        Program10 program10 = new Program10();
        program10.SumUntilZero();

        // Creating an object of Program11 and calling SumUntilZeroOrNegative method
        Program11 program11 = new Program11();
        program11.SumUntilZeroOrNegative();

        // Creating an object of Program12 and calling SumOfNaturalNumbersWithWhile method
        Program12 program12 = new Program12();
        program12.SumOfNaturalNumbersWithWhile();

        // Creating an object of Program13 and calling SumOfNaturalNumbersWithFor method
        Program13 program13 = new Program13();
        program13.SumOfNaturalNumbersWithFor();

        // Creating an object of Program14 and calling FactorialWithWhile method
        Program14 program14 = new Program14();
        program14.FactorialWithWhile();

        // Creating an object of Program15 and calling FactorialWithFor method
        Program15 program15 = new Program15();
        program15.FactorialWithFor();

        // Creating an object of Program16 and calling PrintOddEven method
        Program16 program16 = new Program16();
        program16.PrintOddEven();

        // Creating an object of Program17 and calling CalculateBonus method
        Console.Write("Enter your salary and years of service to calculate the bonus: ");
        double salary = Convert.ToDouble(Console.ReadLine());
        int yearsOfService = Convert.ToInt32(Console.ReadLine());
        Program17 program17 = new Program17();
        Console.WriteLine("The calculated bonus is: " + program17.CalculateBonus(salary, yearsOfService));

        

        // Creating an object of Program17 and calling DisplayMultiplicationTable method
        Console.Write("Enter the number to generate its multiplication table: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Program18 program18 = new Program18();
        program18.DisplayMultiplicationTable(number);
    }
}

