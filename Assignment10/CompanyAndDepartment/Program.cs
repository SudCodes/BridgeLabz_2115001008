using System;

// Employee class
class Employee
{
    public string Name { get; set; }

    public Employee(string name)
    {
        Name = name;
    }
}

// Department class (Composition - Exists only within Company)
class Department
{
    public string Name { get; set; }
    public List<Employee> Employees { get; set; }

    public Department(string name)
    {
        Name = name;
        Employees = new List<Employee>();
    }

    public void AddEmployee(string employeeName)
    {
        Employees.Add(new Employee(employeeName));
    }
}

// Company class (Owner of Departments and Employees)
class Company
{
    public string Name { get; set; }
    private List<Department> Departments;

    public Company(string name)
    {
        Name = name;
        Departments = new List<Department>();
    }

    public void AddDepartment(string departmentName)
    {
        Departments.Add(new Department(departmentName));
    }

    public void AddEmployeeToDepartment(string departmentName, string employeeName)
    {
        var department = Departments.Find(d => d.Name == departmentName);
        if (department != null)
        {
            department.AddEmployee(employeeName);
        }
    }

    public void DisplayCompanyStructure()
    {
        Console.WriteLine($"Company: {Name}");
        foreach (var department in Departments)
        {
            Console.WriteLine($"  Department: {department.Name}");
            foreach (var employee in department.Employees)
            {
                Console.WriteLine($"    Employee: {employee.Name}");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Company company = new Company("TechCorp");
        company.AddDepartment("IT");
        company.AddDepartment("HR");

        company.AddEmployeeToDepartment("IT", "Aarti");
        company.AddEmployeeToDepartment("IT", "Rahul");
        company.AddEmployeeToDepartment("HR", "Sudhanshu");

        company.DisplayCompanyStructure();
    }
}