using System;

class Employee
{
    public int EmployeeID { get; set; }
    protected string Department { get; set; }
    private double Salary { get; set; }

    public Employee(int employeeID, string department, double salary)
    {
        EmployeeID = employeeID;
        Department = department;
        SetSalary(salary);
    }

    public double GetSalary()
    {
        return Salary;
    }

    public void SetSalary(double salary)
    {
        if (salary >= 0)
        {
            Salary = salary;
        }
        else
        {
            Console.WriteLine("Invalid salary amount. Salary cannot be negative.");
        }
    }

    public void DisplayEmployeeDetails()
    {
        Console.WriteLine($"Employee ID: {EmployeeID}");
        Console.WriteLine($"Department: {Department}");
        Console.WriteLine($"Salary: ${GetSalary()}");
    }
}

class Manager : Employee
{
    public Manager(int employeeID, string department, double salary)
        : base(employeeID, department, salary)
    {
    }

    public void DisplayManagerDetails()
    {
        Console.WriteLine("Manager Details:");
        Console.WriteLine($"Employee ID: {EmployeeID}");
        Console.WriteLine($"Department: {Department}");
    }
}

class Program13
{
    public static void Main()
    {
        Employee employee1 = new Employee(101, "Sales", 55000);
        employee1.DisplayEmployeeDetails();

        Console.WriteLine();

        Manager manager1 = new Manager(201, "Marketing", 75000);
        manager1.DisplayManagerDetails();
        manager1.DisplayEmployeeDetails();
    }
}
