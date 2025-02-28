using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        string jsonString = File.ReadAllText("data.json");
        JObject jsonData = JObject.Parse(jsonString);

        PrintJson(jsonData, "");
    }

    static void PrintJson(JObject jsonObject, string prefix)
    {
        foreach (var property in jsonObject.Properties())
        {
            string key = prefix + property.Name;

            if (property.Value is JObject nestedObject)
            {
                PrintJson(nestedObject, key + ".");
            }
            else if (property.Value is JArray jsonArray)
            {
                Console.WriteLine($"{key}: [Array]");
                foreach (var item in jsonArray)
                {
                    Console.WriteLine($"  - {item}");
                }
            }
            else
            {
                Console.WriteLine($"{key}: {property.Value}");
            }
        }
    }
}