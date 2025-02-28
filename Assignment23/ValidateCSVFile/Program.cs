using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string filePath = "employees.csv";

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            string phonePattern = @"^\d{10}$";

            Console.WriteLine("Validating CSV Data...\n");

            for (int i = 1; i < lines.Length; i++) // Skip header
            {
                string[] data = lines[i].Split(',');

                if (data.Length < 4)
                {
                    Console.WriteLine($"Row {i + 1}: Incomplete data - {lines[i]}");
                    continue;
                }

                string email = data[2].Trim();
                string phone = data[3].Trim();

                bool isValidEmail = Regex.IsMatch(email, emailPattern);
                bool isValidPhone = Regex.IsMatch(phone, phonePattern);

                if (!isValidEmail)
                    Console.WriteLine($"Row {i + 1}: Invalid Email - {email}");

                if (!isValidPhone)
                    Console.WriteLine($"Row {i + 1}: Invalid Phone Number - {phone}");
            }
        }
        else
        {
            Console.WriteLine("File not found!");
        }
    }
}
