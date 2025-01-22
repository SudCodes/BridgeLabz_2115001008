using System;

public class TotalIncome{
    // Function to calculate total income
    public static void CalculateIncome(double salary, double bonus){
        // Compute total income by adding salary and bonus
        double totalIncome = salary + bonus;

        // Print the results
        Console.WriteLine($"The salary is INR {salary} and bonus is INR {bonus}. Hence Total Income is INR {totalIncome}");
    }

    public static void Main(string[] args){
        // Take user input for salary
        Console.Write("Enter the salary (in INR): ");
        double salary = Convert.ToDouble(Console.ReadLine());

        // Take user input for bonus
        Console.Write("Enter the bonus (in INR): ");
        double bonus = Convert.ToDouble(Console.ReadLine());

        // Call the function to calculate and print total income
        CalculateIncome(salary, bonus);
    }
}