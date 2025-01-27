// Q1. Create a program to find the bonus of 10 employees based on their years of service and the total bonus amount the company Zara has 
// to pay, along with the old and new salary.
// Hint => 
// Zara decides to give a bonus of 5% to employees whose year of service is more than 5 years or 2% if less than 5 years
// Define a double array to save salary and years of service for each of the 10 employees
// Also define a double array to save the new salary and the bonus amount as well as variables to save the total bonus, total old salary,
// and new salary
// Define a loop to take input from the user. If salary or year of service is an invalid number then ask the user to enter again. Note in this case you will have to decrement the index counter
// Define another loop to calculate the bonus of 10 employees based on their years of service. Save the bonus in the array, compute the new salary, and save in the array. Also, the total bonus and total old and new salary can be calculated in the loop
// Print the total bonus payout as well as the total old and new salary of all the employees

using System;

class Program1
{
    // Function to get employee data and calculate bonus
    static void CalculateBonusAndSalaries(double[] salaries, double[] yearsOfService, ref double[] bonusAmounts, ref double[] newSalaries, ref double totalBonus, ref double totalOldSalary, ref double totalNewSalary)
    {
        for (int i = 0; i < 10; i++)
        {
            double salary = salaries[i];
            double years = yearsOfService[i];

            double bonus = 0;
            if (years > 5)
            {
                bonus = salary * 0.05; // 5% bonus for more than 5 years
            }
            else
            {
                bonus = salary * 0.02; // 2% bonus for less than 5 years
            }

            bonusAmounts[i] = bonus;
            newSalaries[i] = salary + bonus;

            totalBonus += bonus;
            totalOldSalary += salary;
            totalNewSalary += newSalaries[i];
        }
    }

    static void Main()
    {
        double[] salaries = new double[10];          // Array to store old salaries
        double[] yearsOfService = new double[10];    // Array to store years of service
        double[] bonusAmounts = new double[10];      // Array to store bonus amounts
        double[] newSalaries = new double[10];       // Array to store new salaries after bonus

        double totalBonus = 0;       // Total bonus payout
        double totalOldSalary = 0;   // Total of old salaries
        double totalNewSalary = 0;   // Total of new salaries after adding bonuses

        // Loop to take input for salaries and years of service from the user
        for (int i = 0; i < 10; i++)
        {
            bool validInput = false;
            while (!validInput)
            {
                try
                {
                    Console.WriteLine($"Enter the salary of employee {i + 1}: ");
                    salaries[i] = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"Enter the years of service of employee {i + 1}: ");
                    yearsOfService[i] = Convert.ToDouble(Console.ReadLine());

                    // Validate the input (salary and years should be positive numbers)
                    if (salaries[i] > 0 && yearsOfService[i] >= 0)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter positive values for salary and years of service.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter numeric values.");
                }
            }
        }

        // Call the function to calculate bonuses and salaries
        CalculateBonusAndSalaries(salaries, yearsOfService, ref bonusAmounts, ref newSalaries, ref totalBonus, ref totalOldSalary, ref totalNewSalary);

        // Print the results
        Console.WriteLine("\nEmployee Bonus Details:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Employee {i + 1}: Old Salary = {salaries[i]:C}, Years of Service = {yearsOfService[i]}, Bonus = {bonusAmounts[i]:C}, New Salary = {newSalaries[i]:C}");
        }

        Console.WriteLine($"\nTotal Bonus Paid: {totalBonus:C}");
        Console.WriteLine($"Total Old Salary: {totalOldSalary:C}");
        Console.WriteLine($"Total New Salary: {totalNewSalary:C}");
    }
}
