using System;

public class Program10{
    // Function to divide chocolates among children
    public static void DivideChocolates(int numberOfChocolates, int numberOfChildren){
        // Calculate chocolates each child gets and remaining chocolates
        int chocolatesPerChild = numberOfChocolates / numberOfChildren;
        int remainingChocolates = numberOfChocolates % numberOfChildren;

        // Print the results
        Console.WriteLine($"The number of chocolates each child gets is {chocolatesPerChild} " + $"and the number of remaining chocolates is {remainingChocolates}");
    }

    public static void Main(string[] args){
        // Take user input for number of chocolates and number of children
        Console.Write("Enter the number of chocolates: ");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of children: ");
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());

        // Call the function to divide chocolates and display the results
        DivideChocolates(numberOfChocolates, numberOfChildren);
    }
}