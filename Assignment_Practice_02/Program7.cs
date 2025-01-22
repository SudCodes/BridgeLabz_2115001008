using System;

public class Program7{
    // Function to swap two numbers
    public static void SwapTwoNumbers(ref int number1, ref int number2){
        // Swap the values of number1 and number2
        int temp = number1;
        number1 = number2;
        number2 = temp;
    }

    public static void Main(string[] args){
        // Take user input for number1
        Console.Write("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        // Take user input for number2
        Console.Write("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        // Swap the numbers using the SwapTwoNumbers function
        SwapTwoNumbers(ref number1, ref number2);

        // Print the swapped numbers
        Console.WriteLine($"The swapped numbers are {number1} and {number2}");
    }
}