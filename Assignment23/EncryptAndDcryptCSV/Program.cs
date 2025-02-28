using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public decimal Salary { get; set; }
}

class Program
{
    private static readonly string encryptionKey = "MySecretKey12345"; // Must be 16, 24, or 32 bytes

    static void Main()
    {
        string csvFilePath = "employees_encrypted.csv";

        List<Employee> employees = new List<Employee>
        {
            new Employee { ID = 101, Name = "Rahul", Email = "rahul@example.com", Salary = 60000 },
            new Employee { ID = 102, Name = "Neha", Email = "neha@example.com", Salary = 50000 },
            new Employee { ID = 103, Name = "Amit", Email = "amit@example.com", Salary = 70000 }
        };

        WriteEncryptedCsv(csvFilePath, employees);
        ReadDecryptedCsv(csvFilePath);
    }

    static void WriteEncryptedCsv(string filePath, List<Employee> employees)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("ID,Name,Email,Salary"); // CSV Header
            foreach (var emp in employees)
            {
                string encryptedEmail = Encrypt(emp.Email, encryptionKey);
                string encryptedSalary = Encrypt(emp.Salary.ToString(), encryptionKey);
                writer.WriteLine($"{emp.ID},{emp.Name},{encryptedEmail},{encryptedSalary}");
            }
        }

        Console.WriteLine("CSV file with encrypted data written successfully!");
    }

    static void ReadDecryptedCsv(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("CSV file not found!");
            return;
        }

        Console.WriteLine("\nDecrypted CSV Data:");
        string[] lines = File.ReadAllLines(filePath);

        for (int i = 1; i < lines.Length; i++) // Skip header
        {
            string[] data = lines[i].Split(',');
            string decryptedEmail = Decrypt(data[2], encryptionKey);
            string decryptedSalary = Decrypt(data[3], encryptionKey);

            Console.WriteLine($"ID: {data[0]}, Name: {data[1]}, Email: {decryptedEmail}, Salary: {decryptedSalary}");
        }
    }

    static string Encrypt(string text, string key)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = Encoding.UTF8.GetBytes(key.PadRight(32)); // Ensure key is 32 bytes
            aes.IV = new byte[16]; // Default IV (zeroed)
            using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(text);
                byte[] encryptedBytes = encryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length);
                return Convert.ToBase64String(encryptedBytes);
            }
        }
    }

    static string Decrypt(string encryptedText, string key)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = Encoding.UTF8.GetBytes(key.PadRight(32));
            aes.IV = new byte[16];
            using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
            {
                byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
                byte[] decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
                return Encoding.UTF8.GetString(decryptedBytes);
            }
        }
    }
}
