using System;
class Employee
{
    public string name { get; set; }
    public int id { get; set; }
    public double salary { get; set; }

    public Employee(string Name, int ID, double Salary)
    {
        this.name = Name;
        this.id = ID;
        this.salary = Salary;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Name: {name}, ID: {id}, Salary: {salary:C}");
    }
}

class Manager : Employee
{
    public int teamSize { get; set; }
    public Manager(string name, int id, double salary, int teamSize) : base(name, id, salary) 
    {
        this.teamSize = teamSize;
    }
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Team Size: {teamSize}");
    }

}

class Developer : Employee
{
    public string ProgrammingLanguage { get; set; }

    public Developer(string name, int id, double salary, string programmingLanguage) : base(name, id, salary)
    {
        this.ProgrammingLanguage = programmingLanguage;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Programming Language: {ProgrammingLanguage}");
    }
}

class Intern : Employee
{
    public string IntershipDuration { get; set; }
    public Intern(string name, int id, double salary, string intershipDuration) : base(name, id, salary) 
    {
        this.IntershipDuration = intershipDuration;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Intership Duration: {IntershipDuration}");
    }

}

class Program
{
    public static void Main(string[] args)
    {
        Employee manager = new Manager("Sudhanshu", 101, 80000, 10);
        Employee developer = new Developer("Rahul", 102, 60000, "C#");
        Employee intern = new Intern("Aarti", 103, 20000, "6 months");

        manager.DisplayDetails();
        Console.WriteLine();
        developer.DisplayDetails();
        Console.WriteLine();
        intern.DisplayDetails();
    }
}