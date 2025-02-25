using System;
using System.Reflection;

class Configuration
{
    private static string API_KEY = "DEFAULT_KEY";
}

class Program
{
    static void Main()
    {
        Type type = typeof(Configuration);
        FieldInfo field = type.GetField("API_KEY", BindingFlags.NonPublic | BindingFlags.Static);

        Console.WriteLine("Old API_KEY: " + field.GetValue(null));

        field.SetValue(null, "NEW_SECURE_KEY");

        Console.WriteLine("New API_KEY: " + field.GetValue(null));
    }
}
