using System;
using System.Collections.Generic;
using System.IO;

class Employee
{
    public int EmployeeID { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public decimal Salary { get; set; }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { EmployeeID = 101, Name = "Rahul", Department = "IT", Salary = 60000 },
            new Employee { EmployeeID = 102, Name = "Neha", Department = "HR", Salary = 50000 },
            new Employee { EmployeeID = 103, Name = "Amit", Department = "Finance", Salary = 70000 },
            new Employee { EmployeeID = 104, Name = "Pooja", Department = "Marketing", Salary = 55000 },
            new Employee { EmployeeID = 105, Name = "Arjun", Department = "IT", Salary = 75000 }
        };

        string csvFilePath = "employees.csv";

        using (StreamWriter writer = new StreamWriter(csvFilePath))
        {
            writer.WriteLine("Employee ID,Name,Department,Salary"); // CSV Header

            foreach (var emp in employees)
            {
                writer.WriteLine($"{emp.EmployeeID},{emp.Name},{emp.Department},{emp.Salary}");
            }
        }

        Console.WriteLine("CSV report generated successfully!");
    }
}
