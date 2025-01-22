Write a new program similar to the program # 6 but take user input for Student Fee and University Discount
Hint:
Create a variable named fee and take user input for fee.
Create another variable discountPercent and take user input.
/*Compute the discount and assign it to the discount variable.
Compute and print the fee you have to pay by subtracting the discount from the fee.
I/P => fee, discountPrecent
O/P => The discount amount is INR ___ and final discounted fee is INR ___
*/


using System;

class StudentFeeDiscount
{
    // Public function to calculate the discount and final fee
    public static void CalculateDiscount(double fee, double discountPercent)
    {
        // Calculate the discount amount
        double discount = (fee * discountPercent) / 100;
        
        // Calculate the final fee after applying the discount
        double finalFee = fee - discount;
        
        // Output the results
        Console.WriteLine("The discount amount is INR " + discount);
        Console.WriteLine("The final discounted fee is INR " + finalFee);
    }

    public static void Main()
    {
        //Ask user to enter fee and discount percentage
        Console.Write("Enter the student fee in INR: ");
        double fee = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the discount percentage: ");
        double discountPercent = Convert.ToDouble(Console.ReadLine());

        // Call the public function to compute discount and final fee
        CalculateDiscount(fee, discountPercent);
    }
}

