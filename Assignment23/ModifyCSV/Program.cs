using System;
using System.IO;

class Program
{
    static void Main()
    {
        string inputFile = "employees.csv";
        string outputFile = "updated_employees.csv";

        if (File.Exists(inputFile))
        {
            string[] lines = File.ReadAllLines(inputFile);

            for (int i = 1; i < lines.Length; i++) // Skip header
            {
                string[] data = lines[i].Split(',');
                if (data[2].Trim().Equals("IT", StringComparison.OrdinalIgnoreCase))
                {
                    double salary = double.Parse(data[3]);
                    salary *= 1.10; // Increase by 10%
                    data[3] = salary.ToString("F2"); // Format to 2 decimal places
                    lines[i] = string.Join(",", data);
                }
            }

            File.WriteAllLines(outputFile, lines);
            Console.WriteLine("Updated salaries saved to 'updated_employees.csv'.");
        }
        else
        {
            Console.WriteLine("File not found!");
        }
    }
}
