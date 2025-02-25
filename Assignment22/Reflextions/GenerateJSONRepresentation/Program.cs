using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

class JsonConverter
{
    public static string ToJson(object obj)
    {
        Type type = obj.GetType();
        StringBuilder json = new StringBuilder("{");

        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
        List<string> jsonPairs = new List<string>();

        foreach (var field in fields)
        {
            string name = field.Name;
            object value = field.GetValue(obj);
            string formattedValue = value is string ? $"\"{value}\"" : value.ToString();
            jsonPairs.Add($"\"{name}\": {formattedValue}");
        }

        json.Append(string.Join(", ", jsonPairs));
        json.Append("}");

        return json.ToString();
    }
}

class Person
{
    private string name = "Amit Sharma";
    public int Age = 30;
}

class Program
{
    static void Main()
    {
        Person person = new Person();
        string json = JsonConverter.ToJson(person);
        Console.WriteLine(json);
    }
}
