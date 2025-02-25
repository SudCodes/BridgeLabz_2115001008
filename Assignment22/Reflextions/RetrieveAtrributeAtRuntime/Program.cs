using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
class Author : Attribute
{
    public string Name { get; }
    public Author(string name) => Name = name;
}

[Author("Rajesh Kumar")]
class SampleClass
{
    public void Display() => Console.WriteLine("SampleClass Method Executed.");
}

class Program
{
    static void Main()
    {
        Type type = typeof(SampleClass);
        Author attribute = (Author)Attribute.GetCustomAttribute(type, typeof(Author));

        if (attribute != null)
        {
            Console.WriteLine($"Author: {attribute.Name}");
        }
        else
        {
            Console.WriteLine("No Author Attribute Found.");
        }
    }
}
