using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;
using System.Xml;

class Program
{
    static void Main()
    {
        string jsonString = File.ReadAllText("students.json");

        JArray students = JArray.Parse(jsonString);

        var filteredStudents = students
            .Where(s => s["Age"] != null && int.TryParse(s["Age"].ToString(), out int age) && age > 25)
            .ToList();

        Console.WriteLine(JsonConvert.SerializeObject(filteredStudents, Newtonsoft.Json.Formatting.Indented));
    }
}