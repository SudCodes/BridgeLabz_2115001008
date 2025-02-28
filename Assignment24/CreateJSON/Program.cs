using Newtonsoft.Json;
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        var student = new
        {
            name = "Roshan Gupta",
            age = 20,
            subjects = new string[] { "Chemistry", "Physics", "Computer Science" }
        };

        string jsonString = JsonConvert.SerializeObject(student, Newtonsoft.Json.Formatting.Indented);
        Console.WriteLine(jsonString);
    }
}



