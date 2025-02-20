using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }

    public Employee(int id, string name, string department, double salary)
    {
        Id = id;
        Name = name;
        Department = department;
        Salary = salary;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}, Department: {Department}, Salary: {Salary:C}";
    }
}

class EmployeeManager
{
    private static string filePath = "employees.json";

    public static void SerializeEmployees(List<Employee> employees)
    {
        try
        {
            string jsonString = JsonSerializer.Serialize(employees, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, jsonString);
            Console.WriteLine("Employees saved successfully!");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"File operation failed: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    public static List<Employee> DeserializeEmployees()
    {
        try
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("No saved employee data found.");
                return new List<Employee>();
            }

            string jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Employee>>(jsonString) ?? new List<Employee>();
        }
        catch (IOException ex)
        {
            Console.WriteLine($"File operation failed: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

        return new List<Employee>();
    }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee(101, "Rahul", "IT", 60000),
            new Employee(102, "Sohail", "HR", 50000),
            new Employee(103, "Sonu", "Finance", 70000)
        };

        // Serialize employee list to file
        EmployeeManager.SerializeEmployees(employees);

        // Deserialize and display employees
        Console.WriteLine("\nRetrieved Employees:");
        List<Employee> retrievedEmployees = EmployeeManager.DeserializeEmployees();
        foreach (var emp in retrievedEmployees)
        {
            Console.WriteLine(emp);
        }
    }
}
