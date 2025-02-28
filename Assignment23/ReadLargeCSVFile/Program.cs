using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "large_students.csv";
        int batchSize = 100;
        int totalRecords = 0;

        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string header = reader.ReadLine(); 
                string line;
                int batchCount = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    batchCount++;
                    totalRecords++;

                    if (batchCount == batchSize)
                    {
                        Console.WriteLine($"Processed {totalRecords} records...");
                        batchCount = 0; // Reset batch count
                    }
                }

                if (batchCount > 0)
                    Console.WriteLine($"Processed {totalRecords} records...");

                Console.WriteLine($"Total records processed: {totalRecords}");
            }
        }
        else
        {
            Console.WriteLine("File not found!");
        }
    }
}
