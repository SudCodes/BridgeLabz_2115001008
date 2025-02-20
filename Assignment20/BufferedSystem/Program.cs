using System;
using System.Diagnostics;
using System.IO;

class FileCopyPerformance
{
    static void Main()
    {
        string sourceFile = "largefile.dat";  
        string destBuffered = "buffered_copy.dat"; 
        string destUnbuffered = "unbuffered_copy.dat";  

        try
        {
            if (!File.Exists(sourceFile))
            {
                Console.WriteLine("Error: Source file does not exist.");
                return;
            }

            Console.WriteLine("Starting file copy comparison...\n");

            // Measure Unbuffered File Copy
            Stopwatch stopwatch = Stopwatch.StartNew();
            CopyFileUnbuffered(sourceFile, destUnbuffered);
            stopwatch.Stop();
            Console.WriteLine($"Unbuffered Copy Time: {stopwatch.ElapsedMilliseconds} ms");

            // Measure Buffered File Copy
            stopwatch.Restart();
            CopyFileBuffered(sourceFile, destBuffered);
            stopwatch.Stop();
            Console.WriteLine($"Buffered Copy Time: {stopwatch.ElapsedMilliseconds} ms");

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

    static void CopyFileUnbuffered(string source, string destination)
    {
        using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
        using (FileStream fsWrite = new FileStream(destination, FileMode.Create, FileAccess.Write))
        {
            byte[] buffer = new byte[4096];  // 4 KB chunk size
            int bytesRead;

            while ((bytesRead = fsRead.Read(buffer, 0, buffer.Length)) > 0)
            {
                fsWrite.Write(buffer, 0, bytesRead);
            }
        }
    }

    static void CopyFileBuffered(string source, string destination)
    {
        using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
        using (BufferedStream bsRead = new BufferedStream(fsRead))
        using (FileStream fsWrite = new FileStream(destination, FileMode.Create, FileAccess.Write))
        using (BufferedStream bsWrite = new BufferedStream(fsWrite))
        {
            byte[] buffer = new byte[4096];  // 4 KB chunk size
            int bytesRead;

            while ((bytesRead = bsRead.Read(buffer, 0, buffer.Length)) > 0)
            {
                bsWrite.Write(buffer, 0, bytesRead);
            }
        }
    }
}
