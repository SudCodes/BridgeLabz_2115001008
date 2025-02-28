﻿using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "employees.csv";

        if (File.Exists(filePath))
        {
            Console.Write("Enter employee name to search: ");
            string searchName = Console.ReadLine();

            string[] lines = File.ReadAllLines(filePath);
            bool found = false;

            for (int i = 1; i < lines.Length; i++) 
            {
                string[] data = lines[i].Split(',');
                string name = data[1].Trim();

                if (name.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Employee Found: Department: {data[2]}, Salary: {data[3]}");
                    found = true;
                    break;
                }
            }

            if (!found)
                Console.WriteLine("Employee not found.");
        }
        else
        {
            Console.WriteLine("File not found!");
        }
    }
}
