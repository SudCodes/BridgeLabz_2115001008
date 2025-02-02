using System;

class Program2
{
    public static void Main()
    {
        int num1 = GetNumber("Enter first number: ");
        int num2 = GetNumber("Enter second number: ");
        int num3 = GetNumber("Enter third number: ");
        
        int max = FindMaximum(num1, num2, num3);
        
        Console.WriteLine("The maximum number is: " + max);
    }

    public static int GetNumber(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }

    public static int FindMaximum(int a, int b, int c)
    {
        return Math.Max(a, Math.Max(b, c));
    }
}
