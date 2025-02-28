using Newtonsoft.Json;
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string jsonString = File.ReadAllText("student.json");

        dynamic student = JsonConvert.DeserializeObject(jsonString);

        Console.WriteLine("Name: " + student.name);
        Console.WriteLine("Email: " + student.email);
    }
}