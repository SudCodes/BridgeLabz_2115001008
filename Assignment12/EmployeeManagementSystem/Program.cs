using System;
using System.Collections.Generic;

abstract class Employee
{
    public int EmployeeId { get; private set; }
    public string Name { get; private set; }
    public double BaseSalary { get; private set; }

    public Employee(int employeeId, string name, double baseSalary)
    {
        EmployeeId = employeeId;
        Name = name;
        BaseSalary = baseSalary;
    }

    public abstract double CalculateSalary();

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Employee ID: {EmployeeId}, Name: {Name}, Base Salary: {BaseSalary:C}, Total Salary: {CalculateSalary():C}");
    }
}

interface IDepartment
{
    void AssignDepartment(string department);
    string GetDepartmentDetails();
}

class FullTimeEmployee : Employee, IDepartment
{
    private string Department;
    private double Bonus;

    public FullTimeEmployee(int employeeId, string name, double baseSalary, double bonus)
        : base(employeeId, name, baseSalary)
    {
        Bonus = bonus;
    }

    public override double CalculateSalary()
    {
        return BaseSalary + Bonus;
    }

    public void AssignDepartment(string department)
    {
        Department = department;
    }

    public string GetDepartmentDetails()
    {
        return $"Department: {Department}";
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine(GetDepartmentDetails());
    }
}

class PartTimeEmployee : Employee, IDepartment
{
    private string Department;
    private int WorkHours;
    private double HourlyRate;

    public PartTimeEmployee(int employeeId, string name, double hourlyRate, int workHours)
        : base(employeeId, name, 0)
    {
        HourlyRate = hourlyRate;
        WorkHours = workHours;
    }

    public override double CalculateSalary()
    {
        return HourlyRate * WorkHours;
    }

    public void AssignDepartment(string department)
    {
        Department = department;
    }

    public string GetDepartmentDetails()
    {
        return $"Department: {Department}";
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine(GetDepartmentDetails());
    }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new FullTimeEmployee(101, "Alice", 50000, 10000),
            new PartTimeEmployee(102, "Bob", 500, 40)
        };

        ((FullTimeEmployee)employees[0]).AssignDepartment("HR");
        ((PartTimeEmployee)employees[1]).AssignDepartment("Customer Support");

        foreach (var emp in employees)
        {
            emp.DisplayDetails();
            Console.WriteLine();
        }
    }
}
