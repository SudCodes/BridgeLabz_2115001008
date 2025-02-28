using System;
using System.Collections.Generic;
using System.IO;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double Marks { get; set; }

    public Student(int id, string name, int age, double marks)
    {
        Id = id;
        Name = name;
        Age = age;
        Marks = marks;
    }

    public override string ToString()
    {
        return $"Student {{ ID={Id}, Name='{Name}', Age={Age}, Marks={Marks} }}";
    }
}

class Program
{
    static void Main()
    {
        string filePath = "students.csv";
        List<Student> students = new List<Student>();

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);

            for (int i = 1; i < lines.Length; i++) // Skip header
            {
                string[] data = lines[i].Split(',');
                int id = int.Parse(data[0].Trim());
                string name = data[1].Trim();
                int age = int.Parse(data[2].Trim());
                double marks = double.Parse(data[3].Trim());

                students.Add(new Student(id, name, age, marks));
            }

            // Print all students
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }
        else
        {
            Console.WriteLine("File not found!");
        }
    }
}
