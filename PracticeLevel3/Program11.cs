using System;

public class Program11
{
    // Method to generate random salary and years of service for each employee
    public static void GenerateEmployeeData(out double[,] salaryAndYears)
    {
        Random rand = new Random();
        salaryAndYears = new double[10, 2]; 

        for (int i = 0; i < 10; i++)
        {
            salaryAndYears[i, 0] = rand.Next(50000, 100000); 
            salaryAndYears[i, 1] = rand.Next(1, 21);         
        }
    }

    // Method to calculate new salary and bonus based on years of service
    public static double[,] CalculateNewSalaryAndBonus(double[,] salaryAndYears)
    {
        double[,] newSalaryAndBonus = new double[10, 3]; 

        for (int i = 0; i < 10; i++)
        {
            double oldSalary = salaryAndYears[i, 0];
            double yearsOfService = salaryAndYears[i, 1];
            double bonus = 0;

            if (yearsOfService > 5)
            {
                bonus = oldSalary * 0.05;  
            }
            else
            {
                bonus = oldSalary * 0.02;  
            }

            double newSalary = oldSalary + bonus;
            newSalaryAndBonus[i, 0] = newSalary;  
            newSalaryAndBonus[i, 1] = bonus;     
            newSalaryAndBonus[i, 2] = oldSalary; 
        }

        return newSalaryAndBonus;
    }

    // Method to calculate the total bonus amount, total old salary, and total new salary
    public static void CalculateAndDisplayTotals(double[,] salaryAndYears, double[,] newSalaryAndBonus)
    {
        double totalOldSalary = 0;
        double totalNewSalary = 0;
        double totalBonus = 0;

        Console.WriteLine("Employee No. | Old Salary | New Salary | Bonus");

        for (int i = 0; i < 10; i++)
        {
            double oldSalary = newSalaryAndBonus[i, 2];
            double newSalary = newSalaryAndBonus[i, 0];
            double bonus = newSalaryAndBonus[i, 1];

            totalOldSalary += oldSalary;
            totalNewSalary += newSalary;
            totalBonus += bonus;

            Console.WriteLine($"{i + 1}           | {oldSalary:C} | {newSalary:C} | {bonus:C}");
        }

        Console.WriteLine("\nTotal Old Salary: " + totalOldSalary.ToString("C"));
        Console.WriteLine("Total New Salary: " + totalNewSalary.ToString("C"));
        Console.WriteLine("Total Bonus Amount: " + totalBonus.ToString("C"));
    }

    // Main method to execute the program
    public static void Main()
    {
  
        double[,] salaryAndYears;
        GenerateEmployeeData(out salaryAndYears);

  
        double[,] newSalaryAndBonus = CalculateNewSalaryAndBonus(salaryAndYears);

     
        CalculateAndDisplayTotals(salaryAndYears, newSalaryAndBonus);
    }
}
