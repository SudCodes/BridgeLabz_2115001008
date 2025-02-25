using System;
using System.Reflection;

// Step 1: Define the Custom Attribute
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
class ImportantMethod : Attribute
{
    public string Level { get; }

    public ImportantMethod(string level = "HIGH")
    {
        Level = level;
    }
}

// Step 2: Apply the Attribute to Multiple Methods
class Operations
{
    [ImportantMethod("CRITICAL")]
    public void SaveData()
    {
        Console.WriteLine("Saving data...");
    }

    [ImportantMethod] // Defaults to "HIGH"
    public void LoadData()
    {
        Console.WriteLine("Loading data...");
    }

    public void HelperMethod()
    {
        Console.WriteLine("Helper method, not marked important.");
    }
}

class Program
{
    static void Main()
    {
        // Step 3: Retrieve and Print Important Methods Using Reflection
        Type type = typeof(Operations);
        MethodInfo[] methods = type.GetMethods();

        Console.WriteLine("Important Methods:");
        foreach (var method in methods)
        {
            ImportantMethod attribute = (ImportantMethod)Attribute.GetCustomAttribute(method, typeof(ImportantMethod));
            if (attribute != null)
            {
                Console.WriteLine($"Method: {method.Name}, Importance Level: {attribute.Level}");
            }
        }
    }
}
