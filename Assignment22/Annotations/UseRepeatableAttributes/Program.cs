using System;
using System.Reflection;

// Step 1: Define the Repeatable Custom Attribute
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class BugReport : Attribute
{
    public string Description { get; }

    public BugReport(string description)
    {
        Description = description;
    }
}

// Step 2: Apply the Attribute Multiple Times on a Method
class Software
{
    [BugReport("Fix null reference exception in input validation.")]
    [BugReport("Optimize performance for large data processing.")]
    public void ProcessData()
    {
        Console.WriteLine("Processing data...");
    }
}

class Program
{
    static void Main()
    {
        // Step 3: Retrieve and Print All Bug Reports Using Reflection
        Type type = typeof(Software);
        MethodInfo method = type.GetMethod("ProcessData");

        if (method != null)
        {
            BugReport[] attributes = (BugReport[])method.GetCustomAttributes(typeof(BugReport), false);

            Console.WriteLine($"Method: {method.Name}");
            foreach (var bug in attributes)
            {
                Console.WriteLine($"Bug Report: {bug.Description}");
            }
        }
    }
}
