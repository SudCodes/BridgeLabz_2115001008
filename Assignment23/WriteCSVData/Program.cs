using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "employees.csv";

        string[] employees = {
            "ID,Name,Department,Salary",
            "101,Rahul,IT,60000",
            "102,Neha,HR,55000",
            "103,Amit,Finance,65000",
            "104,Pooja,Marketing,58000",
            "105,Vikram,Sales,62000"
        };

        File.WriteAllLines(filePath, employees);

        Console.WriteLine("CSV file created successfully!");
    }
}
