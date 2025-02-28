using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "employees.csv";

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            string[][] employees = new string[lines.Length - 1][]; // Exclude header

            for (int i = 1; i < lines.Length; i++) // Read data manually
            {
                employees[i - 1] = lines[i].Split(',');
            }

            // Manual sorting (Descending order by Salary)
            for (int i = 0; i < employees.Length - 1; i++)
            {
                for (int j = i + 1; j < employees.Length; j++)
                {
                    if (double.Parse(employees[i][3]) < double.Parse(employees[j][3]))
                    {
                        string[] temp = employees[i];
                        employees[i] = employees[j];
                        employees[j] = temp;
                    }
                }
            }

            // Print top 5 highest-paid employees
            Console.WriteLine("Top 5 Highest Paid Employees:\n");
            for (int i = 0; i < Math.Min(5, employees.Length); i++)
            {
                Console.WriteLine($"ID: {employees[i][0]}, Name: {employees[i][1]}, Department: {employees[i][2]}, Salary: {employees[i][3]}");
            }
        }
        else
        {
            Console.WriteLine("File not found!");
        }
    }
}
