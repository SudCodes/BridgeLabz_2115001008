using System;
using System.IO;
using System.Diagnostics;

class FileReadingComparison
{
    public static void ReadUsingStreamReader(string filePath)
    {
        using (StreamReader sr = new StreamReader(filePath))
        {
            while (sr.ReadLine() != null) { }
        }
    }

    public static void ReadUsingFileStream(string filePath)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.Open))
        {
            byte[] buffer = new byte[1024];
            while (fs.Read(buffer, 0, buffer.Length) > 0) { }
        }
    }

    public static void Main()
    {
        string filePath = "largefile.txt"; // Ensure this file exists

        Stopwatch sw = Stopwatch.StartNew();
        ReadUsingStreamReader(filePath);
        sw.Stop();
        Console.WriteLine("StreamReader Time: " + sw.ElapsedMilliseconds + " ms");

        sw = Stopwatch.StartNew();
        ReadUsingFileStream(filePath);
        sw.Stop();
        Console.WriteLine("FileStream Time: " + sw.ElapsedMilliseconds + " ms");
    }
}