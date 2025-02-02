using System;

class Program9
{
    static void Main(string[] args)
    {
        // Display operation choices
        Console.WriteLine("Choose an operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        // Get the user's choice
        int choice = Convert.ToInt32(Console.ReadLine());

        // Get two numbers from the user
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Perform the chosen operation using if-else
        double result = 0;

        if (choice == 1)
        {
            result = Add(num1, num2);
            Console.WriteLine($"The result of {num1} + {num2} is {result}.");
        }
        else if (choice == 2)
        {
            result = Subtract(num1, num2);
            Console.WriteLine($"The result of {num1} - {num2} is {result}.");
        }
        else if (choice == 3)
        {
            result = Multiply(num1, num2);
            Console.WriteLine($"The result of {num1} * {num2} is {result}.");
        }
        else if (choice == 4)
        {
            if (num2 != 0)
            {
                result = Divide(num1, num2);
                Console.WriteLine($"The result of {num1} / {num2} is {result}.");
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    // Function to add two numbers
    static double Add(double a, double b)
    {
        return a + b;
    }

    // Function to subtract two numbers
    static double Subtract(double a, double b)
    {
        return a - b;
    }

    // Function to multiply two numbers
    static double Multiply(double a, double b)
    {
        return a * b;
    }

    // Function to divide two numbers
    static double Divide(double a, double b)
    {
        return a / b;
    }
}
