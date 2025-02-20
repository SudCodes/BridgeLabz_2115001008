using System;
using System.IO;

class FileHandler
{
    static void Main()
    {
        string sourceFile = "D:\\Capgemini-Tranning\\Assignments\\Assignment20\\ReadAndWrite\\source.txt"; 
        string destinationFile = "D:\\Capgemini-Tranning\\Assignments\\Assignment20\\ReadAndWrite\\destination.txt";

        try
        {
            // Check if source file exists
            if (!File.Exists(sourceFile))
            {
                Console.WriteLine("Error: Source file does not exist.");
                return;
            }

            // Read content from source file
            using (FileStream fsRead = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(fsRead))
            {
                string content = reader.ReadToEnd();

                // Write content to destination file
                using (FileStream fsWrite = new FileStream(destinationFile, FileMode.Create, FileAccess.Write))
                using (StreamWriter writer = new StreamWriter(fsWrite))
                {
                    writer.Write(content);
                }
            }

            Console.WriteLine("File copied successfully!");
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
