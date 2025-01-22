/*The University is charging the student a fee of INR 125000 for the course. The University is willing to offer a discount of 10%. Write a program to find the discounted amount and discounted price the student will pay for the course.
Hint:
Create a variable named fee and assign 125000 to it.
Create another variable discountPercent and assign 10 to it.
Compute discount and assign it to the discount variable.
Compute and print the fee you have to pay by subtracting the discount from the fee.
I/P => NONE
O/P => The discount amount is INR ___ and final discounted fee is INR ___
*/

using System;

class Program
{
    // Function to calculate discount amount and final discounted fee
    public static void CalculateDiscount(int fee, int discountPercent)
    {
        // Calculate the discount amount
        double discountAmount = (discountPercent / 100.0) * fee;

        // Calculate the final discounted fee
        double finalFee = fee - discountAmount;

        // Display the results
        Console.WriteLine($"The discount amount is INR {discountAmount:F2} and final discounted fee is INR {finalFee:F2}");
    }

    public static void Main()
    {
        // Fee for the course and discount percentage
        int fee = 125000;
        int discountPercent = 10;

        // Call the function to calculate discount and final fee
        CalculateDiscount(fee, discountPercent);
    }
}
