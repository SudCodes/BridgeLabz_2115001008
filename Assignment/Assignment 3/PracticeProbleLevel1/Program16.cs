// Class to print odd and even numbers up to the user-inputted value
using System;
class Program16
{
    public void PrintOddEven()
    {
        // Prompting the user to input a number
        Console.Write("Enter a positive integer: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Validating if the input is a positive integer
        if (n <= 0)
        {
            Console.WriteLine("The number is not a natural number.");
            return;
        }

        // Using a for loop to check and print odd or even numbers
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i + " is even.");
            }
            else
            {
                Console.WriteLine(i + " is odd.");
            }
        }
    }
}