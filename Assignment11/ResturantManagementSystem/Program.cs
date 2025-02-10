using System;

// Superclass: Person
class Person
{
    public string Name { get; set; }
    public int Id { get; set; }

    public Person(string name, int id)
    {
        Name = name;
        Id = id;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, ID: {Id}");
    }
}

// Interface: Worker
interface Worker
{
    void PerformDuties();
}

// Subclass: Chef (Inherits from Person, Implements Worker)
class Chef : Person, Worker
{
    public string Specialty { get; set; }

    public Chef(string name, int id, string specialty)
        : base(name, id)
    {
        Specialty = specialty;
    }

    public void PerformDuties()
    {
        Console.WriteLine($"{Name} (Chef) is preparing {Specialty} dishes.");
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Role: Chef, Specialty: {Specialty}");
    }
}

// Subclass: Waiter (Inherits from Person, Implements Worker)
class Waiter : Person, Worker
{
    public int TablesAssigned { get; set; }

    public Waiter(string name, int id, int tablesAssigned)
        : base(name, id)
    {
        TablesAssigned = tablesAssigned;
    }

    public void PerformDuties()
    {
        Console.WriteLine($"{Name} (Waiter) is serving {TablesAssigned} tables.");
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Role: Waiter, Tables Assigned: {TablesAssigned}");
    }
}

// Main Program
class Program
{
    static void Main()
    {
        Chef chef = new Chef("Rahul", 101, "Italian");
        Waiter waiter = new Waiter("Amit", 202, 5);

        chef.DisplayDetails();
        chef.PerformDuties();
        Console.WriteLine();

        waiter.DisplayDetails();
        waiter.PerformDuties();
    }
}
