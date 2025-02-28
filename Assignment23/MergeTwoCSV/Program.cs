using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double Marks { get; set; }
    public string Grade { get; set; }

    public override string ToString()
    {
        return $"{Id},{Name},{Age},{Marks},{Grade}";
    }
}

class Program
{
    static void Main()
    {
        string file1 = "students1.csv"; // ID, Name, Age
        string file2 = "students2.csv"; // ID, Marks, Grade
        string outputFile = "merged_students.csv";

        Dictionary<int, Student> studentData = new Dictionary<int, Student>();

        if (File.Exists(file1) && File.Exists(file2))
        {
            string[] lines1 = File.ReadAllLines(file1).Skip(1).ToArray();
            string[] lines2 = File.ReadAllLines(file2).Skip(1).ToArray();

            foreach (string line in lines1)
            {
                string[] data = line.Split(',');
                int id = int.Parse(data[0].Trim());
                string name = data[1].Trim();
                int age = int.Parse(data[2].Trim());

                studentData[id] = new Student { Id = id, Name = name, Age = age };
            }

            foreach (string line in lines2)
            {
                string[] data = line.Split(',');
                int id = int.Parse(data[0].Trim());
                double marks = double.Parse(data[1].Trim());
                string grade = data[2].Trim();

                if (studentData.ContainsKey(id))
                {
                    studentData[id].Marks = marks;
                    studentData[id].Grade = grade;
                }
            }

            List<string> outputLines = new List<string> { "ID,Name,Age,Marks,Grade" };
            outputLines.AddRange(studentData.Values.Select(s => s.ToString()));

            File.WriteAllLines(outputFile, outputLines);

            Console.WriteLine("Merged CSV file created successfully!");
        }
        else
        {
            Console.WriteLine("One or both input files not found!");
        }
    }
}
