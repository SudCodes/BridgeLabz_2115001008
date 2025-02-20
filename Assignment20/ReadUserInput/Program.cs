using System;
using System.IO;

class UserInputToFile
{
    static void Main()
    {
        string filePath = "D:\\Capgemini-Tranning\\Assignments\\Assignment20\\ReadAndWrite\\user_data.txt"; 

        try
        {
            // Prompt user for input
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            string age = Console.ReadLine();

            Console.WriteLine("Enter your favorite programming language: ");
            string language = Console.ReadLine();

            // Save to file using StreamWriter
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine($"Name: {name}");
                writer.WriteLine($"Age: {age}");
                writer.WriteLine($"Favorite Programming Language: {language}");
            }

            Console.WriteLine("User data successfully saved to file.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"File operation failed: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
}
