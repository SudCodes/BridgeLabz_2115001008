using System;

class Program1{
    // Function to calculate the quotient and remainder
    public static void CalculateQuotientAndRemainder(int number1, int number2){
        // Calculate the quotient using division operator
        int quotient = number1 / number2;

        // Calculate the remainder using modulus operator
        int remainder = number1 % number2;

        // Output the result
        Console.WriteLine("The Quotient is " + quotient + " and Remainder is " + remainder + " of two numbers " + number1 + " and " + number2);
    }

    public static void Main(){
        // Prompt user to enter two numbers
        Console.Write("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        // Call the function to calculate the quotient and remainder
        CalculateQuotientAndRemainder(number1, number2);
    }
}