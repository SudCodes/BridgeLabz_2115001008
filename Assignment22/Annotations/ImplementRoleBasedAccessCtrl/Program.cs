using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
class RoleAllowed : Attribute
{
    public string Role { get; }
    public RoleAllowed(string role) => Role = role;
}

class SecureOperations
{
    [RoleAllowed("ADMIN")]
    public void AdminTask()
    {
        Console.WriteLine("Admin task executed.");
    }

    [RoleAllowed("USER")]
    public void UserTask()
    {
        Console.WriteLine("User task executed.");
    }
}

class Program
{
    static void ExecuteMethodIfAllowed(object instance, string methodName, string userRole)
    {
        MethodInfo method = instance.GetType().GetMethod(methodName);
        RoleAllowed attribute = (RoleAllowed)Attribute.GetCustomAttribute(method, typeof(RoleAllowed));

        if (attribute != null && attribute.Role == userRole)
        {
            method.Invoke(instance, null);
        }
        else
        {
            Console.WriteLine($"Access denied: {userRole} cannot execute {methodName}");
        }
    }

    static void Main()
    {
        SecureOperations operations = new SecureOperations();

        string currentUserRole = "ADMIN";
        ExecuteMethodIfAllowed(operations, "AdminTask", currentUserRole);
        ExecuteMethodIfAllowed(operations, "UserTask", currentUserRole);

        currentUserRole = "USER";
        ExecuteMethodIfAllowed(operations, "AdminTask", currentUserRole);
        ExecuteMethodIfAllowed(operations, "UserTask", currentUserRole);
    }
}
