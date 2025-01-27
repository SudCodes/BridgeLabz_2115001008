// Q5. Create a program to take a number as input and reverse the number. To do this, store the digits of the number in an array and display the array in reverse order
// Hint => 
// Take user input for a number. 
// Find the count of digits in the number. 
// Find the digits in the number and save them in an array
// Create an array to store the elements of the digits array in reverse order
// Finally, display the elements of the array in reverse order

using System;

class Program5
{
    // Function to reverse the number and display the digits
    static void ReverseNumber(int number)
    {
        // Count the number of digits in the number
        int count = 0;
        int tempNumber = number;

        while (tempNumber != 0)
        {
            tempNumber /= 10;
            count++;
        }

        // Create an array to store the digits of the number
        int[] digits = new int[count];
        
        // Store the digits in the array
        tempNumber = number;
        for (int i = 0; i < count; i++)
        {
            digits[i] = tempNumber % 10;
            tempNumber /= 10;
        }

        // Create an array to store the elements of the digits array in reverse order
        int[] reversedDigits = new int[count];
        for (int i = 0; i < count; i++)
        {
            reversedDigits[i] = digits[count - 1 - i];
        }

        // Display the digits in reverse order
        Console.WriteLine("Reversed number:");
        foreach (int digit in reversedDigits)
        {
            Console.Write(digit);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Call the function to reverse the number and display it
        ReverseNumber(number);
    }
}

