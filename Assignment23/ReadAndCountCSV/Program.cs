using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "employees.csv";

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            int recordCount = lines.Length - 1;

            Console.WriteLine($"Total Records: {recordCount}");
        }
        else
        {
            Console.WriteLine("File not found!");
        }
    }
}
