using System;
using System.IO;

class LargeFileReader
{
    static void Main()
    {
        string filePath = "D:\\Capgemini-Tranning\\Assignments\\Assignment20\\ReadAndWrite\\large_log.txt"; 

        try
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Error: File does not exist.");
                return;
            }

            Console.WriteLine("Reading file and filtering 'error' lines...\n");

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                int lineNumber = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    lineNumber++;

                    if (line.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        Console.WriteLine($"Line {lineNumber}: {line}");
                    }
                }
            }

            Console.WriteLine("\nProcessing completed.");
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
