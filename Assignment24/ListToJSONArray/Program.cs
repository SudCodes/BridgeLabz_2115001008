using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Xml;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Ankit", Age = 22, Email = "ankit123@gmail.com" },
            new Student { Name = "Babita", Age = 24, Email = "babita123@gmail.com" },
            new Student { Name = "Chaman", Age = 21, Email = "chaman234@gmail.com" }
        };

        string jsonString = JsonConvert.SerializeObject(students, Newtonsoft.Json.Formatting.Indented);

        Console.WriteLine(jsonString);
    }
}