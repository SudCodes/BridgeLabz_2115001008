using System;
using System.Reflection;

// Step 1: Define the Custom Attribute
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
class TaskInfo : Attribute
{
    public int Priority { get; }
    public string AssignedTo { get; }

    public TaskInfo(int priority, string assignedTo)
    {
        Priority = priority;
        AssignedTo = assignedTo;
    }
}

// Step 2: Apply the Attribute to a Method
class TaskManager
{
    [TaskInfo(1, "Alice")]
    public void CompleteTask()
    {
        Console.WriteLine("Task completed.");
    }
}

class Program
{
    static void Main()
    {
        // Step 3: Retrieve Attribute Details Using Reflection
        Type type = typeof(TaskManager);
        MethodInfo method = type.GetMethod("CompleteTask");

        if (method != null)
        {
            TaskInfo attribute = (TaskInfo)Attribute.GetCustomAttribute(method, typeof(TaskInfo));
            if (attribute != null)
            {
                Console.WriteLine($"Method: {method.Name}");
                Console.WriteLine($"Priority: {attribute.Priority}");
                Console.WriteLine($"Assigned To: {attribute.AssignedTo}");
            }
        }
    }
}



