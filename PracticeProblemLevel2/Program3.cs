//Q3. Create a program to store the digits of the number in an array and find the largest and second largest element of the array.
// Hint => 
// Create a number variable and take user input. 
// Define an array to store the digits. Set the size of the array to maxDigit variable initially set to 10
// Create an integer variable index with the value 0 to reflect the array index.
// Use a loop to iterate until the number is not equal to 0.
// Remove the last digit from the number in each iteration and add it to the array.
// Increment the index by 1 in each iteration and if the index count equals maxDigit then break out of the loop and the remaining digits are not added to the array
// Define variable to store largest and second largest digit and initialize it to zero
// Loop through the array and use conditional statements to find the largest and second largest number in the array
// Finally display the largest  and second-largest number

using System;

class Program3
{
    // Function to store digits of the number and find the largest and second largest
    static void FindLargestAndSecondLargest(int number, out int largest, out int secondLargest)
    {
        int maxDigit = 10;
        int[] digits = new int[maxDigit];
        int index = 0;

        // Extract digits from the number and store them in the array
        while (number != 0 && index < maxDigit)
        {
            digits[index] = number % 10;
            number /= 10;
            index++;
        }

        largest = secondLargest = -1;  // Initialize to an invalid value

        // Find the largest and second largest digits
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

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int largest, secondLargest;

        // Call the function to find largest and second largest digits
        FindLargestAndSecondLargest(number, out largest, out secondLargest);

        // Display the results
        Console.WriteLine($"Largest digit: {largest}");
        Console.WriteLine($"Second largest digit: {secondLargest}");
    }
}

