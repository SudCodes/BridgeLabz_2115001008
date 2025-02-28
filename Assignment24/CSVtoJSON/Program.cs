using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Xml;
using CsvHelper;
using CsvHelper.Configuration;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        string csvFilePath = "data.csv";

        using (var reader = new StreamReader(csvFilePath))
        using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
        {
            var records = csv.GetRecords<dynamic>();
            string jsonString = JsonConvert.SerializeObject(records, Formatting.Indented);

            Console.WriteLine(jsonString);
        }
    }
}