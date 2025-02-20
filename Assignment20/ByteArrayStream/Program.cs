using System;
using System.IO;

class ImageConverter
{
    static void Main()
    {
        string sourceImagePath = "D:\\Capgemini-Tranning\\Assignments\\Assignment20\\ReadAndWrite\\source.jpg";  
        string destinationImagePath = "D:\\Capgemini-Tranning\\Assignments\\Assignment20\\ReadAndWrite\\copied_image.jpg";  

        try
        {
            // Convert Image to Byte Array
            byte[] imageBytes = ConvertImageToByteArray(sourceImagePath);

            // Write Byte Array back to Image File
            WriteByteArrayToImage(destinationImagePath, imageBytes);

            // Verify if files are identical
            bool isIdentical = CompareFiles(sourceImagePath, destinationImagePath);
            Console.WriteLine(isIdentical ? "File copied successfully and is identical!" : "File copied but differs from the original.");
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

    static byte[] ConvertImageToByteArray(string filePath)
    {
        if (!File.Exists(filePath))
            throw new FileNotFoundException("Source image file not found.");

        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        using (MemoryStream ms = new MemoryStream())
        {
            fs.CopyTo(ms);
            return ms.ToArray();
        }
    }

    static void WriteByteArrayToImage(string filePath, byte[] imageBytes)
    {
        using (MemoryStream ms = new MemoryStream(imageBytes))
        using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        {
            ms.CopyTo(fs);
        }
    }

    static bool CompareFiles(string file1, string file2)
    {
        byte[] file1Bytes = File.ReadAllBytes(file1);
        byte[] file2Bytes = File.ReadAllBytes(file2);

        if (file1Bytes.Length != file2Bytes.Length)
            return false;

        for (int i = 0; i < file1Bytes.Length; i++)
        {
            if (file1Bytes[i] != file2Bytes[i])
                return false;
        }

        return true;
    }
}
