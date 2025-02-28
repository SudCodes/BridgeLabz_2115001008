using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "students.csv";

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            Console.WriteLine("Student Details:\n");

            for (int i = 1; i < lines.Length; i++) // Skip header
            {
                string[] data = lines[i].Split(',');
                Console.WriteLine($"ID: {data[0]}, Name: {data[1]}, Age: {data[2]}, Marks: {data[3]}");
            }
        }
        else
        {
            Console.WriteLine("File not found!");
        }
    }
}
