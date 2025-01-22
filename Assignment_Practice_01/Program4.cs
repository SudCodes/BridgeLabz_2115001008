/*Create a program to calculate the profit and loss in number and percentage based on the cost price of INR 129 and the selling price of INR 191.
Hint:
Use a single print statement to display multiline text and variables.
Profit = selling price - cost price
Profit Percentage = profit / cost price * 100
I/P => NONE
O/P =>
The Cost Price is INR ___ and Selling Price is INR ___
The Profit is INR ___ and the Profit Percentage is ___
*/

using System;

class Program{
    // Function to calculate profit and profit percentage
    public static void CalculateProfitAndPercentage(int costPrice, int sellingPrice){
        // Calculate profit
        int profit = sellingPrice - costPrice;

        // Calculate profit percentage
        double profitPercentage = (double)profit / costPrice * 100;

        // Display the results
        Console.WriteLine("The Cost Price is INR " + costPrice + " and Selling Price is INR " + sellingPrice\n +
                          "The Profit is INR " + profit + " and the Profit Percentage is " + profitPercentage:F2 + "%");
    }

    public static void Main(){
        // Initialize cost price and selling price
        int costPrice = 129;
        int sellingPrice = 191;

        // Call the function to calculate profit and profit percentage
        CalculateProfitAndPercentage(costPrice, sellingPrice);
    }
}
