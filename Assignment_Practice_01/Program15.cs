/*Write a program to input the unit price of an item and the quantity to be bought. Then, calculate the total price.
Hint: NA
I/P => unitPrice, quantity
O/P => The total purchase price is INR ___ if the quantity ___ and unit price is INR ___
*/

using System;

class TotalPriceCalculation
{
    // Function to calculate the total price
    public static void CalculateTotalPrice(double unitPrice, int quantity)
    {
        // Calculate the total price
        double totalPrice = unitPrice * quantity;

        // Output the result
        Console.WriteLine("The total purchase price is INR " + totalPrice + " if the quantity is " + quantity + " and unit price is INR " + unitPrice);
    }

    public static void Main()
    {
        // Prompt user to enter unit price and quantity
        Console.Write("Enter the unit price of the item in INR: ");
        double unitPrice = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the quantity to be bought: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        // Call the function to calculate the total price
        CalculateTotalPrice(unitPrice, quantity);
    }
}
