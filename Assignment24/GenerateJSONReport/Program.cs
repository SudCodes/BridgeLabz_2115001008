using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        string csvFilePath = "students.csv";

        var students = ReadStudentsFromCsv(csvFilePath);

        string jsonReport = JsonConvert.SerializeObject(students, Newtonsoft.Json.Formatting.Indented);

        File.WriteAllText("StudentReport.json", jsonReport);

        Console.WriteLine("JSON report generated successfully!");
    }

    static List<Student> ReadStudentsFromCsv(string filePath)
    {
        var students = new List<Student>();
        var lines = File.ReadAllLines(filePath);

        foreach (var line in lines.Skip(1))
        {
            var values = line.Split(',');

            if (values.Length == 3)
            {
                students.Add(new Student
                {
                    Name = values[0].Trim(),
                    Age = int.Parse(values[1].Trim()),
                    Email = values[2].Trim()
                });
            }
        }

        return students;
    }
}

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
}