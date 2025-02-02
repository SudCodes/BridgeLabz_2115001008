using System;

class Program7
{
    public static void Main()
    {
        // Get user input
        int num1 = GetInput("Enter first number: ");
        int num2 = GetInput("Enter second number: ");
        
        // Calculate GCD and LCM
        int gcd = CalculateGCD(num1, num2);
        int lcm = CalculateLCM(num1, num2, gcd);
        
        // Display the results
        DisplayResults(num1, num2, gcd, lcm);
    }

    public static int GetInput(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }

    public static int CalculateGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Function to calculate LCM
    public static int CalculateLCM(int a, int b, int gcd)
    {
        return (a / gcd) * b;
    }

    // Function to display the results
    public static void DisplayResults(int num1, int num2, int gcd, int lcm)
    {
        Console.WriteLine("GCD of " + num1 + " and " + num2 + " is: " + gcd);
        Console.WriteLine("LCM of " + num1 + " and " + num2 + " is: " + lcm);
    }
}
