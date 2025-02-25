using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        Console.Write("Enter class name: ");
        string className = Console.ReadLine();

        Type type = Type.GetType(className);
        if (type == null)
        {
            Console.WriteLine("Class not found.");
            return;
        }

        Console.WriteLine($"\nClass: {type.FullName}");

        Console.WriteLine("\nMethods:");
        foreach (MethodInfo method in type.GetMethods())
        {
            Console.WriteLine($"- {method.Name}");
        }

        Console.WriteLine("\nFields:");
        foreach (FieldInfo field in type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static))
        {
            Console.WriteLine($"- {field.Name} ({field.FieldType.Name})");
        }

        Console.WriteLine("\nConstructors:");
        foreach (ConstructorInfo constructor in type.GetConstructors())
        {
            Console.WriteLine($"- {constructor}");
        }
    }
}
