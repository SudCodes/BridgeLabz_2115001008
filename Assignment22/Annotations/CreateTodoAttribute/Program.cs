using System;
using System.Reflection;

// Step 1: Define the Todo Attribute
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class Todo : Attribute
{
    public string Task { get; }
    public string AssignedTo { get; }
    public string Priority { get; }

    public Todo(string task, string assignedTo, string priority = "MEDIUM")
    {
        Task = task;
        AssignedTo = assignedTo;
        Priority = priority;
    }
}

// Step 2: Apply the Todo Attribute to Methods
class Project
{
    [Todo("Implement payment gateway", "Amit", "HIGH")]
    [Todo("Fix UI alignment issue", "Priya", "CRITICAL")]
    public void ProcessPayment()
    {
        Console.WriteLine("Processing payment...");
    }

    [Todo("Optimize database queries", "Rohan")]
    public void FetchData()
    {
        Console.WriteLine("Fetching data...");
    }

    [Todo("Implement email notifications", "Sneha", "LOW")]
    public void SendNotification()
    {
        Console.WriteLine("Sending notification...");
    }

    public void CompletedFeature()
    {
        Console.WriteLine("This feature is already implemented.");
    }
}

class Program
{
    static void Main()
    {
        // Step 3: Retrieve and Print All Pending Tasks Using Reflection
        Type type = typeof(Project);
        MethodInfo[] methods = type.GetMethods();

        Console.WriteLine("Pending Tasks:");
        foreach (var method in methods)
        {
            Todo[] attributes = (Todo[])method.GetCustomAttributes(typeof(Todo), false);
            foreach (var todo in attributes)
            {
                Console.WriteLine($"Method: {method.Name}");
                Console.WriteLine($"Task: {todo.Task}");
                Console.WriteLine($"Assigned To: {todo.AssignedTo}");
                Console.WriteLine($"Priority: {todo.Priority}");
                Console.WriteLine("----------------------");
            }
        }
    }
}
