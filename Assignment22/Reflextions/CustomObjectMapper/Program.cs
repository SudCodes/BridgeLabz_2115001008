using System;
using System.Collections.Generic;
using System.Reflection;

class ObjectMapper
{
    public static T ToObject<T>(Type clazz, Dictionary<string, object> properties) where T : new()
    {
        T obj = (T)Activator.CreateInstance(clazz);

        foreach (var property in properties)
        {
            FieldInfo field = clazz.GetField(property.Key, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (field != null)
            {
                field.SetValue(obj, Convert.ChangeType(property.Value, field.FieldType));
            }
        }

        return obj;
    }
}

class Person
{
    private string name;
    public int Age;

    public void Display()
    {
        Console.WriteLine($"Name: {name}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        Dictionary<string, object> data = new Dictionary<string, object>
        {
            { "name", "Amit Sharma" },
            { "Age", 30 }
        };

        Person person = ObjectMapper.ToObject<Person>(typeof(Person), data);
        person.Display();
    }
}
