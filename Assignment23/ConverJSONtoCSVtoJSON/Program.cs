using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using Newtonsoft.Json;

class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double Marks { get; set; }
}

class Program
{
    static void Main()
    {
        string jsonFilePath = "students.json";
        string csvFilePath = "students.csv";
        string newJsonFilePath = "students_converted.json";

        ConvertJsonToCsv(jsonFilePath, csvFilePath);
        ConvertCsvToJson(csvFilePath, newJsonFilePath);
    }

    static void ConvertJsonToCsv(string jsonPath, string csvPath)
    {
        if (!File.Exists(jsonPath))
        {
            Console.WriteLine("JSON file not found!");
            return;
        }

        List<Student> students = JsonConvert.DeserializeObject<List<Student>>(File.ReadAllText(jsonPath));

        using (StreamWriter writer = new StreamWriter(csvPath))
        {
            writer.WriteLine("ID,Name,Age,Marks"); // CSV Header
            foreach (var student in students)
            {
                writer.WriteLine($"{student.ID},{student.Name},{student.Age},{student.Marks}");
            }
        }

        Console.WriteLine("JSON converted to CSV successfully!");
    }

    static void ConvertCsvToJson(string csvPath, string jsonPath)
    {
        if (!File.Exists(csvPath))
        {
            Console.WriteLine("CSV file not found!");
            return;
        }

        List<Student> students = new List<Student>();
        string[] lines = File.ReadAllLines(csvPath);

        for (int i = 1; i < lines.Length; i++) // Skip header
        {
            string[] data = lines[i].Split(',');
            students.Add(new Student
            {
                ID = int.Parse(data[0].Trim()),
                Name = data[1].Trim(),
                Age = int.Parse(data[2].Trim()),
                Marks = double.Parse(data[3].Trim())
            });
        }

        File.WriteAllText(jsonPath, JsonConvert.SerializeObject(students, Formatting.Indented));
        Console.WriteLine("CSV converted back to JSON successfully!");
    }
}
