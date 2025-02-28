using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "students.csv"; 
        Dictionary<int, string> records = new Dictionary<int, string>();
        List<string> duplicates = new List<string>();

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);

            for (int i = 1; i < lines.Length; i++) 
            {
                string[] data = lines[i].Split(',');
                int id = int.Parse(data[0].Trim());

                if (records.ContainsKey(id))
                {
                    duplicates.Add(lines[i]); 
                }
                else
                {
                    records[id] = lines[i];
                }
            }

            if (duplicates.Count > 0)
            {
                Console.WriteLine("Duplicate Records Found:");
                foreach (string record in duplicates)
                {
                    Console.WriteLine(record);
                }
            }
            else
            {
                Console.WriteLine("No duplicate records found.");
            }
        }
        else
        {
            Console.WriteLine("File not found!");
        }
    }
}
