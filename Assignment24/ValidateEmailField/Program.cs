using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        string schemaText = @"
        {
            ""type"": ""object"",
            ""properties"": {
                ""name"": { ""type"": ""string"" },
                ""email"": { ""type"": ""string"", ""format"": ""email"" }
            },
            ""required"": [""name"", ""email""]
        }";

        string jsonString = File.ReadAllText("user.json");

        JSchema schema = JSchema.Parse(schemaText);
        JObject jsonData = JObject.Parse(jsonString);

        if (jsonData.IsValid(schema, out IList<string> errors))
        {
            Console.WriteLine(" JSON is valid!");
        }
        else
        {
            Console.WriteLine(" JSON is invalid!");
            foreach (var error in errors)
            {
                Console.WriteLine($"Error: {error}");
            }
        }
    }
}