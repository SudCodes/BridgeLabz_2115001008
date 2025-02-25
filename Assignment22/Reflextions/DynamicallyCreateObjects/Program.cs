using System;
using System.Reflection;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Student()
    {
        Name = "Default Name";
        Age = 18;
    }

    public void Display()
    {
        Console.WriteLine($"Student Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        Type type = typeof(Student);

        object studentInstance = Activator.CreateInstance(type);

        MethodInfo displayMethod = type.GetMethod("Display");
        displayMethod.Invoke(studentInstance, null);
    }
}
