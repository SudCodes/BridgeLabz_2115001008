using System;
using System.IO;
using System.Text;

class UpperToLowerConverter
{
    static void Main()
    {
        string sourceFile = "D:\\Capgemini-Tranning\\Assignments\\Assignment20\\ReadAndWrite\\input.txt";  
        string destinationFile = "D:\\Capgemini-Tranning\\Assignments\\Assignment20\\ReadAndWrite\\output.txt";  

        try
        {
            if (!File.Exists(sourceFile))
            {
                Console.WriteLine("Error: Source file does not exist.");
                return;
            }

            ConvertToLowercase(sourceFile, destinationFile);

            Console.WriteLine("Conversion completed successfully! Check 'output.txt'.");
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

    static void ConvertToLowercase(string source, string destination)
    {
        using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
        using (BufferedStream bsRead = new BufferedStream(fsRead))
        using (StreamReader reader = new StreamReader(bsRead, Encoding.UTF8))

        using (FileStream fsWrite = new FileStream(destination, FileMode.Create, FileAccess.Write))
        using (BufferedStream bsWrite = new BufferedStream(fsWrite))
        using (StreamWriter writer = new StreamWriter(bsWrite, Encoding.UTF8))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                writer.WriteLine(line.ToLower());  
            }
        }
    }
}
