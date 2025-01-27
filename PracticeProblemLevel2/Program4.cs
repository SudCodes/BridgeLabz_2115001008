//Q4. Rework the program 2, especially the Hint: if index equals maxDigit, we break from the loop. Here we want to modify to increase the size of the array i,e maxDigit by 10 if the index is equal to maxDigit. This is done to consider all digits to find the largest and second-largest number 
// Hint => 
// In Hint f inside the loop if the index is equal to maxDigit, increase maxDigit and make digits array to store more elements. 
// To do this, we need to create a new temp array of size maxDigit, copy from the current digits array the digits into the temp array, and assign the current digits array to the temp array
// Now the digits array will be able to store all digits of the number in the array and then find the largest and second largest number
// Create a program to take a number as input and reverse the number. To do this, store the digits of the number in an array and display the array in reverse order

using System;

class Program4
{
    // Function to store digits of the number and find the largest and second largest
    static void FindLargestAndSecondLargest(int number, out int largest, out int secondLargest)
    {
        int maxDigit = 10; // Initial size of the array
        int[] digits = new int[maxDigit];
        int index = 0;

        // Extract digits from the number and store them in the array
        while (number != 0)
        {
            // If the index reaches maxDigit, increase the array size
            if (index == maxDigit)
            {
                maxDigit += 10; // Increase the size by 10
                int[] temp = new int[maxDigit]; // Create a temporary array with the new size
                Array.Copy(digits, temp, digits.Length); // Copy the old array's values to the new one
                digits = temp; // Assign the new array to digits
            }

            digits[index] = number % 10;
            number /= 10;
            index++;
        }

        // Now find the largest and second largest digits
        largest = secondLargest = -1; // Initialize to an invalid value

        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] < largest)
            {
                secondLargest = digits[i];
            }
        }

        // Handle case if no second largest is found (in case all digits are the same)
        if (secondLargest == -1)
        {
            secondLargest = largest; // In this case, set second largest to largest
        }
    }

    // Function to reverse the digits of the number and display them
    static void ReverseNumber(int number)
    {
        int[] digits = new int[10];
        int index = 0;

        // Extract digits from the number and store them in the array
        while (number != 0)
        {
            digits[index] = number % 10;
            number /= 10;
            index++;
        }

        // Display the digits in reverse order
        Console.WriteLine("Reversed number:");
        for (int i = 0; i < index; i++)
        {
            Console.Write(digits[i]);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Call the function to find largest and second largest digits
        int largest, secondLargest;
        FindLargestAndSecondLargest(number, out largest, out secondLargest);

        // Display the results for largest and second largest
        Console.WriteLine($"Largest digit: {largest}");
        Console.WriteLine($"Second largest digit: {secondLargest}");

        // Call the function to reverse and display the number
        ReverseNumber(number);
    }
}
